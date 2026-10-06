using App_QuanLyPhong_HomeStay.Models; // Namespace chứa Models của bạn
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QuanLyPhong_HomeStay
{
    public partial class frm_LoaiPhong : Form
    {
        public frm_LoaiPhong()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();
        }

        private void KhoiTaoGiaoDien()
        {
            // Tắt tự động sinh cột DataGridView
            dgv_DanhSachLoaiPhong.AutoGenerateColumns = false;
            txt_MaLoaiPhong.DataPropertyName = "MaLoai";      // Tên cột UI = Tên thuộc tính Model
            txt_TenLoaiphong.DataPropertyName = "TenLoai";
            txt_Gia.DataPropertyName = "GiaMoiDem";
            txt_MoTaPhong.DataPropertyName = "MoTa";

            // Gắn sự kiện
            this.Load += async (s, e) => await TaiDuLieuAsync();
            btn_Them.Click += Btn_Them_Click;
            btn_Sua.Click += Btn_Sua_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_LamMoi.Click += Btn_LamMoi_Click;
            btn_TimKiem.Click += Btn_TimKiem_Click;
            dgv_DanhSachLoaiPhong.SelectionChanged += Dgv_SelectionChanged;
        }

        private async Task TaiDuLieuAsync(string tuKhoa = "")
        {
            using (var context = new App_QuanLyPhongHomeStayContext())
            {
                var query = context.LoaiPhongs.AsQueryable();

                // Tìm kiếm theo tên loại
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    query = query.Where(lp => lp.TenLoai.Contains(tuKhoa));
                }

                dgv_DanhSachLoaiPhong.DataSource = await query.ToListAsync();
            }
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachLoaiPhong.CurrentRow != null && dgv_DanhSachLoaiPhong.CurrentRow.Index >= 0)
            {
                var row = dgv_DanhSachLoaiPhong.CurrentRow;
                txt_MaLoai.Text = row.Cells["txt_MaLoaiPhong"].Value?.ToString();
                txt_TenLoai.Text = row.Cells["txt_TenLoaiphong"].Value?.ToString();

                // Hiển thị giá trị decimal của Giá mỗi đêm
                txt_Gia_tren_dem.Text = row.Cells["txt_Gia"].Value?.ToString();
                txt_MoTa.Text = row.Cells["txt_MoTaPhong"].Value?.ToString();
            }
        }

        // Tách riêng luồng kiểm tra dữ liệu, dùng từ khóa 'out' để lấy được con số giá tiền đã ép kiểu an toàn
        private bool KiemTraHopLe(out decimal giaMoiDem)
        {
            giaMoiDem = 0;
            if (string.IsNullOrWhiteSpace(txt_TenLoai.Text))
            {
                MessageBox.Show("Tên loại phòng không được để trống!", "Lỗi Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenLoai.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txt_Gia_tren_dem.Text))
            {
                if (!decimal.TryParse(txt_Gia_tren_dem.Text.Trim(), out giaMoiDem) || giaMoiDem < 0)
                {
                    MessageBox.Show("Giá mỗi đêm phải là một con số hợp lệ (lớn hơn hoặc bằng 0)!", "Lỗi Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Gia_tren_dem.Focus();
                    return false;
                }
            }
            return true;
        }

        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe(out decimal gia)) return;

            using (var context = new App_QuanLyPhongHomeStayContext())
            {
                var lpMoi = new LoaiPhong
                {
                    TenLoai = txt_TenLoai.Text.Trim(),
                    GiaMoiDem = gia,
                    MoTa = txt_MoTa.Text.Trim()
                };

                context.LoaiPhongs.Add(lpMoi);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await TaiDuLieuAsync();
                btn_LamMoi.PerformClick();
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachLoaiPhong.CurrentRow == null || string.IsNullOrWhiteSpace(txt_MaLoai.Text)) return;
            if (!KiemTraHopLe(out decimal gia)) return;

            int maLoai = int.Parse(txt_MaLoai.Text);

            using (var context = new App_QuanLyPhongHomeStayContext())
            {
                var lp = await context.LoaiPhongs.FindAsync(maLoai);
                if (lp != null)
                {
                    lp.TenLoai = txt_TenLoai.Text.Trim();
                    lp.GiaMoiDem = gia;
                    lp.MoTa = txt_MoTa.Text.Trim();

                    await context.SaveChangesAsync();
                    MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await TaiDuLieuAsync();
                }
            }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachLoaiPhong.CurrentRow == null || string.IsNullOrWhiteSpace(txt_MaLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn một loại phòng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maLoai = int.Parse(txt_MaLoai.Text);
            string tenLoai = txt_TenLoai.Text;

            var xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn xóa loại phòng '{tenLoai}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                using (var context = new App_QuanLyPhongHomeStayContext())
                {
                    var lp = await context.LoaiPhongs.FindAsync(maLoai);
                    if (lp != null)
                    {
                        context.LoaiPhongs.Remove(lp);
                        await context.SaveChangesAsync();

                        MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txt_MaLoai.Clear();
            txt_TenLoai.Clear();
            txt_Gia_tren_dem.Clear();
            txt_MoTa.Clear();
            txt_TimKiem.Clear();

            dgv_DanhSachLoaiPhong.ClearSelection();
            txt_TenLoai.Focus();
            await TaiDuLieuAsync();
        }
    }
}