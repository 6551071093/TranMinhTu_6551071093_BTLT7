namespace App_QuanLyPhong_HomeStay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainScreen));
            lbl_SoPhong = new Label();
            lbl_TangSo = new Label();
            lbl_LoaiPhong = new Label();
            lbl_TinhTrang = new Label();
            txt_SoPhong = new TextBox();
            numUD_TangSo = new NumericUpDown();
            cob_TinhTrang = new ComboBox();
            cob_LoaiPhong = new ComboBox();
            picb_AnhPhong = new PictureBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_LamMoi = new Button();
            btn_ChonAnh = new Button();
            cob_LocTheoLoaiPhong = new ComboBox();
            cob_LocTheoTinhTrang = new ComboBox();
            btn_TimKiem = new Button();
            dgv_DanhSachPhong = new DataGridView();
            txt_MaPhong = new DataGridViewTextBoxColumn();
            pic_Anh = new DataGridViewImageColumn();
            txt_SoPhg = new DataGridViewTextBoxColumn();
            txt_Tang = new DataGridViewTextBoxColumn();
            txt_LoaiPhg = new DataGridViewTextBoxColumn();
            txt_Gia_tren_dem = new DataGridViewTextBoxColumn();
            txt_TinhTrg = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numUD_TangSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_AnhPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachPhong).BeginInit();
            SuspendLayout();
            // 
            // lbl_SoPhong
            // 
            lbl_SoPhong.AutoSize = true;
            lbl_SoPhong.Location = new Point(12, 9);
            lbl_SoPhong.Name = "lbl_SoPhong";
            lbl_SoPhong.Size = new Size(73, 20);
            lbl_SoPhong.TabIndex = 0;
            lbl_SoPhong.Text = "Số phòng";
            // 
            // lbl_TangSo
            // 
            lbl_TangSo.AutoSize = true;
            lbl_TangSo.Location = new Point(195, 9);
            lbl_TangSo.Name = "lbl_TangSo";
            lbl_TangSo.Size = new Size(61, 20);
            lbl_TangSo.TabIndex = 1;
            lbl_TangSo.Text = "Tầng số";
            // 
            // lbl_LoaiPhong
            // 
            lbl_LoaiPhong.AutoSize = true;
            lbl_LoaiPhong.Location = new Point(361, 9);
            lbl_LoaiPhong.Name = "lbl_LoaiPhong";
            lbl_LoaiPhong.Size = new Size(84, 20);
            lbl_LoaiPhong.TabIndex = 2;
            lbl_LoaiPhong.Text = "Loại phòng";
            // 
            // lbl_TinhTrang
            // 
            lbl_TinhTrang.AutoSize = true;
            lbl_TinhTrang.Location = new Point(577, 9);
            lbl_TinhTrang.Name = "lbl_TinhTrang";
            lbl_TinhTrang.Size = new Size(76, 20);
            lbl_TinhTrang.TabIndex = 3;
            lbl_TinhTrang.Text = "Tình trạng";
            // 
            // txt_SoPhong
            // 
            txt_SoPhong.Location = new Point(12, 34);
            txt_SoPhong.Name = "txt_SoPhong";
            txt_SoPhong.Size = new Size(160, 27);
            txt_SoPhong.TabIndex = 4;
            // 
            // numUD_TangSo
            // 
            numUD_TangSo.Location = new Point(195, 34);
            numUD_TangSo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numUD_TangSo.Name = "numUD_TangSo";
            numUD_TangSo.Size = new Size(144, 27);
            numUD_TangSo.TabIndex = 5;
            // 
            // cob_TinhTrang
            // 
            cob_TinhTrang.FormattingEnabled = true;
            cob_TinhTrang.Items.AddRange(new object[] { "Trống", "Đang ở", "Đang dọn" });
            cob_TinhTrang.Location = new Point(577, 33);
            cob_TinhTrang.Name = "cob_TinhTrang";
            cob_TinhTrang.Size = new Size(189, 28);
            cob_TinhTrang.TabIndex = 6;
            // 
            // cob_LoaiPhong
            // 
            cob_LoaiPhong.FormattingEnabled = true;
            cob_LoaiPhong.Items.AddRange(new object[] { "Phòng Đơn", "Phòng Đôi", "Phòng VIP" });
            cob_LoaiPhong.Location = new Point(361, 33);
            cob_LoaiPhong.Name = "cob_LoaiPhong";
            cob_LoaiPhong.Size = new Size(189, 28);
            cob_LoaiPhong.TabIndex = 7;
            // 
            // picb_AnhPhong
            // 
            picb_AnhPhong.Image = (Image)resources.GetObject("picb_AnhPhong.Image");
            picb_AnhPhong.Location = new Point(788, 12);
            picb_AnhPhong.Name = "picb_AnhPhong";
            picb_AnhPhong.Size = new Size(217, 214);
            picb_AnhPhong.TabIndex = 8;
            picb_AnhPhong.TabStop = false;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = SystemColors.AppWorkspace;
            btn_Them.Location = new Point(1352, 12);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(135, 49);
            btn_Them.TabIndex = 9;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = SystemColors.AppWorkspace;
            btn_Sua.Location = new Point(1352, 67);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(135, 49);
            btn_Sua.TabIndex = 10;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = SystemColors.AppWorkspace;
            btn_Xoa.Location = new Point(1352, 122);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(135, 49);
            btn_Xoa.TabIndex = 11;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.BackColor = SystemColors.AppWorkspace;
            btn_LamMoi.Location = new Point(1352, 177);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(135, 49);
            btn_LamMoi.TabIndex = 12;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = false;
            // 
            // btn_ChonAnh
            // 
            btn_ChonAnh.BackColor = SystemColors.AppWorkspace;
            btn_ChonAnh.Location = new Point(1011, 187);
            btn_ChonAnh.Name = "btn_ChonAnh";
            btn_ChonAnh.Size = new Size(111, 39);
            btn_ChonAnh.TabIndex = 13;
            btn_ChonAnh.Text = "Chọn ảnh...";
            btn_ChonAnh.UseVisualStyleBackColor = false;
            // 
            // cob_LocTheoLoaiPhong
            // 
            cob_LocTheoLoaiPhong.FormattingEnabled = true;
            cob_LocTheoLoaiPhong.Items.AddRange(new object[] { "Phòng Đơn", "Phòng Đôi", "Phòng VIP" });
            cob_LocTheoLoaiPhong.Location = new Point(12, 203);
            cob_LocTheoLoaiPhong.Name = "cob_LocTheoLoaiPhong";
            cob_LocTheoLoaiPhong.Size = new Size(274, 28);
            cob_LocTheoLoaiPhong.TabIndex = 14;
            cob_LocTheoLoaiPhong.Text = "Lọc theo loại phòng";
            // 
            // cob_LocTheoTinhTrang
            // 
            cob_LocTheoTinhTrang.FormattingEnabled = true;
            cob_LocTheoTinhTrang.Items.AddRange(new object[] { "Trống", "Đang ở", "Đang dọn" });
            cob_LocTheoTinhTrang.Location = new Point(296, 203);
            cob_LocTheoTinhTrang.Name = "cob_LocTheoTinhTrang";
            cob_LocTheoTinhTrang.Size = new Size(254, 28);
            cob_LocTheoTinhTrang.TabIndex = 15;
            cob_LocTheoTinhTrang.Text = "Lọc theo tình trạng";
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = SystemColors.AppWorkspace;
            btn_TimKiem.Location = new Point(577, 197);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(111, 39);
            btn_TimKiem.TabIndex = 16;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachPhong
            // 
            dgv_DanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachPhong.Columns.AddRange(new DataGridViewColumn[] { txt_MaPhong, pic_Anh, txt_SoPhg, txt_Tang, txt_LoaiPhg, txt_Gia_tren_dem, txt_TinhTrg });
            dgv_DanhSachPhong.Location = new Point(12, 248);
            dgv_DanhSachPhong.Name = "dgv_DanhSachPhong";
            dgv_DanhSachPhong.RowHeadersWidth = 51;
            dgv_DanhSachPhong.Size = new Size(1475, 447);
            dgv_DanhSachPhong.TabIndex = 17;
            // 
            // txt_MaPhong
            // 
            txt_MaPhong.HeaderText = "Mã phòng";
            txt_MaPhong.MinimumWidth = 6;
            txt_MaPhong.Name = "txt_MaPhong";
            txt_MaPhong.ReadOnly = true;
            txt_MaPhong.Width = 200;
            // 
            // pic_Anh
            // 
            pic_Anh.HeaderText = "Ảnh";
            pic_Anh.MinimumWidth = 6;
            pic_Anh.Name = "pic_Anh";
            pic_Anh.ReadOnly = true;
            pic_Anh.Width = 200;
            // 
            // txt_SoPhg
            // 
            txt_SoPhg.HeaderText = "Số phòng";
            txt_SoPhg.MinimumWidth = 6;
            txt_SoPhg.Name = "txt_SoPhg";
            txt_SoPhg.ReadOnly = true;
            txt_SoPhg.Resizable = DataGridViewTriState.True;
            txt_SoPhg.SortMode = DataGridViewColumnSortMode.NotSortable;
            txt_SoPhg.Width = 200;
            // 
            // txt_Tang
            // 
            txt_Tang.HeaderText = "Tầng";
            txt_Tang.MinimumWidth = 6;
            txt_Tang.Name = "txt_Tang";
            txt_Tang.ReadOnly = true;
            txt_Tang.Width = 200;
            // 
            // txt_LoaiPhg
            // 
            txt_LoaiPhg.HeaderText = "Loại Phòng";
            txt_LoaiPhg.MinimumWidth = 6;
            txt_LoaiPhg.Name = "txt_LoaiPhg";
            txt_LoaiPhg.ReadOnly = true;
            txt_LoaiPhg.Width = 200;
            // 
            // txt_Gia_tren_dem
            // 
            txt_Gia_tren_dem.HeaderText = "Giá/đêm";
            txt_Gia_tren_dem.MinimumWidth = 6;
            txt_Gia_tren_dem.Name = "txt_Gia_tren_dem";
            txt_Gia_tren_dem.ReadOnly = true;
            txt_Gia_tren_dem.Width = 200;
            // 
            // txt_TinhTrg
            // 
            txt_TinhTrg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_TinhTrg.HeaderText = "Tình trạng";
            txt_TinhTrg.MinimumWidth = 6;
            txt_TinhTrg.Name = "txt_TinhTrg";
            txt_TinhTrg.ReadOnly = true;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 707);
            Controls.Add(dgv_DanhSachPhong);
            Controls.Add(btn_TimKiem);
            Controls.Add(cob_LocTheoTinhTrang);
            Controls.Add(cob_LocTheoLoaiPhong);
            Controls.Add(btn_ChonAnh);
            Controls.Add(btn_LamMoi);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(picb_AnhPhong);
            Controls.Add(cob_LoaiPhong);
            Controls.Add(cob_TinhTrang);
            Controls.Add(numUD_TangSo);
            Controls.Add(txt_SoPhong);
            Controls.Add(lbl_TinhTrang);
            Controls.Add(lbl_LoaiPhong);
            Controls.Add(lbl_TangSo);
            Controls.Add(lbl_SoPhong);
            Name = "frm_MainScreen";
            Text = "Quản Lý Phòng - Sunrise HomeStay";
            ((System.ComponentModel.ISupportInitialize)numUD_TangSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_AnhPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_SoPhong;
        private Label lbl_TangSo;
        private Label lbl_LoaiPhong;
        private Label lbl_TinhTrang;
        private TextBox txt_SoPhong;
        private NumericUpDown numUD_TangSo;
        private ComboBox cob_TinhTrang;
        private ComboBox cob_LoaiPhong;
        private PictureBox picb_AnhPhong;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_LamMoi;
        private Button btn_ChonAnh;
        private ComboBox cob_LocTheoLoaiPhong;
        private ComboBox cob_LocTheoTinhTrang;
        private Button btn_TimKiem;
        private DataGridView dgv_DanhSachPhong;
        private DataGridViewTextBoxColumn txt_MaPhong;
        private DataGridViewImageColumn pic_Anh;
        private DataGridViewTextBoxColumn txt_SoPhg;
        private DataGridViewTextBoxColumn txt_Tang;
        private DataGridViewTextBoxColumn txt_LoaiPhg;
        private DataGridViewTextBoxColumn txt_Gia_tren_dem;
        private DataGridViewTextBoxColumn txt_TinhTrg;
    }
}
