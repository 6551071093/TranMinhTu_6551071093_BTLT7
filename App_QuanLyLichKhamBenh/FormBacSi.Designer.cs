namespace App_QuanLyLichKhamBenh
{
    partial class FormBacSi
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
            lbl_MaBacSi = new Label();
            lbl_HoTen = new Label();
            lbl_ChuyenKhoa = new Label();
            textBox1 = new TextBox();
            txt_HoTen = new TextBox();
            txt_ChuyenKhoa = new TextBox();
            txt_TimKiem = new TextBox();
            btn_TimKIem = new Button();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_LamMoi = new Button();
            dgv_DanhSachBacSi = new DataGridView();
            txt_MaBS = new DataGridViewTextBoxColumn();
            txt_TenBS = new DataGridViewTextBoxColumn();
            txt_SDT = new DataGridViewTextBoxColumn();
            txt_ChnKhoa = new DataGridViewTextBoxColumn();
            lbl_SoDienThoai = new Label();
            txt_SoDienThoai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachBacSi).BeginInit();
            SuspendLayout();
            // 
            // lbl_MaBacSi
            // 
            lbl_MaBacSi.AutoSize = true;
            lbl_MaBacSi.Location = new Point(12, 15);
            lbl_MaBacSi.Name = "lbl_MaBacSi";
            lbl_MaBacSi.Size = new Size(72, 20);
            lbl_MaBacSi.TabIndex = 0;
            lbl_MaBacSi.Text = "Mã bác sĩ";
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Location = new Point(12, 67);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(54, 20);
            lbl_HoTen.TabIndex = 1;
            lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_ChuyenKhoa
            // 
            lbl_ChuyenKhoa.AutoSize = true;
            lbl_ChuyenKhoa.Location = new Point(12, 162);
            lbl_ChuyenKhoa.Name = "lbl_ChuyenKhoa";
            lbl_ChuyenKhoa.Size = new Size(93, 20);
            lbl_ChuyenKhoa.TabIndex = 2;
            lbl_ChuyenKhoa.Text = "Chuyên khoa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 3;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(137, 64);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(293, 27);
            txt_HoTen.TabIndex = 4;
            // 
            // txt_ChuyenKhoa
            // 
            txt_ChuyenKhoa.Location = new Point(137, 159);
            txt_ChuyenKhoa.Multiline = true;
            txt_ChuyenKhoa.Name = "txt_ChuyenKhoa";
            txt_ChuyenKhoa.ScrollBars = ScrollBars.Vertical;
            txt_ChuyenKhoa.Size = new Size(293, 99);
            txt_ChuyenKhoa.TabIndex = 5;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(12, 275);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(418, 27);
            txt_TimKiem.TabIndex = 6;
            // 
            // btn_TimKIem
            // 
            btn_TimKIem.BackColor = SystemColors.AppWorkspace;
            btn_TimKIem.Location = new Point(458, 266);
            btn_TimKIem.Name = "btn_TimKIem";
            btn_TimKIem.Size = new Size(119, 44);
            btn_TimKIem.TabIndex = 7;
            btn_TimKIem.Text = "Tìm kiếm";
            btn_TimKIem.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = SystemColors.AppWorkspace;
            btn_Them.Location = new Point(605, 12);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(119, 44);
            btn_Them.TabIndex = 8;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = SystemColors.AppWorkspace;
            btn_Sua.Location = new Point(730, 12);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(119, 44);
            btn_Sua.TabIndex = 9;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = SystemColors.AppWorkspace;
            btn_Xoa.Location = new Point(855, 12);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(119, 44);
            btn_Xoa.TabIndex = 10;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.BackColor = SystemColors.AppWorkspace;
            btn_LamMoi.Location = new Point(980, 12);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(119, 44);
            btn_LamMoi.TabIndex = 11;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = false;
            // 
            // dgv_DanhSachBacSi
            // 
            dgv_DanhSachBacSi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachBacSi.Columns.AddRange(new DataGridViewColumn[] { txt_MaBS, txt_TenBS, txt_SDT, txt_ChnKhoa });
            dgv_DanhSachBacSi.Location = new Point(12, 326);
            dgv_DanhSachBacSi.Name = "dgv_DanhSachBacSi";
            dgv_DanhSachBacSi.RowHeadersWidth = 51;
            dgv_DanhSachBacSi.Size = new Size(1087, 238);
            dgv_DanhSachBacSi.TabIndex = 12;
            // 
            // txt_MaBS
            // 
            txt_MaBS.HeaderText = "Mã bác sĩ";
            txt_MaBS.MinimumWidth = 6;
            txt_MaBS.Name = "txt_MaBS";
            txt_MaBS.ReadOnly = true;
            txt_MaBS.Width = 200;
            // 
            // txt_TenBS
            // 
            txt_TenBS.HeaderText = "Họ tên";
            txt_TenBS.MinimumWidth = 6;
            txt_TenBS.Name = "txt_TenBS";
            txt_TenBS.ReadOnly = true;
            txt_TenBS.Width = 250;
            // 
            // txt_SDT
            // 
            txt_SDT.HeaderText = "Số điện thoại";
            txt_SDT.MinimumWidth = 6;
            txt_SDT.Name = "txt_SDT";
            txt_SDT.ReadOnly = true;
            txt_SDT.Width = 200;
            // 
            // txt_ChnKhoa
            // 
            txt_ChnKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_ChnKhoa.HeaderText = "Chuyên khoa";
            txt_ChnKhoa.MinimumWidth = 6;
            txt_ChnKhoa.Name = "txt_ChnKhoa";
            txt_ChnKhoa.ReadOnly = true;
            // 
            // lbl_SoDienThoai
            // 
            lbl_SoDienThoai.AutoSize = true;
            lbl_SoDienThoai.Location = new Point(16, 117);
            lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            lbl_SoDienThoai.Size = new Size(97, 20);
            lbl_SoDienThoai.TabIndex = 13;
            lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.Location = new Point(137, 114);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(293, 27);
            txt_SoDienThoai.TabIndex = 14;
            // 
            // FormBacSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 576);
            Controls.Add(txt_SoDienThoai);
            Controls.Add(lbl_SoDienThoai);
            Controls.Add(dgv_DanhSachBacSi);
            Controls.Add(btn_LamMoi);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(btn_TimKIem);
            Controls.Add(txt_TimKiem);
            Controls.Add(txt_ChuyenKhoa);
            Controls.Add(txt_HoTen);
            Controls.Add(textBox1);
            Controls.Add(lbl_ChuyenKhoa);
            Controls.Add(lbl_HoTen);
            Controls.Add(lbl_MaBacSi);
            Name = "FormBacSi";
            Text = "FormBacSi";
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachBacSi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MaBacSi;
        private Label lbl_HoTen;
        private Label lbl_ChuyenKhoa;
        private TextBox textBox1;
        private TextBox txt_HoTen;
        private TextBox txt_ChuyenKhoa;
        private TextBox txt_TimKiem;
        private Button btn_TimKIem;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_LamMoi;
        private DataGridView dgv_DanhSachBacSi;
        private Label lbl_SoDienThoai;
        private TextBox txt_SoDienThoai;
        private DataGridViewTextBoxColumn txt_MaBS;
        private DataGridViewTextBoxColumn txt_TenBS;
        private DataGridViewTextBoxColumn txt_SDT;
        private DataGridViewTextBoxColumn txt_ChnKhoa;
    }
}