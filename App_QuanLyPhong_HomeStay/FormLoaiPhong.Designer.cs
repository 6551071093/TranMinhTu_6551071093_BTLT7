namespace App_QuanLyPhong_HomeStay
{
    partial class frm_LoaiPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_MaLoai = new Label();
            lbl_TenLoai = new Label();
            lbl_Gia_tren_dem = new Label();
            lbl_MoTa = new Label();
            txt_MaLoai = new TextBox();
            txt_TenLoai = new TextBox();
            txt_Gia_tren_dem = new TextBox();
            txt_MoTa = new TextBox();
            txt_TimKiem = new TextBox();
            btn_TimKiem = new Button();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_LamMoi = new Button();
            dgv_DanhSachLoaiPhong = new DataGridView();
            txt_MaLoaiPhong = new DataGridViewTextBoxColumn();
            txt_TenLoaiphong = new DataGridViewTextBoxColumn();
            txt_Gia = new DataGridViewTextBoxColumn();
            txt_MoTaPhong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // lbl_MaLoai
            // 
            lbl_MaLoai.AutoSize = true;
            lbl_MaLoai.Location = new Point(12, 9);
            lbl_MaLoai.Name = "lbl_MaLoai";
            lbl_MaLoai.Size = new Size(77, 20);
            lbl_MaLoai.TabIndex = 0;
            lbl_MaLoai.Text = "Mã phòng";
            // 
            // lbl_TenLoai
            // 
            lbl_TenLoai.AutoSize = true;
            lbl_TenLoai.Location = new Point(12, 57);
            lbl_TenLoai.Name = "lbl_TenLoai";
            lbl_TenLoai.Size = new Size(64, 20);
            lbl_TenLoai.TabIndex = 1;
            lbl_TenLoai.Text = "Tên Loại";
            // 
            // lbl_Gia_tren_dem
            // 
            lbl_Gia_tren_dem.AutoSize = true;
            lbl_Gia_tren_dem.Location = new Point(12, 108);
            lbl_Gia_tren_dem.Name = "lbl_Gia_tren_dem";
            lbl_Gia_tren_dem.Size = new Size(67, 20);
            lbl_Gia_tren_dem.TabIndex = 2;
            lbl_Gia_tren_dem.Text = "Giá/đêm";
            // 
            // lbl_MoTa
            // 
            lbl_MoTa.AutoSize = true;
            lbl_MoTa.Location = new Point(12, 163);
            lbl_MoTa.Name = "lbl_MoTa";
            lbl_MoTa.Size = new Size(48, 20);
            lbl_MoTa.TabIndex = 3;
            lbl_MoTa.Text = "Mô tả";
            // 
            // txt_MaLoai
            // 
            txt_MaLoai.Location = new Point(108, 6);
            txt_MaLoai.Name = "txt_MaLoai";
            txt_MaLoai.ReadOnly = true;
            txt_MaLoai.Size = new Size(205, 27);
            txt_MaLoai.TabIndex = 4;
            // 
            // txt_TenLoai
            // 
            txt_TenLoai.Location = new Point(108, 54);
            txt_TenLoai.Name = "txt_TenLoai";
            txt_TenLoai.Size = new Size(205, 27);
            txt_TenLoai.TabIndex = 5;
            // 
            // txt_Gia_tren_dem
            // 
            txt_Gia_tren_dem.Location = new Point(108, 105);
            txt_Gia_tren_dem.Name = "txt_Gia_tren_dem";
            txt_Gia_tren_dem.Size = new Size(205, 27);
            txt_Gia_tren_dem.TabIndex = 6;
            // 
            // txt_MoTa
            // 
            txt_MoTa.Location = new Point(108, 160);
            txt_MoTa.Multiline = true;
            txt_MoTa.Name = "txt_MoTa";
            txt_MoTa.Size = new Size(205, 105);
            txt_MoTa.TabIndex = 7;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(12, 288);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(279, 27);
            txt_TimKiem.TabIndex = 8;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = SystemColors.AppWorkspace;
            btn_TimKiem.Location = new Point(329, 283);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(108, 36);
            btn_TimKiem.TabIndex = 9;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = SystemColors.AppWorkspace;
            btn_Them.Location = new Point(338, 12);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(108, 40);
            btn_Them.TabIndex = 10;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = SystemColors.AppWorkspace;
            btn_Sua.Location = new Point(452, 12);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(108, 40);
            btn_Sua.TabIndex = 11;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = SystemColors.AppWorkspace;
            btn_Xoa.Location = new Point(566, 12);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(108, 40);
            btn_Xoa.TabIndex = 12;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.BackColor = SystemColors.AppWorkspace;
            btn_LamMoi.Location = new Point(680, 12);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(108, 40);
            btn_LamMoi.TabIndex = 13;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachLoaiPhong
            // 
            dgv_DanhSachLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { txt_MaLoaiPhong, txt_TenLoaiphong, txt_Gia, txt_MoTaPhong });
            dgv_DanhSachLoaiPhong.Location = new Point(12, 325);
            dgv_DanhSachLoaiPhong.Name = "dgv_DanhSachLoaiPhong";
            dgv_DanhSachLoaiPhong.RowHeadersWidth = 51;
            dgv_DanhSachLoaiPhong.Size = new Size(776, 209);
            dgv_DanhSachLoaiPhong.TabIndex = 14;
            // 
            // txt_MaLoaiPhong
            // 
            txt_MaLoaiPhong.HeaderText = "Mã loại";
            txt_MaLoaiPhong.MinimumWidth = 6;
            txt_MaLoaiPhong.Name = "txt_MaLoaiPhong";
            txt_MaLoaiPhong.ReadOnly = true;
            txt_MaLoaiPhong.Width = 150;
            // 
            // txt_TenLoaiphong
            // 
            txt_TenLoaiphong.HeaderText = "Tên loại";
            txt_TenLoaiphong.MinimumWidth = 6;
            txt_TenLoaiphong.Name = "txt_TenLoaiphong";
            txt_TenLoaiphong.ReadOnly = true;
            txt_TenLoaiphong.Width = 200;
            // 
            // txt_Gia
            // 
            txt_Gia.HeaderText = "Giá/Đêm";
            txt_Gia.MinimumWidth = 6;
            txt_Gia.Name = "txt_Gia";
            txt_Gia.ReadOnly = true;
            txt_Gia.Width = 200;
            // 
            // txt_MoTaPhong
            // 
            txt_MoTaPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_MoTaPhong.HeaderText = "Mô tả";
            txt_MoTaPhong.MinimumWidth = 6;
            txt_MoTaPhong.Name = "txt_MoTaPhong";
            txt_MoTaPhong.ReadOnly = true;
            // 
            // frm_LoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(dgv_DanhSachLoaiPhong);
            Controls.Add(btn_LamMoi);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(btn_TimKiem);
            Controls.Add(txt_TimKiem);
            Controls.Add(txt_MoTa);
            Controls.Add(txt_Gia_tren_dem);
            Controls.Add(txt_TenLoai);
            Controls.Add(txt_MaLoai);
            Controls.Add(lbl_MoTa);
            Controls.Add(lbl_Gia_tren_dem);
            Controls.Add(lbl_TenLoai);
            Controls.Add(lbl_MaLoai);
            Name = "frm_LoaiPhong";
            Text = "FormLoaiPhong";
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MaLoai;
        private Label lbl_TenLoai;
        private Label lbl_Gia_tren_dem;
        private Label lbl_MoTa;
        private TextBox txt_MaLoai;
        private TextBox txt_TenLoai;
        private TextBox txt_Gia_tren_dem;
        private TextBox txt_MoTa;
        private TextBox txt_TimKiem;
        private Button btn_TimKiem;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_LamMoi;
        private DataGridView dgv_DanhSachLoaiPhong;
        private DataGridViewTextBoxColumn txt_MaLoaiPhong;
        private DataGridViewTextBoxColumn txt_TenLoaiphong;
        private DataGridViewTextBoxColumn txt_Gia;
        private DataGridViewTextBoxColumn txt_MoTaPhong;
    }
}