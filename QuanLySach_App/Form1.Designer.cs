namespace QuanLySach_App
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
            lbl_MaTheLoai = new Label();
            txt_MaTheLoai = new TextBox();
            lbl_TenTheLoai = new Label();
            txt_TenTheLoai = new TextBox();
            lbl_MoTa = new Label();
            txt_MoTa = new TextBox();
            txt_TimKiem = new TextBox();
            btn_TimKiem = new Button();
            DataGV_DanMucSach = new DataGridView();
            txt_MaTL = new DataGridViewTextBoxColumn();
            txt_TenTL = new DataGridViewTextBoxColumn();
            txt_MT = new DataGridViewTextBoxColumn();
            txt_SoLuong = new DataGridViewTextBoxColumn();
            lbl_NgTao = new DataGridViewTextBoxColumn();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_LamMoi = new Button();
            stTrp_MainScreen = new StatusStrip();
            lbl_NgayTao = new ToolStripStatusLabel();
            lbl_SoLuong = new Label();
            txt_SoLg = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGV_DanMucSach).BeginInit();
            stTrp_MainScreen.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_MaTheLoai
            // 
            lbl_MaTheLoai.AutoSize = true;
            lbl_MaTheLoai.Location = new Point(12, 19);
            lbl_MaTheLoai.Name = "lbl_MaTheLoai";
            lbl_MaTheLoai.Size = new Size(84, 20);
            lbl_MaTheLoai.TabIndex = 0;
            lbl_MaTheLoai.Text = "Mã thể loại";
            // 
            // txt_MaTheLoai
            // 
            txt_MaTheLoai.Location = new Point(100, 12);
            txt_MaTheLoai.Name = "txt_MaTheLoai";
            txt_MaTheLoai.ReadOnly = true;
            txt_MaTheLoai.Size = new Size(415, 27);
            txt_MaTheLoai.TabIndex = 1;
            // 
            // lbl_TenTheLoai
            // 
            lbl_TenTheLoai.AutoSize = true;
            lbl_TenTheLoai.Location = new Point(12, 67);
            lbl_TenTheLoai.Name = "lbl_TenTheLoai";
            lbl_TenTheLoai.Size = new Size(86, 20);
            lbl_TenTheLoai.TabIndex = 2;
            lbl_TenTheLoai.Text = "Tên thể loại";
            // 
            // txt_TenTheLoai
            // 
            txt_TenTheLoai.Location = new Point(100, 60);
            txt_TenTheLoai.Name = "txt_TenTheLoai";
            txt_TenTheLoai.Size = new Size(415, 27);
            txt_TenTheLoai.TabIndex = 3;
            // 
            // lbl_MoTa
            // 
            lbl_MoTa.AutoSize = true;
            lbl_MoTa.Location = new Point(12, 135);
            lbl_MoTa.Name = "lbl_MoTa";
            lbl_MoTa.Size = new Size(48, 20);
            lbl_MoTa.TabIndex = 4;
            lbl_MoTa.Text = "Mô tả";
            // 
            // txt_MoTa
            // 
            txt_MoTa.Location = new Point(100, 111);
            txt_MoTa.Multiline = true;
            txt_MoTa.Name = "txt_MoTa";
            txt_MoTa.ScrollBars = ScrollBars.Vertical;
            txt_MoTa.Size = new Size(415, 140);
            txt_MoTa.TabIndex = 5;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(12, 320);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(503, 27);
            txt_TimKiem.TabIndex = 6;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(550, 310);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(95, 37);
            btn_TimKiem.TabIndex = 7;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // DataGV_DanMucSach
            // 
            DataGV_DanMucSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGV_DanMucSach.Columns.AddRange(new DataGridViewColumn[] { txt_MaTL, txt_TenTL, txt_MT, txt_SoLuong, lbl_NgTao });
            DataGV_DanMucSach.Location = new Point(12, 365);
            DataGV_DanMucSach.Name = "DataGV_DanMucSach";
            DataGV_DanMucSach.RowHeadersWidth = 51;
            DataGV_DanMucSach.Size = new Size(1139, 344);
            DataGV_DanMucSach.TabIndex = 12;
            // 
            // txt_MaTL
            // 
            txt_MaTL.HeaderText = "Mã TL";
            txt_MaTL.MinimumWidth = 6;
            txt_MaTL.Name = "txt_MaTL";
            txt_MaTL.ReadOnly = true;
            txt_MaTL.Width = 125;
            // 
            // txt_TenTL
            // 
            txt_TenTL.HeaderText = "Tên thể loại";
            txt_TenTL.MinimumWidth = 6;
            txt_TenTL.Name = "txt_TenTL";
            txt_TenTL.ReadOnly = true;
            txt_TenTL.Width = 200;
            // 
            // txt_MT
            // 
            txt_MT.HeaderText = "Mô tả";
            txt_MT.MinimumWidth = 6;
            txt_MT.Name = "txt_MT";
            txt_MT.ReadOnly = true;
            txt_MT.Width = 350;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.HeaderText = "Số lượng sách";
            txt_SoLuong.MinimumWidth = 6;
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.ReadOnly = true;
            txt_SoLuong.Width = 170;
            // 
            // lbl_NgTao
            // 
            lbl_NgTao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lbl_NgTao.HeaderText = "Ngày tạo";
            lbl_NgTao.MinimumWidth = 6;
            lbl_NgTao.Name = "lbl_NgTao";
            lbl_NgTao.ReadOnly = true;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(753, 12);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(95, 37);
            btn_Them.TabIndex = 13;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(854, 12);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(95, 37);
            btn_Sua.TabIndex = 14;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(955, 12);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(95, 37);
            btn_Xoa.TabIndex = 15;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Location = new Point(1056, 12);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(95, 37);
            btn_LamMoi.TabIndex = 16;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // stTrp_MainScreen
            // 
            stTrp_MainScreen.Dock = DockStyle.None;
            stTrp_MainScreen.ImageScalingSize = new Size(20, 20);
            stTrp_MainScreen.Items.AddRange(new ToolStripItem[] { lbl_NgayTao });
            stTrp_MainScreen.Location = new Point(0, 726);
            stTrp_MainScreen.Name = "stTrp_MainScreen";
            stTrp_MainScreen.Size = new Size(17, 22);
            stTrp_MainScreen.TabIndex = 17;
            stTrp_MainScreen.Text = "statusStrip1";
            // 
            // lbl_NgayTao
            // 
            lbl_NgayTao.Name = "lbl_NgayTao";
            lbl_NgayTao.Size = new Size(0, 16);
            // 
            // lbl_SoLuong
            // 
            lbl_SoLuong.AutoSize = true;
            lbl_SoLuong.Location = new Point(12, 278);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(72, 20);
            lbl_SoLuong.TabIndex = 18;
            lbl_SoLuong.Text = "Số Lượng";
            // 
            // txt_SoLg
            // 
            txt_SoLg.Location = new Point(100, 275);
            txt_SoLg.Name = "txt_SoLg";
            txt_SoLg.Size = new Size(415, 27);
            txt_SoLg.TabIndex = 19;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 748);
            Controls.Add(txt_SoLg);
            Controls.Add(lbl_SoLuong);
            Controls.Add(stTrp_MainScreen);
            Controls.Add(btn_LamMoi);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(DataGV_DanMucSach);
            Controls.Add(btn_TimKiem);
            Controls.Add(txt_TimKiem);
            Controls.Add(txt_MoTa);
            Controls.Add(lbl_MoTa);
            Controls.Add(txt_TenTheLoai);
            Controls.Add(lbl_TenTheLoai);
            Controls.Add(txt_MaTheLoai);
            Controls.Add(lbl_MaTheLoai);
            Name = "frm_MainScreen";
            ((System.ComponentModel.ISupportInitialize)DataGV_DanMucSach).EndInit();
            stTrp_MainScreen.ResumeLayout(false);
            stTrp_MainScreen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MaTheLoai;
        private TextBox txt_MaTheLoai;
        private Label lbl_TenTheLoai;
        private TextBox txt_TenTheLoai;
        private Label lbl_MoTa;
        private TextBox txt_MoTa;
        private TextBox txt_TimKiem;
        private Button btn_TimKiem;
        private DataGridView DataGV_DanMucSach;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_LamMoi;
        private StatusStrip stTrp_MainScreen;
        private ToolStripStatusLabel lbl_NgayTao;
        private Label lbl_SoLuong;
        private TextBox txt_SoLg;
        private DataGridViewTextBoxColumn txt_MaTL;
        private DataGridViewTextBoxColumn txt_TenTL;
        private DataGridViewTextBoxColumn txt_MT;
        private DataGridViewTextBoxColumn txt_SoLuong;
        private DataGridViewTextBoxColumn lbl_NgTao;
    }
}
