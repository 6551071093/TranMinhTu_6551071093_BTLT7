using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using App_QuanLyLichKhamBenh.Models; // Đảm bảo namespace chứa model đúng với của bạn

namespace App_QuanLyLichKhamBenh
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();
        }

        private void KhoiTaoGiaoDien()
        {
            dgv_DanhSachLichKham.AutoGenerateColumns = false;

            // Map những cột cơ bản
            txt_MaLichKham.DataPropertyName = "MaLich";
            txt_TenBN.DataPropertyName = "TenBenhNhan";
            txt_SDT.DataPropertyName = "Sdt";
            txt_TrgThai.DataPropertyName = "TrangThai";

            // LƯU Ý KIẾN TRÚC: Cột Bác sĩ, Chuyên khoa, Ngày, Giờ sẽ KHÔNG Map DataPropertyName 
            // Ta sẽ dùng sự kiện CellFormatting để lôi từ bảng BacSi sang và format định dạng ngày giờ.

            // Khởi tạo ComboBox Trạng thái
            cbo_TrangThai.Items.Clear();
            cbo_TrangThai.Items.AddRange(new string[] { "Chờ khám", "Đã khám", "Đã hủy" });

            // Đăng ký sự kiện
            this.Load += async (s, e) => {
                await TaiDuLieuComboBoxAsync();
                btn_LamMoi.PerformClick(); // Load mặc định
            };

            btn_Them.Click += Btn_Them_Click;
            btn_Sua.Click += Btn_Sua_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_LamMoi.Click += Btn_LamMoi_Click;
            btn_TimKiem.Click += Btn_TimKiem_Click;

            dgv_DanhSachLichKham.SelectionChanged += Dgv_SelectionChanged;
            dgv_DanhSachLichKham.CellFormatting += Dgv_CellFormatting;
        }

        // 1. TẢI DỮ LIỆU COMBOBOX VÀ GỘP CHUỖI
        private async Task TaiDuLieuComboBoxAsync()
        {
            using (var context = new App_QuanLyLichKhamContext())
            {
                // Dùng LINQ Select để gộp Tên và Chuyên khoa hiển thị trên ComboBox
                var dsBacSi = await context.BacSis
                    .Select(bs => new {
                        MaBs = bs.MaBs,
                        HienThi = $"BS. {bs.HoTen} - {bs.ChuyenKhoa}"
                    }).ToListAsync();

                cbo_BacSi.DataSource = dsBacSi.ToList();
                cbo_BacSi.DisplayMember = "HienThi";
                cbo_BacSi.ValueMember = "MaBs";
                cbo_BacSi.SelectedIndex = -1;

                // Chuẩn bị ComboBox Lọc (Thêm mục Tất cả ở trên cùng)
                var dsLoc = dsBacSi.ToList();
                dsLoc.Insert(0, new { MaBs = 0, HienThi = "Tất cả bác sĩ" });
                cbo_TimKiem.DataSource = dsLoc;
                cbo_TimKiem.DisplayMember = "HienThi";
                cbo_TimKiem.ValueMember = "MaBs";
                cbo_TimKiem.SelectedIndex = 0;
            }
        }

        // 2. TẢI DỮ LIỆU GRID + LỌC ĐA ĐIỀU KIỆN
        private async Task TaiDuLieuGridAsync(int maBs = 0, DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            using (var context = new App_QuanLyLichKhamContext())
            {
                var query = context.LichKhams
                                   .Include(lk => lk.MaBsNavigation) // EAGER LOADING: Lấy kèm dữ liệu Bác Sĩ
                                   .AsQueryable();

                if (maBs > 0)
                {
                    query = query.Where(lk => lk.MaBs == maBs);
                }

                if (tuNgay.HasValue && denNgay.HasValue)
                {
                    // Ép kiểu từ DateTime (giao diện) sang DateOnly (EF Core Database) để so sánh
                    var tu = DateOnly.FromDateTime(tuNgay.Value.Date);
                    var den = DateOnly.FromDateTime(denNgay.Value.Date);
                    query = query.Where(lk => lk.NgayKham >= tu && lk.NgayKham <= den);
                }

                dgv_DanhSachLichKham.DataSource = await query.ToListAsync();
            }
        }

        // 3. HIỂN THỊ DỮ LIỆU 2 BẢNG LÊN GRID
        private void Dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_DanhSachLichKham.Rows[e.RowIndex].DataBoundItem is LichKham lk)
            {
                string colName = dgv_DanhSachLichKham.Columns[e.ColumnIndex].Name;

                // Lấy Tên và Chuyên khoa thông qua Navigation Property
                if (colName == "txt_TenBacSi" && lk.MaBsNavigation != null)
                {
                    e.Value = lk.MaBsNavigation.HoTen;
                }
                else if (colName == "txt_ChuyenKhoa" && lk.MaBsNavigation != null)
                {
                    e.Value = lk.MaBsNavigation.ChuyenKhoa;
                }
                // Định dạng hiển thị Ngày giờ
                else if (colName == "txt_NgayKhm" && lk.NgayKham.HasValue)
                {
                    e.Value = lk.NgayKham.Value.ToString("dd/MM/yyyy");
                }
                else if (colName == "txt_GioKhm" && lk.GioKham.HasValue)
                {
                    e.Value = lk.GioKham.Value.ToString("HH:mm");
                }
            }
        }

        // 4. CHỌN DÒNG TRÊN GRID -> ĐỔ LÊN Ô NHẬP LIỆU
        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachLichKham.CurrentRow != null && dgv_DanhSachLichKham.CurrentRow.Index >= 0)
            {
                if (dgv_DanhSachLichKham.CurrentRow.DataBoundItem is LichKham lk)
                {
                    txt_TenBenhNhan.Text = lk.TenBenhNhan;
                    txt_SoDienThoai.Text = lk.Sdt;
                    cbo_TrangThai.SelectedItem = lk.TrangThai;

                    // Nếu Lịch khám này Bác sĩ đã bị xóa (MaBs = NULL) thì reset ComboBox
                    if (lk.MaBs.HasValue)
                        cbo_BacSi.SelectedValue = lk.MaBs.Value;
                    else
                        cbo_BacSi.SelectedIndex = -1;

                    // Dịch ngược từ DateOnly/TimeOnly thành DateTime cho DateTimePicker
                    if (lk.NgayKham.HasValue)
                        dtp_NgayKham.Value = lk.NgayKham.Value.ToDateTime(TimeOnly.MinValue);

                    if (lk.GioKham.HasValue)
                        dtp_GioKham.Value = DateTime.Today.Add(lk.GioKham.Value.ToTimeSpan());
                }
            }
        }

        // 5. VALIDATION: KIỂM TRA LOGIC NGHIỆP VỤ
        private bool ValidateDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txt_TenBenhNhan.Text))
            {
                MessageBox.Show("Tên bệnh nhân không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenBenhNhan.Focus();
                return false;
            }

            if (cbo_BacSi.SelectedValue == null || (int)cbo_BacSi.SelectedValue == 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ khám!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_BacSi.Focus();
                return false;
            }

            // Chặn đặt lịch trong quá khứ
            if (dtp_NgayKham.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Không thể đặt lịch khám vào ngày trong quá khứ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_NgayKham.Focus();
                return false;
            }

            return true;
        }

        // 6. CÁC HÀM THÊM, SỬA, XÓA VÀ LỌC TÌM KIẾM
        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateDuLieu()) return;

            using (var context = new App_QuanLyLichKhamContext())
            {
                var lkMoi = new LichKham
                {
                    TenBenhNhan = txt_TenBenhNhan.Text.Trim(),
                    Sdt = txt_SoDienThoai.Text.Trim(),
                    NgayKham = DateOnly.FromDateTime(dtp_NgayKham.Value), // Đổi DateTime sang DateOnly
                    GioKham = TimeOnly.FromDateTime(dtp_GioKham.Value),   // Đổi DateTime sang TimeOnly
                    MaBs = (int)cbo_BacSi.SelectedValue,
                    TrangThai = cbo_TrangThai.SelectedItem?.ToString() ?? "Chờ khám"
                };

                context.LichKhams.Add(lkMoi);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_LamMoi.PerformClick();
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachLichKham.CurrentRow == null) return;
            if (!ValidateDuLieu()) return;

            int maLich = (int)dgv_DanhSachLichKham.CurrentRow.Cells["txt_MaLichKham"].Value;

            using (var context = new App_QuanLyLichKhamContext())
            {
                var lk = await context.LichKhams.FindAsync(maLich);
                if (lk != null)
                {
                    lk.TenBenhNhan = txt_TenBenhNhan.Text.Trim();
                    lk.Sdt = txt_SoDienThoai.Text.Trim();
                    lk.NgayKham = DateOnly.FromDateTime(dtp_NgayKham.Value);
                    lk.GioKham = TimeOnly.FromDateTime(dtp_GioKham.Value);
                    lk.MaBs = (int)cbo_BacSi.SelectedValue;
                    lk.TrangThai = cbo_TrangThai.SelectedItem?.ToString();

                    await context.SaveChangesAsync();
                    MessageBox.Show("Cập nhật lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_TimKiem.PerformClick(); // Load lại data theo trạng thái tìm kiếm hiện tại
                }
            }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachLichKham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch khám cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maLich = (int)dgv_DanhSachLichKham.CurrentRow.Cells["txt_MaLichKham"].Value;
            string tenBn = dgv_DanhSachLichKham.CurrentRow.Cells["txt_TenBN"].Value?.ToString();

            var xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn hủy và xóa lịch khám của bệnh nhân '{tenBn}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                using (var context = new App_QuanLyLichKhamContext())
                {
                    var lk = await context.LichKhams.FindAsync(maLich);
                    if (lk != null)
                    {
                        context.LichKhams.Remove(lk);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Xóa lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_LamMoi.PerformClick();
                    }
                }
            }
        }

        private async void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            int locBs = cbo_TimKiem.SelectedValue != null ? (int)cbo_TimKiem.SelectedValue : 0;
            DateTime tuNgay = dtp_TuNgay.Value;
            DateTime denNgay = dtp_DenNgay.Value;

            if (tuNgay.Date > denNgay.Date)
            {
                MessageBox.Show("'Từ ngày' không được lớn hơn 'Đến ngày'!", "Lỗi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await TaiDuLieuGridAsync(locBs, tuNgay, denNgay);
        }

        private async void Btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TenBenhNhan.Clear();
            txt_SoDienThoai.Clear();
            dtp_NgayKham.Value = DateTime.Now;
            dtp_GioKham.Value = DateTime.Now;
            cbo_TrangThai.SelectedIndex = 0;
            cbo_BacSi.SelectedIndex = -1;

            // Reset bộ lọc tìm kiếm
            cbo_TimKiem.SelectedIndex = 0;
            dtp_TuNgay.Value = DateTime.Now.AddDays(-7);
            dtp_DenNgay.Value = DateTime.Now.AddDays(7);

            dgv_DanhSachLichKham.ClearSelection();
            txt_TenBenhNhan.Focus();
            await TaiDuLieuGridAsync(0, dtp_TuNgay.Value, dtp_DenNgay.Value);
        }
    }
}