using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_QuanLyHoiVienPhongGym.Models; // Đảm bảo đúng Namespace chứa Model của bạn
using Microsoft.EntityFrameworkCore;

namespace App_QuanLyHoiVienPhongGym
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();
        }

        // 1. CẤU HÌNH GIAO DIỆN VÀ MAP CỘT
        private void KhoiTaoGiaoDien()
        {
            dataGridView1.AutoGenerateColumns = false;

            // Đổ dữ liệu cứng cho ComboBox
            cob_HangThannhVien.Items.AddRange(new string[] { "Basic", "VIP", "Premium" });
            cbo_HangThanhVien_Filter.Items.AddRange(new string[] { "Tất cả", "Basic", "VIP", "Premium" });
            cbo_HangThanhVien_Filter.SelectedIndex = 0;

            // Map cột DataGridView với các Property của Model HoiVien
            MaHV.DataPropertyName = "MaHv";
            txt_Ten.DataPropertyName = "HoTen";
            txt_GioiTinh.DataPropertyName = "GioiTinh";
            txt_NgSinh.DataPropertyName = "NgaySinh";
            txt_SoDienThoai.DataPropertyName = "Sdt";

            // CẬP NHẬT MỚI: Map cột txt_e_mail bạn vừa thiết kế với property Email trong Database
            txt_e_mail.DataPropertyName = "Email";

            txt_HangTV.DataPropertyName = "HangThanhVien";
            txt_TrangThai.DataPropertyName = "TrangThai";

            // Đăng ký sự kiện
            this.Load += async (s, e) => await TaiDuLieuAsync(); // Tải dữ liệu khi mở form
            btn_Them.Click += Btn_Them_Click;
            btn_Sua.Click += Btn_Sua_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_LamMoi.Click += Btn_LamMoi_Click;
            btn_TimKiem.Click += Btn_TimKiem_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        // 2. TẢI DỮ LIỆU & TÌM KIẾM BẰNG LINQ
        private async Task TaiDuLieuAsync(string tuKhoa = "", string hangTV = "Tất cả")
        {
            using (var context = new QuanLyHoiVien_GymContext())
            {
                var query = context.HoiViens.AsQueryable();

                // Lọc đa điều kiện
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    query = query.Where(hv => hv.HoTen.Contains(tuKhoa));
                }

                if (hangTV != "Tất cả")
                {
                    query = query.Where(hv => hv.HangThanhVien == hangTV);
                }

                dataGridView1.DataSource = await query.ToListAsync();
            }
        }

        // 3. ĐỊNH DẠNG LẠI DỮ LIỆU GRID THAY VÌ HIỆN TRUE/FALSE
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "txt_GioiTinh" && e.Value != null)
            {
                e.Value = (bool)e.Value ? "Nam" : "Nữ";
                e.FormattingApplied = true;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "txt_TrangThai" && e.Value != null)
            {
                e.Value = (bool)e.Value ? "Đang hoạt động" : "Tạm khóa";
                e.FormattingApplied = true;
            }
        }

        // 4. BINDING DỮ LIỆU TỪ GRID LÊN CÁC CONTROL
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                var row = dataGridView1.CurrentRow;

                // Bây giờ Email đã hiển thị trên Grid, ta có thể lấy trực tiếp từ Cell một cách dễ dàng
                txt_HoTen.Text = row.Cells["txt_Ten"].Value?.ToString();
                txt_SDT.Text = row.Cells["txt_SoDienThoai"].Value?.ToString();
                txt_Email.Text = row.Cells["txt_e_mail"].Value?.ToString(); // Lấy từ cột bạn vừa thêm

                // Vẫn dùng DataBoundItem để xử lý dễ dàng các kiểu dữ liệu phức tạp (như DateOnly)
                if (row.DataBoundItem is HoiVien hv)
                {
                    if (hv.GioiTinh == true) rbtn_Nam.Checked = true;
                    else rbtn_Nu.Checked = true;

                    if (hv.NgaySinh.HasValue)
                    {
                        dtp_NgaySinh.Value = hv.NgaySinh.Value.ToDateTime(TimeOnly.MinValue);
                    }

                    cob_HangThannhVien.SelectedItem = hv.HangThanhVien;
                    ckb_DangHoatDong.Checked = hv.TrangThai ?? false;
                }
            }
        }

        // 5. VALIDATION
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_HoTen.Focus();
                return false;
            }

            string sdt = txt_SDT.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt) || sdt.Length < 9 || sdt.Length > 11 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số và độ dài 9-11 ký tự!", "Lỗi Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SDT.Focus();
                return false;
            }

            string email = txt_Email.Text.Trim();
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Email bắt buộc phải chứa ký tự '@'!", "Lỗi Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return false;
            }

            int tuoi = DateTime.Now.Year - dtp_NgaySinh.Value.Year;
            if (dtp_NgaySinh.Value.Date > DateTime.Now.AddYears(-tuoi)) tuoi--;

            if (tuoi < 15)
            {
                MessageBox.Show("Hội viên đăng ký phải từ đủ 15 tuổi trở lên!", "Lỗi Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_NgaySinh.Focus();
                return false;
            }

            return true;
        }

        // 6. CÁC HÀM CRUD
        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            using (var context = new QuanLyHoiVien_GymContext())
            {
                var hvMoi = new HoiVien
                {
                    HoTen = txt_HoTen.Text.Trim(),
                    Sdt = txt_SDT.Text.Trim(),
                    Email = txt_Email.Text.Trim(), // Lấy từ TextBox, tự động lưu xuống DB và cập nhật lên DataGridView
                    GioiTinh = rbtn_Nam.Checked,
                    NgaySinh = DateOnly.FromDateTime(dtp_NgaySinh.Value),
                    HangThanhVien = cob_HangThannhVien.SelectedItem?.ToString(),
                    TrangThai = ckb_DangHoatDong.Checked
                };

                context.HoiViens.Add(hvMoi);
                 await context.SaveChangesAsync();
                MessageBox.Show("Thêm mới hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await TaiDuLieuAsync();
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || !KiemTraDuLieu()) return;

            int maHv = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaHV"].Value);

            using (var context = new QuanLyHoiVien_GymContext())
            {
                var hv = await context.HoiViens.FindAsync(maHv);
                if (hv != null)
                {
                    hv.HoTen = txt_HoTen.Text.Trim();
                    hv.Sdt = txt_SDT.Text.Trim();
                    hv.Email = txt_Email.Text.Trim(); // Lấy từ TextBox
                    hv.GioiTinh = rbtn_Nam.Checked;
                    hv.NgaySinh = DateOnly.FromDateTime(dtp_NgaySinh.Value);
                    hv.HangThanhVien = cob_HangThannhVien.SelectedItem?.ToString();
                    hv.TrangThai = ckb_DangHoatDong.Checked;

                    await context.SaveChangesAsync();

                    MessageBox.Show("Cập nhật thông tin hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await TaiDuLieuAsync();
                }
            }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hội viên để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHv = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaHV"].Value);
            string tenHv = dataGridView1.CurrentRow.Cells["txt_Ten"].Value.ToString();

            var xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn xóa hội viên '{tenHv}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                using (var context = new QuanLyHoiVien_GymContext())
                {
                    var hv = await context.HoiViens.FindAsync(maHv);
                    if (hv != null)
                    {
                        context.HoiViens.Remove(hv);
                        await context.SaveChangesAsync();

                        MessageBox.Show("Xóa hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_LamMoi.PerformClick();
                    }
                }
            }
        }

        private async void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txt_TimKiem.Text.Trim();
            string hangTV = cbo_HangThanhVien_Filter.SelectedItem?.ToString() ?? "Tất cả";

            await TaiDuLieuAsync(tuKhoa, hangTV);
        }

        private async void Btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_HoTen.Clear();
            txt_SDT.Clear();
            txt_Email.Clear();
            txt_TimKiem.Clear();
            rbtn_Nam.Checked = true;
            dtp_NgaySinh.Value = DateTime.Now.AddYears(-15);
            cob_HangThannhVien.SelectedIndex = 0;
            cbo_HangThanhVien_Filter.SelectedIndex = 0;
            ckb_DangHoatDong.Checked = false;

            dataGridView1.ClearSelection();
            txt_HoTen.Focus();
            await TaiDuLieuAsync();
        }
    }
}