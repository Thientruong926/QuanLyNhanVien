﻿namespace QuanLyNhanVien
{
    partial class frmDA
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
            this.dgvDA = new System.Windows.Forms.DataGridView();
            this.MaDeAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDeAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNVfromDA = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaĐềÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐềÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmĐềÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhânViênVàoĐềAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhânViênKhỏiĐềÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDACanTim = new System.Windows.Forms.TextBox();
            this.txtMaNVCanTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVfromDA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDA
            // 
            this.dgvDA.AllowUserToAddRows = false;
            this.dgvDA.AllowUserToDeleteRows = false;
            this.dgvDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDeAn,
            this.TenDeAn});
            this.dgvDA.Location = new System.Drawing.Point(34, 140);
            this.dgvDA.MultiSelect = false;
            this.dgvDA.Name = "dgvDA";
            this.dgvDA.ReadOnly = true;
            this.dgvDA.RowHeadersWidth = 51;
            this.dgvDA.Size = new System.Drawing.Size(265, 315);
            this.dgvDA.TabIndex = 2;
            this.dgvDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeAn_CellClick);
            // 
            // MaDeAn
            // 
            this.MaDeAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDeAn.DataPropertyName = "MaDeAn";
            this.MaDeAn.HeaderText = "Ma de an";
            this.MaDeAn.MinimumWidth = 6;
            this.MaDeAn.Name = "MaDeAn";
            this.MaDeAn.ReadOnly = true;
            // 
            // TenDeAn
            // 
            this.TenDeAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenDeAn.DataPropertyName = "TenDeAn";
            this.TenDeAn.HeaderText = "Ten de an";
            this.TenDeAn.MinimumWidth = 6;
            this.TenDeAn.Name = "TenDeAn";
            this.TenDeAn.ReadOnly = true;
            this.TenDeAn.Width = 81;
            // 
            // dgvNVfromDA
            // 
            this.dgvNVfromDA.AllowUserToAddRows = false;
            this.dgvNVfromDA.AllowUserToDeleteRows = false;
            this.dgvNVfromDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVfromDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.MaPhong});
            this.dgvNVfromDA.Location = new System.Drawing.Point(354, 140);
            this.dgvNVfromDA.MultiSelect = false;
            this.dgvNVfromDA.Name = "dgvNVfromDA";
            this.dgvNVfromDA.ReadOnly = true;
            this.dgvNVfromDA.RowHeadersWidth = 51;
            this.dgvNVfromDA.Size = new System.Drawing.Size(414, 315);
            this.dgvNVfromDA.TabIndex = 3;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Ma NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "HoTenNV";
            this.TenNV.HeaderText = "Ten NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Ma Phong Ban";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(304, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÍ ĐỀ ÁN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.fileToolStripMenuItem.Text = "Hệ thống";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quayLạiToolStripMenuItem.Text = "Màn hình chính";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.xóaĐềÁnToolStripMenuItem,
            this.sửaĐềÁnToolStripMenuItem,
            this.tìmKiếmĐềÁnToolStripMenuItem,
            this.thêmNhânViênVàoĐềAnToolStripMenuItem,
            this.xóaNhânViênKhỏiĐềÁnToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.editToolStripMenuItem.Text = "Quản lý";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.selectAllToolStripMenuItem.Text = "Thêm đề án";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // xóaĐềÁnToolStripMenuItem
            // 
            this.xóaĐềÁnToolStripMenuItem.Name = "xóaĐềÁnToolStripMenuItem";
            this.xóaĐềÁnToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.xóaĐềÁnToolStripMenuItem.Text = "Xóa đề án";
            this.xóaĐềÁnToolStripMenuItem.Click += new System.EventHandler(this.xóaĐềÁnToolStripMenuItem_Click);
            // 
            // sửaĐềÁnToolStripMenuItem
            // 
            this.sửaĐềÁnToolStripMenuItem.Name = "sửaĐềÁnToolStripMenuItem";
            this.sửaĐềÁnToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.sửaĐềÁnToolStripMenuItem.Text = "Sửa đề án";
            this.sửaĐềÁnToolStripMenuItem.Click += new System.EventHandler(this.sửaĐềÁnToolStripMenuItem_Click);
            // 
            // tìmKiếmĐềÁnToolStripMenuItem
            // 
            this.tìmKiếmĐềÁnToolStripMenuItem.Name = "tìmKiếmĐềÁnToolStripMenuItem";
            this.tìmKiếmĐềÁnToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tìmKiếmĐềÁnToolStripMenuItem.Text = "Tìm kiếm đề án";
            this.tìmKiếmĐềÁnToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmĐềÁnToolStripMenuItem_Click);
            // 
            // thêmNhânViênVàoĐềAnToolStripMenuItem
            // 
            this.thêmNhânViênVàoĐềAnToolStripMenuItem.Name = "thêmNhânViênVàoĐềAnToolStripMenuItem";
            this.thêmNhânViênVàoĐềAnToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.thêmNhânViênVàoĐềAnToolStripMenuItem.Text = "Thêm nhân viên vào đề an";
            this.thêmNhânViênVàoĐềAnToolStripMenuItem.Click += new System.EventHandler(this.thêmNhânViênVàoĐềAnToolStripMenuItem_Click);
            // 
            // xóaNhânViênKhỏiĐềÁnToolStripMenuItem
            // 
            this.xóaNhânViênKhỏiĐềÁnToolStripMenuItem.Name = "xóaNhânViênKhỏiĐềÁnToolStripMenuItem";
            this.xóaNhânViênKhỏiĐềÁnToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.xóaNhânViênKhỏiĐềÁnToolStripMenuItem.Text = "Xóa nhân viên khỏi đề án";
            this.xóaNhânViênKhỏiĐềÁnToolStripMenuItem.Click += new System.EventHandler(this.xóaNhânViênKhỏiĐềÁnToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.toolsToolStripMenuItem.Text = "Thống kê";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.helpToolStripMenuItem.Text = "In danh sách";
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh sách đề án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách nhân viên thực hiện";
            // 
            // txtMaDACanTim
            // 
            this.txtMaDACanTim.Location = new System.Drawing.Point(212, 118);
            this.txtMaDACanTim.Name = "txtMaDACanTim";
            this.txtMaDACanTim.Size = new System.Drawing.Size(87, 20);
            this.txtMaDACanTim.TabIndex = 9;
            // 
            // txtMaNVCanTim
            // 
            this.txtMaNVCanTim.Location = new System.Drawing.Point(681, 117);
            this.txtMaNVCanTim.Name = "txtMaNVCanTim";
            this.txtMaNVCanTim.Size = new System.Drawing.Size(87, 20);
            this.txtMaNVCanTim.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã đề án";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(603, 121);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(72, 13);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Mã nhân viên";
            // 
            // frmDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaNVCanTim);
            this.Controls.Add(this.txtMaDACanTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNVfromDA);
            this.Controls.Add(this.dgvDA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐỀ ÁN";
            this.Load += new System.EventHandler(this.frmDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVfromDA)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDA;
        private System.Windows.Forms.DataGridView dgvNVfromDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDeAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDeAn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaĐềÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaĐềÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmĐềÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênVàoĐềAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênKhỏiĐềÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDACanTim;
        private System.Windows.Forms.TextBox txtMaNVCanTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
    }
}