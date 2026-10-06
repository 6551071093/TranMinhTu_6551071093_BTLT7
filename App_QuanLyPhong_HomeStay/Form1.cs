using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using App_QuanLyPhong_HomeStay.Models; // Đảm bảo đúng namespace Models của bạn

namespace App_QuanLyPhong_HomeStay
{
    public partial class frm_MainScreen : Form
    {
        // Biến toàn cục để lưu tên file ảnh tạm khi người dùng bấm "Chọn ảnh"
        private string _tenFileAnh = "";

        public frm_MainScreen()
        {
            InitializeComponent();
            KhoiTaoGiaoDien();
        }

        private async void KhoiTaoGiaoDien()
        {
            dgv_DanhSachPhong.AutoGenerateColumns = false;
            txt_MaPhong.DataPropertyName = "MaPhong";
            txt_SoPhg.DataPropertyName = "SoPhong";
            txt_Tang.DataPropertyName = "TangSo";
            txt_TinhTrg.DataPropertyName = "TinhTrang";

            // LƯU Ý KIẾN TRÚC: Cột Ảnh, Tên Loại, Giá sẽ KHÔNG Map DataPropertyName trực tiếp.
            // Ta sẽ dùng sự kiện CellFormatting để lôi dữ liệu từ bảng LoaiPhong (bảng cha) sang.

            // Gắn sự kiện
            this.Load += async (s, e) => {
                await TaiDuLieuComboBoxAsync();
                await TaiDuLieuGridAsync();
            };
            btn_ChonAnh.Click += Btn_ChonAnh_Click;
            btn_Them.Click += Btn_Them_Click;
            btn_Sua.Click += Btn_Sua_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_LamMoi.Click += Btn_LamMoi_Click;
            btn_TimKiem.Click += Btn_TimKiem_Click;

            dgv_DanhSachPhong.SelectionChanged += Dgv_SelectionChanged;
            dgv_DanhSachPhong.CellFormatting += Dgv_CellFormatting;

            // Chỉnh cho ảnh vừa vặn với PictureBox và DataGridView
            picb_AnhPhong.SizeMode = PictureBoxSizeMode.Zoom;
            if (dgv_DanhSachPhong.Columns["pic_Anh"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        // 1. TẢI DỮ LIỆU LÊN COMBOBOX (TỪ BẢNG LOẠI PHÒNG)
        private async Task TaiDuLieuComboBoxAsync()
        {
            using (var context = new App_QuanLyPhongHomeStayContext())
            {
                var dsLoaiPhong = await context.LoaiPhongs.ToListAsync();

                // Đổ vào ComboBox nhập liệu
                cob_LoaiPhong.DataSource = new List<LoaiPhong>(dsLoaiPhong);
                cob_LoaiPhong.DisplayMember = "TenLoai";
                cob_LoaiPhong.ValueMember = "MaLoai";

                // Đổ vào ComboBox tìm kiếm (Thêm mục "Tất cả")
                var dsLoaiFilter = new List<LoaiPhong>(dsLoaiPhong);
                dsLoaiFilter.Insert(0, new LoaiPhong { MaLoai = 0, TenLoai = "Tất cả" });
                cob_LocTheoLoaiPhong.DataSource = dsLoaiFilter;
                cob_LocTheoLoaiPhong.DisplayMember = "TenLoai";
                cob_LocTheoLoaiPhong.ValueMember = "MaLoai";
                cob_LocTheoLoaiPhong.SelectedIndex = 0;

                cob_LocTheoTinhTrang.Items.Insert(0, "Tất cả");
                cob_LocTheoTinhTrang.SelectedIndex = 0;
            }
        }

        // 2. TẢI DỮ LIỆU LÊN GRID (CÓ KẾT HỢP INCLUDE)
        private async Task TaiDuLieuGridAsync(int filterMaLoai = 0, string filterTinhTrang = "Tất cả")
        {
            using (var context = new App_QuanLyPhongHomeStayContext())
            {
                var query = context.Phongs
                                   .Include(p => p.MaLoaiNavigation) // EAGER LOADING: Lấy kèm thông tin Loại phòng
                                   .AsQueryable();

                if (filterMaLoai > 0)
                {
                    query = query.Where(p => p.MaLoai == filterMaLoai);
                }
                if (filterTinhTrang != "Tất cả")
                {
                    query = query.Where(p => p.TinhTrang == filterTinhTrang);
                }

                dgv_DanhSachPhong.DataSource = await query.ToListAsync();
            }
        }

        // 3. HIỂN THỊ DỮ LIỆU PHỨC TẠP LÊN GRID (ẢNH + GIÁ + TÊN LOẠI)
        private void Dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_DanhSachPhong.Rows[e.RowIndex].DataBoundItem is Phong phong)
            {
                // Hiển thị tên loại
                if (dgv_DanhSachPhong.Columns[e.ColumnIndex].Name == "txt_LoaiPhg" && phong.MaLoaiNavigation != null)
                {
                    e.Value = phong.MaLoaiNavigation.TenLoai;
                }
                // Hiển thị giá
                else if (dgv_DanhSachPhong.Columns[e.ColumnIndex].Name == "txt_Gia_tren_dem" && phong.MaLoaiNavigation != null)
                {
                    e.Value = phong.MaLoaiNavigation.GiaMoiDem?.ToString("N0") + " VNĐ";
                }
                // Vẽ ảnh từ ổ cứng lên Grid
                else if (dgv_DanhSachPhong.Columns[e.ColumnIndex].Name == "pic_Anh" && !string.IsNullOrEmpty(phong.HinhAnh))
                {
                    string imgPath = Path.Combine(Application.StartupPath, "Images", phong.HinhAnh);
                    if (File.Exists(imgPath))
                    {
                        // Kỹ thuật đọc stream để không bị khóa file (tránh lỗi file đang được sử dụng)
                        using (var ms = new MemoryStream(File.ReadAllBytes(imgPath)))
                        {
                            e.Value = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        // 4. CHỌN ẢNH TỪ MÁY TÍNH & COPY VÀO PROJECT
        private void Btn_ChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourcePath = ofd.FileName;
                        // Tạo tên file mới tránh trùng lặp: NgayGio_TenGoc.jpg
                        _tenFileAnh = DateTime.Now.ToString("yyyyMMddHHmmss_") + Path.GetFileName(sourcePath);

                        string destFolder = Path.Combine(Application.StartupPath, "Images");
                        if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder); // Tự động tạo thư mục nếu chưa có

                        string destPath = Path.Combine(destFolder, _tenFileAnh);
                        File.Copy(sourcePath, destPath, true); // Copy ảnh vào thư mục Images của App

                        // Hiển thị lên PictureBox
                        using (var ms = new MemoryStream(File.ReadAllBytes(destPath)))
                        {
                            picb_AnhPhong.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 5. BINDING DỮ LIỆU KHI CHỌN DÒNG
        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachPhong.CurrentRow != null && dgv_DanhSachPhong.CurrentRow.DataBoundItem is Phong phong)
            {
                txt_SoPhong.Text = phong.SoPhong;
                numUD_TangSo.Value = phong.TangSo ?? 1;
                cob_LoaiPhong.SelectedValue = phong.MaLoai;
                cob_TinhTrang.SelectedItem = phong.TinhTrang;

                _tenFileAnh = phong.HinhAnh; // Giữ lại tên ảnh cũ phòng trường hợp chỉ sửa text

                if (!string.IsNullOrEmpty(phong.HinhAnh))
                {
                    string imgPath = Path.Combine(Application.StartupPath, "Images", phong.HinhAnh);
                    if (File.Exists(imgPath))
                    {
                        using (var ms = new MemoryStream(File.ReadAllBytes(imgPath)))
                        {
                            picb_AnhPhong.Image = Image.FromStream(ms);
                        }
                    }
                    else picb_AnhPhong.Image = null;
                }
                else picb_AnhPhong.Image = null;
            }
        }

        // 6. CÁC HÀM CRUD CƠ BẢN
        private async void Btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SoPhong.Text)) { MessageBox.Show("Nhập số phòng!"); return; }

            using (var context = new App_QuanLyPhongHomeStayContext())
            {
                if (context.Phongs.Any(p => p.SoPhong == txt_SoPhong.Text.Trim()))
                {
                    MessageBox.Show("Số phòng đã tồn tại!"); return;
                }

                var phg = new Phong
                {
                    SoPhong = txt_SoPhong.Text.Trim(),
                    TangSo = (int)numUD_TangSo.Value,
                    TinhTrang = cob_TinhTrang.SelectedItem?.ToString(),
                    MaLoai = (int?)cob_LoaiPhong.SelectedValue,
                    HinhAnh = _tenFileAnh // Chỉ lưu TÊN FILE vào CSDL
                };

                context.Phongs.Add(phg);
                await context.SaveChangesAsync();
                MessageBox.Show("Thêm thành công!");
                btn_LamMoi.PerformClick();
            }
        }

        private async void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachPhong.CurrentRow == null) return;

