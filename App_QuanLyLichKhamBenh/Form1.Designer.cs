namespace App_QuanLyLichKhamBenh
{
    partial class frm_MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_TenBenhNhan = new Label();
            lbl_SoDienThoai = new Label();
            lbl_NgayKham = new Label();
            txt_TenBenhNhan = new TextBox();
            txt_SoDienThoai = new TextBox();
            dtp_NgayKham = new DateTimePicker();
            lbl_GioKham = new Label();
            dtp_GioKham = new DateTimePicker();
            cbo_BacSi = new ComboBox();
            lbl_BacSi = new Label();
            lbl_TrangThai = new Label();
            cbo_TrangThai = new ComboBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_LamMoi = new Button();
            lbl_TuNgay = new Label();
            dtp_TuNgay = new DateTimePicker();
            lbl_DenNgay = new Label();
            dtp_DenNgay = new DateTimePicker();
            cbo_TimKiem = new ComboBox();
            btn_TimKiem = new Button();
            dgv_DanhSachLichKham = new DataGridView();
            txt_MaLichKham = new DataGridViewTextBoxColumn();
            txt_TenBN = new DataGridViewTextBoxColumn();
            txt_SDT = new DataGridViewTextBoxColumn();
            txt_NgayKhm = new DataGridViewTextBoxColumn();
            txt_GioKhm = new DataGridViewTextBoxColumn();
            txt_TenBacSi = new DataGridViewTextBoxColumn();
            txt_ChuyenKhoa = new DataGridViewTextBoxColumn();
            txt_TrgThai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachLichKham).BeginInit();
            SuspendLayout();
            // 
            // lbl_TenBenhNhan
            // 
            lbl_TenBenhNhan.AutoSize = true;
            lbl_TenBenhNhan.Location = new Point(12, 9);
            lbl_TenBenhNhan.Name = "lbl_TenBenhNhan";
            lbl_TenBenhNhan.Size = new Size(105, 20);
            lbl_TenBenhNhan.TabIndex = 0;
            lbl_TenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // lbl_SoDienThoai
            // 
            lbl_SoDienThoai.AutoSize = true;
            lbl_SoDienThoai.Location = new Point(12, 59);
            lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            lbl_SoDienThoai.Size = new Size(97, 20);
            lbl_SoDienThoai.TabIndex = 1;
            lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // lbl_NgayKham
            // 
            lbl_NgayKham.AutoSize = true;
            lbl_NgayKham.Location = new Point(12, 97);
            lbl_NgayKham.Name = "lbl_NgayKham";
            lbl_NgayKham.Size = new Size(84, 20);
            lbl_NgayKham.TabIndex = 2;
            lbl_NgayKham.Text = "Ngày khám";
            // 
            // txt_TenBenhNhan
            // 
            txt_TenBenhNhan.Location = new Point(158, 6);
            txt_TenBenhNhan.Name = "txt_TenBenhNhan";
            txt_TenBenhNhan.Size = new Size(299, 27);
            txt_TenBenhNhan.TabIndex = 3;
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.Location = new Point(158, 56);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(299, 27);
            txt_SoDienThoai.TabIndex = 4;
            // 
            // dtp_NgayKham
            // 
            dtp_NgayKham.Format = DateTimePickerFormat.Short;
            dtp_NgayKham.Location = new Point(158, 92);
            dtp_NgayKham.Name = "dtp_NgayKham";
            dtp_NgayKham.Size = new Size(299, 27);
            dtp_NgayKham.TabIndex = 5;
            // 
            // lbl_GioKham
            // 
            lbl_GioKham.AutoSize = true;
            lbl_GioKham.Location = new Point(485, 63);
            lbl_GioKham.Name = "lbl_GioKham";
            lbl_GioKham.Size = new Size(72, 20);
            lbl_GioKham.TabIndex = 6;
            lbl_GioKham.Text = "Giờ khám";
            // 
            // dtp_GioKham
            // 
            dtp_GioKham.Format = DateTimePickerFormat.Time;
            dtp_GioKham.Location = new Point(485, 92);
            dtp_GioKham.Name = "dtp_GioKham";
            dtp_GioKham.Size = new Size(147, 27);
            dtp_GioKham.TabIndex = 7;
            // 
            // cbo_BacSi
            // 
            cbo_BacSi.FormattingEnabled = true;
            cbo_BacSi.Location = new Point(659, 91);
            cbo_BacSi.Name = "cbo_BacSi";
            cbo_BacSi.Size = new Size(344, 28);
            cbo_BacSi.TabIndex = 8;
            // 
            // lbl_BacSi
            // 
            lbl_BacSi.AutoSize = true;
            lbl_BacSi.Location = new Point(659, 63);
            lbl_BacSi.Name = "lbl_BacSi";
            lbl_BacSi.Size = new Size(47, 20);
            lbl_BacSi.TabIndex = 9;
            lbl_BacSi.Text = "Bác sĩ";
            // 
            // lbl_TrangThai
            // 
            lbl_TrangThai.AutoSize = true;
            lbl_TrangThai.Location = new Point(1009, 63);
            lbl_TrangThai.Name = "lbl_TrangThai";
            lbl_TrangThai.Size = new Size(75, 20);
            lbl_TrangThai.TabIndex = 10;
            lbl_TrangThai.Text = "Trạng thái";
            // 
            // cbo_TrangThai
            // 
            cbo_TrangThai.FormattingEnabled = true;
            cbo_TrangThai.Items.AddRange(new object[] { "Chờ khám", "Đã khám", "Đã hủy" });
            cbo_TrangThai.Location = new Point(1009, 91);
            cbo_TrangThai.Name = "cbo_TrangThai";
            cbo_TrangThai.Size = new Size(310, 28);
            cbo_TrangThai.TabIndex = 11;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = SystemColors.AppWorkspace;
            btn_Them.Location = new Point(902, 15);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(101, 39);
            btn_Them.TabIndex = 12;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = SystemColors.AppWorkspace;
            btn_Sua.Location = new Point(1009, 15);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(101, 39);
            btn_Sua.TabIndex = 13;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = SystemColors.AppWorkspace;
            btn_Xoa.Location = new Point(1116, 14);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(101, 39);
            btn_Xoa.TabIndex = 14;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.BackColor = SystemColors.AppWorkspace;
            btn_LamMoi.Location = new Point(1223, 12);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(101, 42);
            btn_LamMoi.TabIndex = 15;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = false;
            // 
            // lbl_TuNgay
            // 
            lbl_TuNgay.AutoSize = true;
            lbl_TuNgay.Location = new Point(12, 245);
            lbl_TuNgay.Name = "lbl_TuNgay";
            lbl_TuNgay.Size = new Size(62, 20);
            lbl_TuNgay.TabIndex = 16;
            lbl_TuNgay.Text = "Từ ngày";
            // 
            // dtp_TuNgay
            // 
            dtp_TuNgay.Format = DateTimePickerFormat.Short;
            dtp_TuNgay.Location = new Point(105, 240);
            dtp_TuNgay.Name = "dtp_TuNgay";
            dtp_TuNgay.Size = new Size(162, 27);
            dtp_TuNgay.TabIndex = 17;
            // 
            // lbl_DenNgay
            // 
            lbl_DenNgay.AutoSize = true;
            lbl_DenNgay.Location = new Point(297, 245);
            lbl_DenNgay.Name = "lbl_DenNgay";
            lbl_DenNgay.Size = new Size(72, 20);
            lbl_DenNgay.TabIndex = 18;
            lbl_DenNgay.Text = "Đến ngày";
            // 
            // dtp_DenNgay
            // 
            dtp_DenNgay.Format = DateTimePickerFormat.Short;
            dtp_DenNgay.Location = new Point(389, 240);
            dtp_DenNgay.Name = "dtp_DenNgay";
            dtp_DenNgay.Size = new Size(209, 27);
            dtp_DenNgay.TabIndex = 19;
            // 
            // cbo_TimKiem
            // 
            cbo_TimKiem.FormattingEnabled = true;
            cbo_TimKiem.Location = new Point(615, 239);
            cbo_TimKiem.Name = "cbo_TimKiem";
            cbo_TimKiem.Size = new Size(358, 28);
            cbo_TimKiem.TabIndex = 20;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = SystemColors.AppWorkspace;
            btn_TimKiem.Location = new Point(989, 232);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(101, 41);
            btn_TimKiem.TabIndex = 21;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachLichKham
            // 
            dgv_DanhSachLichKham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachLichKham.Columns.AddRange(new DataGridViewColumn[] { txt_MaLichKham, txt_TenBN, txt_SDT, txt_NgayKhm, txt_GioKhm, txt_TenBacSi, txt_ChuyenKhoa, txt_TrgThai });
            dgv_DanhSachLichKham.Location = new Point(12, 279);
            dgv_DanhSachLichKham.Name = "dgv_DanhSachLichKham";
            dgv_DanhSachLichKham.RowHeadersWidth = 51;
            dgv_DanhSachLichKham.Size = new Size(1312, 343);
            dgv_DanhSachLichKham.TabIndex = 22;
            // 
            // txt_MaLichKham
            // 
            txt_MaLichKham.HeaderText = "Mã lịch";
            txt_MaLichKham.MinimumWidth = 6;
            txt_MaLichKham.Name = "txt_MaLichKham";
            txt_MaLichKham.ReadOnly = true;
            txt_MaLichKham.Width = 120;
            // 
            // txt_TenBN
            // 
            txt_TenBN.HeaderText = "Tên bệnh nhân";
            txt_TenBN.MinimumWidth = 6;
            txt_TenBN.Name = "txt_TenBN";
            txt_TenBN.ReadOnly = true;
            txt_TenBN.Width = 190;
            // 
            // txt_SDT
            // 
            txt_SDT.HeaderText = "SĐT";
            txt_SDT.MinimumWidth = 6;
            txt_SDT.Name = "txt_SDT";
            txt_SDT.ReadOnly = true;
            txt_SDT.Width = 150;
            // 
            // txt_NgayKhm
            // 
            txt_NgayKhm.HeaderText = "Ngày Khám";
            txt_NgayKhm.MinimumWidth = 6;
            txt_NgayKhm.Name = "txt_NgayKhm";
            txt_NgayKhm.ReadOnly = true;
            txt_NgayKhm.Width = 150;
            // 
            // txt_GioKhm
            // 
            txt_GioKhm.HeaderText = "Giờ khám";
            txt_GioKhm.MinimumWidth = 6;
            txt_GioKhm.Name = "txt_GioKhm";
            txt_GioKhm.ReadOnly = true;
            txt_GioKhm.Width = 125;
            // 
            // txt_TenBacSi
            // 
            txt_TenBacSi.HeaderText = "Bác sĩ";
            txt_TenBacSi.MinimumWidth = 6;
            txt_TenBacSi.Name = "txt_TenBacSi";
            txt_TenBacSi.ReadOnly = true;
            txt_TenBacSi.Width = 220;
            // 
            // txt_ChuyenKhoa
            // 
            txt_ChuyenKhoa.HeaderText = "Chuyên khoa";
            txt_ChuyenKhoa.MinimumWidth = 6;
            txt_ChuyenKhoa.Name = "txt_ChuyenKhoa";
            txt_ChuyenKhoa.ReadOnly = true;
            txt_ChuyenKhoa.Width = 175;
            // 
            // txt_TrgThai
            // 
            txt_TrgThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_TrgThai.HeaderText = "Trạng thái";
            txt_TrgThai.MinimumWidth = 6;
            txt_TrgThai.Name = "txt_TrgThai";
            txt_TrgThai.ReadOnly = true;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 634);
            Controls.Add(dgv_DanhSachLichKham);
            Controls.Add(btn_TimKiem);
            Controls.Add(cbo_TimKiem);
            Controls.Add(dtp_DenNgay);
            Controls.Add(lbl_DenNgay);
            Controls.Add(dtp_TuNgay);
            Controls.Add(lbl_TuNgay);
            Controls.Add(btn_LamMoi);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(cbo_TrangThai);
            Controls.Add(lbl_TrangThai);
            Controls.Add(lbl_BacSi);
            Controls.Add(cbo_BacSi);
            Controls.Add(dtp_GioKham);
            Controls.Add(lbl_GioKham);
            Controls.Add(dtp_NgayKham);
            Controls.Add(txt_SoDienThoai);
            Controls.Add(txt_TenBenhNhan);
            Controls.Add(lbl_NgayKham);
            Controls.Add(lbl_SoDienThoai);
            Controls.Add(lbl_TenBenhNhan);
            Name = "frm_MainScreen";
            Text = "Quản Lý Lịch Khám - An Khang Clinic";
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachLichKham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TenBenhNhan;
        private Label lbl_SoDienThoai;
        private Label lbl_NgayKham;
        private TextBox txt_TenBenhNhan;
        private TextBox txt_SoDienThoai;
        private DateTimePicker dtp_NgayKham;
        private Label lbl_GioKham;
        private DateTimePicker dtp_GioKham;
        private ComboBox cbo_BacSi;
        private Label lbl_BacSi;
        private Label lbl_TrangThai;
        private ComboBox cbo_TrangThai;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_LamMoi;
        private Label lbl_TuNgay;
        private DateTimePicker dtp_TuNgay;
        private Label lbl_DenNgay;
        private DateTimePicker dtp_DenNgay;
        private ComboBox cbo_TimKiem;
        private Button btn_TimKiem;
        private DataGridView dgv_DanhSachLichKham;
        private DataGridViewTextBoxColumn txt_MaLichKham;
        private DataGridViewTextBoxColumn txt_TenBN;
        private DataGridViewTextBoxColumn txt_SDT;
        private DataGridViewTextBoxColumn txt_NgayKhm;
        private DataGridViewTextBoxColumn txt_GioKhm;
        private DataGridViewTextBoxColumn txt_TenBacSi;
        private DataGridViewTextBoxColumn txt_ChuyenKhoa;
        private DataGridViewTextBoxColumn txt_TrgThai;
    }
}
