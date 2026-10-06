namespace App_QuanLyHoiVienPhongGym
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
            lbl_HoTen = new Label();
            txt_HoTen = new TextBox();
            lbl_SDT = new Label();
            lbl_Email = new Label();
            lbl_NgaySinh = new Label();
            lbl_HangThanhVien = new Label();
            ckb_DangHoatDong = new CheckBox();
            txt_SDT = new TextBox();
            txt_Email = new TextBox();
            dtp_NgaySinh = new DateTimePicker();
            cob_HangThannhVien = new ComboBox();
            gpb_GioiTinh = new GroupBox();
            rbtn_Nu = new RadioButton();
            rbtn_Nam = new RadioButton();
            txt_TimKiem = new TextBox();
            lbl_HangThanhVien_filter = new Label();
            cbo_HangThanhVien_Filter = new ComboBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_LamMoi = new Button();
            btn_TimKiem = new Button();
            dataGridView1 = new DataGridView();
            MaHV = new DataGridViewTextBoxColumn();
            txt_Ten = new DataGridViewTextBoxColumn();
            txt_GioiTinh = new DataGridViewTextBoxColumn();
            txt_NgSinh = new DataGridViewTextBoxColumn();
            txt_SoDienThoai = new DataGridViewTextBoxColumn();
            txt_e_mail = new DataGridViewTextBoxColumn();
            txt_HangTV = new DataGridViewTextBoxColumn();
            txt_TrangThai = new DataGridViewTextBoxColumn();
            gpb_GioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Location = new Point(12, 19);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(54, 20);
            lbl_HoTen.TabIndex = 0;
            lbl_HoTen.Text = "Họ tên";
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(178, 16);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(250, 27);
            txt_HoTen.TabIndex = 1;
            // 
            // lbl_SDT
            // 
            lbl_SDT.AutoSize = true;
            lbl_SDT.Location = new Point(12, 71);
            lbl_SDT.Name = "lbl_SDT";
            lbl_SDT.Size = new Size(97, 20);
            lbl_SDT.TabIndex = 2;
            lbl_SDT.Text = "Số điện thoại";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(12, 125);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(46, 20);
            lbl_Email.TabIndex = 3;
            lbl_Email.Text = "Email";
            // 
            // lbl_NgaySinh
            // 
            lbl_NgaySinh.AutoSize = true;
            lbl_NgaySinh.Location = new Point(12, 192);
            lbl_NgaySinh.Name = "lbl_NgaySinh";
            lbl_NgaySinh.Size = new Size(74, 20);
            lbl_NgaySinh.TabIndex = 4;
            lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // lbl_HangThanhVien
            // 
            lbl_HangThanhVien.AutoSize = true;
            lbl_HangThanhVien.Location = new Point(12, 255);
            lbl_HangThanhVien.Name = "lbl_HangThanhVien";
            lbl_HangThanhVien.Size = new Size(117, 20);
            lbl_HangThanhVien.TabIndex = 5;
            lbl_HangThanhVien.Text = "Hạng thành viên";
            // 
            // ckb_DangHoatDong
            // 
            ckb_DangHoatDong.AutoSize = true;
            ckb_DangHoatDong.Location = new Point(12, 316);
            ckb_DangHoatDong.Name = "ckb_DangHoatDong";
            ckb_DangHoatDong.Size = new Size(140, 24);
            ckb_DangHoatDong.TabIndex = 6;
            ckb_DangHoatDong.Text = "Đang hoạt động";
            ckb_DangHoatDong.UseVisualStyleBackColor = true;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(178, 68);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(250, 27);
            txt_SDT.TabIndex = 7;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(178, 122);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(250, 27);
            txt_Email.TabIndex = 8;
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.Location = new Point(178, 187);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(250, 27);
            dtp_NgaySinh.TabIndex = 9;
            // 
            // cob_HangThannhVien
            // 
            cob_HangThannhVien.FormattingEnabled = true;
            cob_HangThannhVien.Location = new Point(178, 252);
            cob_HangThannhVien.Name = "cob_HangThannhVien";
            cob_HangThannhVien.Size = new Size(250, 28);
            cob_HangThannhVien.TabIndex = 10;
            // 
            // gpb_GioiTinh
            // 
            gpb_GioiTinh.Controls.Add(rbtn_Nu);
            gpb_GioiTinh.Controls.Add(rbtn_Nam);
            gpb_GioiTinh.Location = new Point(540, 39);
            gpb_GioiTinh.Name = "gpb_GioiTinh";
            gpb_GioiTinh.Size = new Size(269, 88);
            gpb_GioiTinh.TabIndex = 11;
            gpb_GioiTinh.TabStop = false;
            gpb_GioiTinh.Text = "Giới tính";
            // 
            // rbtn_Nu
            // 
            rbtn_Nu.AutoSize = true;
            rbtn_Nu.Location = new Point(188, 40);
            rbtn_Nu.Name = "rbtn_Nu";
            rbtn_Nu.Size = new Size(50, 24);
            rbtn_Nu.TabIndex = 1;
            rbtn_Nu.TabStop = true;
            rbtn_Nu.Text = "Nữ";
            rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            rbtn_Nam.AutoSize = true;
            rbtn_Nam.Location = new Point(21, 40);
            rbtn_Nam.Name = "rbtn_Nam";
            rbtn_Nam.Size = new Size(62, 24);
            rbtn_Nam.TabIndex = 0;
            rbtn_Nam.TabStop = true;
            rbtn_Nam.Text = "Nam";
            rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(12, 368);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(366, 27);
            txt_TimKiem.TabIndex = 12;
            // 
            // lbl_HangThanhVien_filter
            // 
            lbl_HangThanhVien_filter.AutoSize = true;
            lbl_HangThanhVien_filter.Location = new Point(408, 371);
            lbl_HangThanhVien_filter.Name = "lbl_HangThanhVien_filter";
            lbl_HangThanhVien_filter.Size = new Size(117, 20);
            lbl_HangThanhVien_filter.TabIndex = 13;
            lbl_HangThanhVien_filter.Text = "Hạng thành viên";
            // 
            // cbo_HangThanhVien_Filter
            // 
            cbo_HangThanhVien_Filter.FormattingEnabled = true;
            cbo_HangThanhVien_Filter.Location = new Point(552, 367);
            cbo_HangThanhVien_Filter.Name = "cbo_HangThanhVien_Filter";
            cbo_HangThanhVien_Filter.Size = new Size(271, 28);
            cbo_HangThanhVien_Filter.TabIndex = 14;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(1041, 19);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(225, 48);
            btn_Them.TabIndex = 15;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(1041, 73);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(225, 48);
            btn_Sua.TabIndex = 16;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(1041, 127);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(225, 44);
            btn_Xoa.TabIndex = 17;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Location = new Point(1041, 177);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(225, 44);
            btn_LamMoi.TabIndex = 18;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(1041, 359);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(225, 44);
            btn_TimKiem.TabIndex = 19;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaHV, txt_Ten, txt_GioiTinh, txt_NgSinh, txt_SoDienThoai, txt_e_mail, txt_HangTV, txt_TrangThai });
            dataGridView1.Location = new Point(2, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1264, 283);
            dataGridView1.TabIndex = 20;
            // 
            // MaHV
            // 
            MaHV.HeaderText = "Mã HV";
            MaHV.MinimumWidth = 6;
            MaHV.Name = "MaHV";
            MaHV.ReadOnly = true;
            MaHV.Width = 125;
            // 
            // txt_Ten
            // 
            txt_Ten.HeaderText = "Họ tên";
            txt_Ten.MinimumWidth = 6;
            txt_Ten.Name = "txt_Ten";
            txt_Ten.ReadOnly = true;
            txt_Ten.Width = 200;
            // 
            // txt_GioiTinh
            // 
            txt_GioiTinh.HeaderText = "Giới tính";
            txt_GioiTinh.MinimumWidth = 6;
            txt_GioiTinh.Name = "txt_GioiTinh";
            txt_GioiTinh.ReadOnly = true;
            txt_GioiTinh.Width = 115;
            // 
            // txt_NgSinh
            // 
            txt_NgSinh.HeaderText = "Ngày sinh";
            txt_NgSinh.MinimumWidth = 6;
            txt_NgSinh.Name = "txt_NgSinh";
            txt_NgSinh.ReadOnly = true;
            txt_NgSinh.Width = 150;
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.HeaderText = "Số điện thoại";
            txt_SoDienThoai.MinimumWidth = 6;
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.ReadOnly = true;
            txt_SoDienThoai.Width = 165;
            // 
            // txt_e_mail
            // 
            txt_e_mail.HeaderText = "Email";
            txt_e_mail.MinimumWidth = 6;
            txt_e_mail.Name = "txt_e_mail";
            txt_e_mail.ReadOnly = true;
            txt_e_mail.Width = 150;
            // 
            // txt_HangTV
            // 
            txt_HangTV.HeaderText = "Hạng thành viên";
            txt_HangTV.MinimumWidth = 6;
            txt_HangTV.Name = "txt_HangTV";
            txt_HangTV.ReadOnly = true;
            txt_HangTV.Width = 150;
            // 
            // txt_TrangThai
            // 
            txt_TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_TrangThai.HeaderText = "Trạng thái";
            txt_TrangThai.MinimumWidth = 6;
            txt_TrangThai.Name = "txt_TrangThai";
            txt_TrangThai.ReadOnly = true;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 733);
            Controls.Add(dataGridView1);
            Controls.Add(btn_TimKiem);
            Controls.Add(btn_LamMoi);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(cbo_HangThanhVien_Filter);
            Controls.Add(lbl_HangThanhVien_filter);
            Controls.Add(txt_TimKiem);
            Controls.Add(gpb_GioiTinh);
            Controls.Add(cob_HangThannhVien);
            Controls.Add(dtp_NgaySinh);
            Controls.Add(txt_Email);
            Controls.Add(txt_SDT);
            Controls.Add(ckb_DangHoatDong);
            Controls.Add(lbl_HangThanhVien);
            Controls.Add(lbl_NgaySinh);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_SDT);
            Controls.Add(txt_HoTen);
            Controls.Add(lbl_HoTen);
            Name = "frm_MainScreen";
            Text = "Quản Lý Hội Viên Phòng Gym FitZone";
            gpb_GioiTinh.ResumeLayout(false);
            gpb_GioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_HoTen;
        private TextBox txt_HoTen;
        private Label lbl_SDT;
        private Label lbl_Email;
        private Label lbl_NgaySinh;
        private Label lbl_HangThanhVien;
        private CheckBox ckb_DangHoatDong;
        private TextBox txt_SDT;
        private TextBox txt_Email;
        private DateTimePicker dtp_NgaySinh;
        private ComboBox cob_HangThannhVien;
        private GroupBox gpb_GioiTinh;
        private RadioButton rbtn_Nu;
        private RadioButton rbtn_Nam;
        private TextBox txt_TimKiem;
        private Label lbl_HangThanhVien_filter;
        private ComboBox cbo_HangThanhVien_Filter;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_LamMoi;
        private Button btn_TimKiem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaHV;
        private DataGridViewTextBoxColumn txt_Ten;
        private DataGridViewTextBoxColumn txt_GioiTinh;
        private DataGridViewTextBoxColumn txt_NgSinh;
        private DataGridViewTextBoxColumn txt_SoDienThoai;
        private DataGridViewTextBoxColumn txt_e_mail;
        private DataGridViewTextBoxColumn txt_HangTV;
        private DataGridViewTextBoxColumn txt_TrangThai;
    }
}