            int maPhong = (int)dgv_DanhSachPhong.CurrentRow.Cells["txt_MaPhong"].Value;

            using (var context = new App_QuanLyPhongHomeStayContext())
            {
                var phg = await context.Phongs.FindAsync(maPhong);
                if (phg != null)
                {
                    phg.SoPhong = txt_SoPhong.Text.Trim();
                    phg.TangSo = (int)numUD_TangSo.Value;
                    phg.TinhTrang = cob_TinhTrang.SelectedItem?.ToString();
                    phg.MaLoai = (int?)cob_LoaiPhong.SelectedValue;
                    phg.HinhAnh = _tenFileAnh; // Nếu bấm Chọn ảnh mới thì _tenFileAnh đã đổi, nếu không thì vẫn là tên cũ

                    await context.SaveChangesAsync();
                    MessageBox.Show("Cập nhật thành công!");
                    await TaiDuLieuGridAsync();
                }
            }
        }

        private async void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachPhong.CurrentRow == null) return;

            int maPhong = (int)dgv_DanhSachPhong.CurrentRow.Cells["txt_MaPhong"].Value;
            string soPhong = dgv_DanhSachPhong.CurrentRow.Cells["txt_SoPhg"].Value.ToString();

            if (MessageBox.Show($"Xóa phòng {soPhong}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var context = new App_QuanLyPhongHomeStayContext())
                {
                    var phg = await context.Phongs.FindAsync(maPhong);
                    if (phg != null)
                    {
                        context.Phongs.Remove(phg);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Xóa thành công!");
                        btn_LamMoi.PerformClick();
                    }
                }
            }
        }

        private async void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            int locLoai = cob_LocTheoLoaiPhong.SelectedValue != null ? (int)cob_LocTheoLoaiPhong.SelectedValue : 0;
            string locTT = cob_LocTheoTinhTrang.SelectedItem?.ToString() ?? "Tất cả";

            await TaiDuLieuGridAsync(locLoai, locTT);
        }

        private async void Btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_SoPhong.Clear();
            numUD_TangSo.Value = 1;
            cob_TinhTrang.SelectedIndex = 0;
            _tenFileAnh = "";
            picb_AnhPhong.Image = null;

            cob_LocTheoLoaiPhong.SelectedIndex = 0;
            cob_LocTheoTinhTrang.SelectedIndex = 0;

            await TaiDuLieuGridAsync();
        }
    }
}