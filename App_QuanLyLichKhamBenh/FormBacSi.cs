using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using App_QuanLyLichKhamBenh.Models; // Đảm bảo đúng Namespace Models của bạn

namespace App_QuanLyLichKhamBenh
{
    public partial class FormBacSi : Form
    {
        public FormBacSi()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();
        }

        private void KhoiTaoGiaoDien()
        {
            // 1. Tắt tự động sinh cột và Map dữ liệu (Fix triệt để lỗi trắng ô)
            dgv_DanhSachBacSi.AutoGenerateColumns = false;
            txt_MaBS.DataPropertyName = "MaBs";
            txt_TenBS.DataPropertyName = "HoTen";
            txt_SDT.DataPropertyName = "Sdt";
            txt_ChnKhoa.DataPropertyName = "ChuyenKhoa";

            textBox1.ReadOnly = true; // Khóa ô Mã BS (IDENTITY tự động tăng)

            // 2. Gắn sự kiện
            this.Load += async (s, e) => await TaiDuLieuAsync();
            btn_Them.Click += Btn_Them_Click;
            btn_Sua.Click += Btn_Sua_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_LamMoi.Click += Btn_LamMoi_Click;
            btn_TimKIem.Click += Btn_TimKiem_Click;
            dgv_DanhSachBacSi.SelectionChanged += Dgv_SelectionChanged;
        }

        // Tải dữ liệu bất đồng bộ + Lọc bằng LINQ
        private async Task TaiDuLieuAsync(string tuKhoa = "")
        {
            using (var context = new App_QuanLyLichKhamContext())
            {
                var query = context.BacSis.AsQueryable();

                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    // Lọc tìm kiếm theo cả Tên VÀ Chuyên khoa
                    query = query.Where(b => b.HoTen.Contains(tuKhoa) || b.ChuyenKhoa.Contains(tuKhoa));
                }

                dgv_DanhSachBacSi.DataSource = await query.ToListAsync();
            }
        }

        // Đổ dữ liệu từ Grid lên TextBox
        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachBacSi.CurrentRow != null && dgv_DanhSachBacSi.CurrentRow.Index >= 0)
            {
                var row = dgv_DanhSachBacSi.CurrentRow;
                textBox1.Text = row.Cells["txt_MaBS"].Value?.ToString();
                txt_HoTen.Text = row.Cells["txt_TenBS"].Value?.ToString();
                txt_SoDienThoai.Text = row.Cells["txt_SDT"].Value?.ToString();
                txt_ChuyenKhoa.Text = row.Cells["txt_ChnKhoa"].Value?.ToString();
            }
        }

        // Tách hàm Validate
        private bool KiemTraHopLe()
        {
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                MessageBox.Show("Họ tên bác sĩ không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_HoTen.Focus();
                return false;
            }
            return true;
        }

        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;

            using (var context = new App_QuanLyLichKhamContext())
            {
                var bsMoi = new BacSi
                {
                    HoTen = txt_HoTen.Text.Trim(),
                    Sdt = txt_SoDienThoai.Text.Trim(),
                    ChuyenKhoa = txt_ChuyenKhoa.Text.Trim()
                };

                context.BacSis.Add(bsMoi);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await TaiDuLieuAsync();
                btn_LamMoi.PerformClick();
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachBacSi.CurrentRow == null || string.IsNullOrWhiteSpace(textBox1.Text)) return;
            if (!KiemTraHopLe()) return;

            int maBs = int.Parse(textBox1.Text);

            using (var context = new App_QuanLyLichKhamContext())
            {
                var bs = await context.BacSis.FindAsync(maBs);
                if (bs != null)
                {
                    bs.HoTen = txt_HoTen.Text.Trim();
                    bs.Sdt = txt_SoDienThoai.Text.Trim();
                    bs.ChuyenKhoa = txt_ChuyenKhoa.Text.Trim();

                    await context.SaveChangesAsync();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await TaiDuLieuAsync();
                }
            }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachBacSi.CurrentRow == null || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn bác sĩ để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maBs = int.Parse(textBox1.Text);
            string tenBs = txt_HoTen.Text;

            var xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn xóa bác sĩ '{tenBs}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                using (var context = new App_QuanLyLichKhamContext())
                {
                    var bs = await context.BacSis.FindAsync(maBs);
                    if (bs != null)
                    {
                        context.BacSis.Remove(bs);
                        await context.SaveChangesAsync();

                        MessageBox.Show("Xóa bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_LamMoi.PerformClick();
                    }
                }
            }
        }

        private async void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            await TaiDuLieuAsync(txt_TimKiem.Text.Trim());
        }

        private async void Btn_LamMoi_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txt_HoTen.Clear();
            txt_SoDienThoai.Clear();
            txt_ChuyenKhoa.Clear();
            txt_TimKiem.Clear();

            dgv_DanhSachBacSi.ClearSelection();
            txt_HoTen.Focus();
            await TaiDuLieuAsync();
        }
    }
}