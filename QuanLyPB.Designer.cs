namespace QuanLyNhanVien
{
    partial class frmPB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPB));
            this.dgvNVfromPB = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhânViênVàoPbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhânViênKhỏiPbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.dgvPB = new System.Windows.Forms.DataGridView();
            this.MaPhg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTrgPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTrgPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPBCanTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNVCanTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVfromPB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNVfromPB
            // 
            this.dgvNVfromPB.AllowUserToAddRows = false;
            this.dgvNVfromPB.AllowUserToDeleteRows = false;
            this.dgvNVfromPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVfromPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.MaNV,
            this.TenNV});
            this.dgvNVfromPB.Location = new System.Drawing.Point(719, 225);
            this.dgvNVfromPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNVfromPB.MultiSelect = false;
            this.dgvNVfromPB.Name = "dgvNVfromPB";
            this.dgvNVfromPB.ReadOnly = true;
            this.dgvNVfromPB.RowHeadersWidth = 51;
            this.dgvNVfromPB.Size = new System.Drawing.Size(423, 425);
            this.dgvNVfromPB.TabIndex = 2;
            this.dgvNVfromPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNVfromPB_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "HoTenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(440, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "QUẢN LÍ PHÒNG BAN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.quayLạiToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.fileToolStripMenuItem.Text = "Hệ thống";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Đăng nhập";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quayLạiToolStripMenuItem.Text = "Màn hình chính";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.xóaPhòngBanToolStripMenuItem,
            this.sửaPhòngBanToolStripMenuItem,
            this.tìmKiếmPhòngBanToolStripMenuItem,
            this.thêmNhânViênVàoPbToolStripMenuItem,
            this.xóaNhânViênKhỏiPbToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.editToolStripMenuItem.Text = "Quản lí";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.selectAllToolStripMenuItem.Text = "Thêm phòng ban";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // xóaPhòngBanToolStripMenuItem
            // 
            this.xóaPhòngBanToolStripMenuItem.Name = "xóaPhòngBanToolStripMenuItem";
            this.xóaPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.xóaPhòngBanToolStripMenuItem.Text = "Xóa phòng ban";
            this.xóaPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.xóaPhòngBanToolStripMenuItem_Click);
            // 
            // sửaPhòngBanToolStripMenuItem
            // 
            this.sửaPhòngBanToolStripMenuItem.Name = "sửaPhòngBanToolStripMenuItem";
            this.sửaPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.sửaPhòngBanToolStripMenuItem.Text = "Sửa phòng ban";
            this.sửaPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.sửaPhòngBanToolStripMenuItem_Click);
            // 
            // tìmKiếmPhòngBanToolStripMenuItem
            // 
            this.tìmKiếmPhòngBanToolStripMenuItem.Name = "tìmKiếmPhòngBanToolStripMenuItem";
            this.tìmKiếmPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.tìmKiếmPhòngBanToolStripMenuItem.Text = "Tìm kiếm phòng ban";
            this.tìmKiếmPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmPhòngBanToolStripMenuItem_Click);
            // 
            // thêmNhânViênVàoPbToolStripMenuItem
            // 
            this.thêmNhânViênVàoPbToolStripMenuItem.Name = "thêmNhânViênVàoPbToolStripMenuItem";
            this.thêmNhânViênVàoPbToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.thêmNhânViênVàoPbToolStripMenuItem.Text = "Thêm nhân viên vào pb";
            this.thêmNhânViênVàoPbToolStripMenuItem.Click += new System.EventHandler(this.thêmNhânViênVàoPbToolStripMenuItem_Click);
            // 
            // xóaNhânViênKhỏiPbToolStripMenuItem
            // 
            this.xóaNhânViênKhỏiPbToolStripMenuItem.Name = "xóaNhânViênKhỏiPbToolStripMenuItem";
            this.xóaNhânViênKhỏiPbToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.xóaNhânViênKhỏiPbToolStripMenuItem.Text = "Xóa nhân viên khỏi pb";
            this.xóaNhânViênKhỏiPbToolStripMenuItem.Click += new System.EventHandler(this.xóaNhânViênKhỏiPbToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.toolsToolStripMenuItem.Text = "Thống kê";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.helpToolStripMenuItem.Text = "In danh sách";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1179, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // dgvPB
            // 
            this.dgvPB.AllowUserToAddRows = false;
            this.dgvPB.AllowUserToDeleteRows = false;
            this.dgvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhg,
            this.TenPhg,
            this.TenTrgPhong,
            this.MaTrgPhong});
            this.dgvPB.Location = new System.Drawing.Point(48, 225);
            this.dgvPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPB.MultiSelect = false;
            this.dgvPB.Name = "dgvPB";
            this.dgvPB.ReadOnly = true;
            this.dgvPB.RowHeadersWidth = 51;
            this.dgvPB.Size = new System.Drawing.Size(605, 425);
            this.dgvPB.TabIndex = 8;
            this.dgvPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPB_CellClick);
            // 
            // MaPhg
            // 
            this.MaPhg.DataPropertyName = "MaPhg";
            this.MaPhg.HeaderText = "Mã phòng";
            this.MaPhg.MinimumWidth = 6;
            this.MaPhg.Name = "MaPhg";
            this.MaPhg.ReadOnly = true;
            this.MaPhg.Width = 125;
            // 
            // TenPhg
            // 
            this.TenPhg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhg.DataPropertyName = "TenPhg";
            this.TenPhg.HeaderText = "Tên phòng";
            this.TenPhg.MinimumWidth = 6;
            this.TenPhg.Name = "TenPhg";
            this.TenPhg.ReadOnly = true;
            // 
            // TenTrgPhong
            // 
            this.TenTrgPhong.DataPropertyName = "TenTrgPhong";
            this.TenTrgPhong.HeaderText = "Tên trưởng phòng";
            this.TenTrgPhong.MinimumWidth = 6;
            this.TenTrgPhong.Name = "TenTrgPhong";
            this.TenTrgPhong.ReadOnly = true;
            this.TenTrgPhong.Width = 125;
            // 
            // MaTrgPhong
            // 
            this.MaTrgPhong.DataPropertyName = "MaTrgPhong";
            this.MaTrgPhong.HeaderText = "Mã trưởng phòng";
            this.MaTrgPhong.MinimumWidth = 6;
            this.MaTrgPhong.Name = "MaTrgPhong";
            this.MaTrgPhong.ReadOnly = true;
            this.MaTrgPhong.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách phòng ban";
            // 
            // txtMaPBCanTim
            // 
            this.txtMaPBCanTim.Location = new System.Drawing.Point(520, 193);
            this.txtMaPBCanTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPBCanTim.Name = "txtMaPBCanTim";
            this.txtMaPBCanTim.Size = new System.Drawing.Size(132, 22);
            this.txtMaPBCanTim.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã phòng ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(961, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtMaNVCanTim
            // 
            this.txtMaNVCanTim.Location = new System.Drawing.Point(1067, 194);
            this.txtMaNVCanTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNVCanTim.Name = "txtMaNVCanTim";
            this.txtMaNVCanTim.Size = new System.Drawing.Size(73, 22);
            this.txtMaNVCanTim.TabIndex = 13;
            // 
            // frmPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 672);
            this.Controls.Add(this.txtMaNVCanTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaPBCanTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNVfromPB);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPB";
            this.Text = "Quan ly phong ban";
            this.Load += new System.EventHandler(this.frmPB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVfromPB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNVfromPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvPB;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrgPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrgPhong;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênVàoPbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênKhỏiPbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.TextBox txtMaPBCanTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNVCanTim;
    }
}