using Microsoft.EntityFrameworkCore;
using QuanLySach_App.Models;
using System;
using System.Linq;
using System.Windows.Forms;
// Thay thế YourNamespace bằng namespace chứa Models do EF sinh ra (thường là QuanLySach_App.Models)


namespace QuanLySach_App
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
        }

        private void KhoiTaoDuLieu()
        {
            // Tắt tự động sinh cột để sử dụng các cột đã thiết kế sẵn trong Designer
            DataGV_DanMucSach.AutoGenerateColumns = false;
            txt_MaTL.DataPropertyName = "MaTl";
            txt_TenTL.DataPropertyName = "TenTheLoai";
            txt_MT.DataPropertyName = "MoTa";
            txt_SoLuong.DataPropertyName = "SoLuongSach";
            lbl_NgTao.DataPropertyName = "NgayTao";

            // Gắn sự kiện
            DataGV_DanMucSach.SelectionChanged += DataGV_DanMucSach_SelectionChanged;
            btn_Them.Click += Btn_Them_Click;
            btn_Sua.Click += Btn_Sua_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_LamMoi.Click += Btn_LamMoi_Click;
            btn_TimKiem.Click += Btn_TimKiem_Click;

            TaiDuLieu();
        }

        private void TaiDuLieu(string tuKhoa = "")
        {
            using (var context = new App_QuanLySachContext())
            {
                var query = context.TheLoaiSaches.AsQueryable();

                // Lọc dữ liệu bằng LINQ nếu có từ khóa tìm kiếm
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    query = query.Where(t => t.TenTheLoai.Contains(tuKhoa));
                }

                DataGV_DanMucSach.DataSource = query.ToList();
            }
        }

        private void DataGV_DanMucSach_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGV_DanMucSach.CurrentRow != null && DataGV_DanMucSach.CurrentRow.Index >= 0)
            {
                txt_MaTheLoai.Text = DataGV_DanMucSach.CurrentRow.Cells["txt_MaTL"].Value?.ToString();
                txt_TenTheLoai.Text = DataGV_DanMucSach.CurrentRow.Cells["txt_TenTL"].Value?.ToString();
                txt_MoTa.Text = DataGV_DanMucSach.CurrentRow.Cells["txt_MT"].Value?.ToString();
                txt_SoLg.Text = DataGV_DanMucSach.CurrentRow.Cells["txt_SoLuong"].Value?.ToString();
                var ngayTao = DataGV_DanMucSach.CurrentRow.Cells["lbl_NgTao"].Value;
                lbl_NgayTao.Text = ngayTao != null ? $"Ngày tạo: {Convert.ToDateTime(ngayTao):dd/MM/yyyy HH:mm}" : "";
            }
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txt_TenTheLoai.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenTheLoai))
            {
                MessageBox.Show("Tên thể loại không được bỏ trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenTheLoai.Focus();
                return;
            }

            // Lấy và xác thực dữ liệu Số lượng từ TextBox txt_SoLg[cite: 5]
            int soLuong = 0;
            if (!string.IsNullOrWhiteSpace(txt_SoLg.Text))
            {
                if (!int.TryParse(txt_SoLg.Text.Trim(), out soLuong) || soLuong < 0) 
            {
                    MessageBox.Show("Số lượng sách phải là số nguyên không âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_SoLg.SelectAll();
                    txt_SoLg.Focus();
                    return;
                }
            }

            using var context = new App_QuanLySachContext();

            bool daTonTai = context.TheLoaiSaches.Any(t => t.TenTheLoai == tenTheLoai);

            if (daTonTai)
            {
                MessageBox.Show("Tên thể loại này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenTheLoai.Focus();
                return;
            }

            var theLoaiMoi = new TheLoaiSach
            {
                TenTheLoai = tenTheLoai,
                MoTa = txt_MoTa.Text.Trim(),
                NgayTao = DateTime.Now,
                SoLuongSach = soLuong // Gán giá trị đã lấy từ txt_SoLg
            };

            context.TheLoaiSaches.Add(theLoaiMoi);
            context.SaveChanges(); // Thực thi lệnh INSERT dưới Database[cite: 6]

            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDuLieu();
            LamMoiTruongNhap();
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaTheLoai.Text)) return;

            if (string.IsNullOrWhiteSpace(txt_TenTheLoai.Text))
            {
                MessageBox.Show("Tên thể loại không được bỏ trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenTheLoai.Focus();
                return;
            }

            // Lấy và xác thực dữ liệu Số lượng từ TextBox txt_SoLg[cite: 5]
            int soLuong = 0;
            if (!string.IsNullOrWhiteSpace(txt_SoLg.Text))
            {
                if (!int.TryParse(txt_SoLg.Text.Trim(), out soLuong) || soLuong < 0)
                {
                    MessageBox.Show("Số lượng sách phải là số nguyên không âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_SoLg.SelectAll();
                    txt_SoLg.Focus();
                    return;
                }
            }

            int maTl = int.Parse(txt_MaTheLoai.Text);

            using (var context = new App_QuanLySachContext())
            {
                var theLoai = context.TheLoaiSaches.Find(maTl);
                if (theLoai != null)
                {
                    if (context.TheLoaiSaches.Any(t => t.MaTl != maTl && t.TenTheLoai.ToLower() == txt_TenTheLoai.Text.ToLower().Trim()))
                    {
                        MessageBox.Show("Tên thể loại đã được sử dụng bởi một mục khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    theLoai.TenTheLoai = txt_TenTheLoai.Text.Trim();
                    theLoai.MoTa = txt_MoTa.Text.Trim();
                    theLoai.SoLuongSach = soLuong; // Cập nhật giá trị Số lượng mới vào thực thể

                    context.SaveChanges(); // Thực thi lệnh UPDATE dưới Database[cite: 6]
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieu();
                }
            }
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaTheLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn một thể loại để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTl = int.Parse(txt_MaTheLoai.Text);
            string tenTl = txt_TenTheLoai.Text;

            var xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn xóa thể loại '{tenTl}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan == DialogResult.Yes)
            {
                using (var context = new App_QuanLySachContext())
                {
                    var theLoai = context.TheLoaiSaches.Find(maTl);
                    if (theLoai != null)
                    {
                        try
                        {
                            context.TheLoaiSaches.Remove(theLoai);
                            context.SaveChanges();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TaiDuLieu();
                            LamMoiTruongNhap();
                        }
                        catch (DbUpdateException) // Bắt lỗi khóa ngoại nếu thể loại đang chứa sách
                        {
                            MessageBox.Show("Không thể xóa thể loại này vì đang có sách thuộc thể loại này!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Truyền từ khóa vào hàm tải dữ liệu để tiến hành lọc LINQ
            TaiDuLieu(txt_TimKiem.Text.Trim());
        }

        private void Btn_LamMoi_Click(object sender, EventArgs e)
        {
            LamMoiTruongNhap();
            txt_TimKiem.Clear();
            TaiDuLieu();
        }

        private void LamMoiTruongNhap()
        {
            txt_MaTheLoai.Clear();
            txt_TenTheLoai.Clear();
            txt_MoTa.Clear();
            txt_SoLg.Clear();
            lbl_NgayTao.Text = "";
            txt_TenTheLoai.Focus();
            DataGV_DanMucSach.ClearSelection();
        }
    }
}