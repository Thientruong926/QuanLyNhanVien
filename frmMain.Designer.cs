namespace QuanLyNhanVien
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thànhViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLoginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLoginLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBoxQuanLy = new System.Windows.Forms.GroupBox();
            this.btnQLDeAn = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLPhongBan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.trợGiúpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.phòngBanToolStripMenuItem,
            this.đềToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.btnQLPhongBan_Click);
            // 
            // đềToolStripMenuItem
            // 
            this.đềToolStripMenuItem.Name = "đềToolStripMenuItem";
            this.đềToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.đềToolStripMenuItem.Text = "Đề án";
            this.đềToolStripMenuItem.Click += new System.EventHandler(this.btnQLDeAn_Click);
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớiThiệuToolStripMenuItem1});
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ giúp";
            // 
            // giớiThiệuToolStripMenuItem1
            // 
            this.giớiThiệuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chươngTrìnhToolStripMenuItem,
            this.thànhViênToolStripMenuItem1});
            this.giớiThiệuToolStripMenuItem1.Name = "giớiThiệuToolStripMenuItem1";
            this.giớiThiệuToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.giớiThiệuToolStripMenuItem1.Text = "Giới thiệu";
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            this.chươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.chươngTrìnhToolStripMenuItem_Click);
            // 
            // thànhViênToolStripMenuItem1
            // 
            this.thànhViênToolStripMenuItem1.Name = "thànhViênToolStripMenuItem1";
            this.thànhViênToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.thànhViênToolStripMenuItem1.Text = "Thành viên";
            this.thànhViênToolStripMenuItem1.Click += new System.EventHandler(this.thànhViênToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabelLoginStatus,
            this.toolStripStatusLabelLoginLevel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(145, 17);
            this.toolStripStatusLabelTime.Text = "toolStripStatusLabelTime";
            // 
            // toolStripStatusLabelLoginStatus
            // 
            this.toolStripStatusLabelLoginStatus.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelLoginStatus.Name = "toolStripStatusLabelLoginStatus";
            this.toolStripStatusLabelLoginStatus.Size = new System.Drawing.Size(182, 17);
            this.toolStripStatusLabelLoginStatus.Text = "toolStripStatusLabelLoginStatus";
            // 
            // toolStripStatusLabelLoginLevel
            // 
            this.toolStripStatusLabelLoginLevel.Name = "toolStripStatusLabelLoginLevel";
            this.toolStripStatusLabelLoginLevel.Size = new System.Drawing.Size(177, 17);
            this.toolStripStatusLabelLoginLevel.Text = "toolStripStatusLabelLoginLevel";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHeader.ForeColor = System.Drawing.Color.Red;
            this.labelHeader.Location = new System.Drawing.Point(61, 45);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(671, 39);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÂN VIÊN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(176, 308);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(205, 68);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "      Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(439, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 68);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "       Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelQ.Location = new System.Drawing.Point(264, 391);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(206, 24);
            this.labelQ.TabIndex = 8;
            this.labelQ.Text = "Bạn chưa có tài khoản?";
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSignUp.ForeColor = System.Drawing.Color.Red;
            this.labelSignUp.Location = new System.Drawing.Point(467, 391);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(78, 24);
            this.labelSignUp.TabIndex = 9;
            this.labelSignUp.Text = "Đăng ký";
            this.labelSignUp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelSignUp_MouseDoubleClick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(175, 308);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(206, 68);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "          Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBoxQuanLy
            // 
            this.groupBoxQuanLy.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxQuanLy.Controls.Add(this.btnQLDeAn);
            this.groupBoxQuanLy.Controls.Add(this.btnQLNhanVien);
            this.groupBoxQuanLy.Controls.Add(this.btnQLPhongBan);
            this.groupBoxQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxQuanLy.Location = new System.Drawing.Point(100, 100);
            this.groupBoxQuanLy.Name = "groupBoxQuanLy";
            this.groupBoxQuanLy.Size = new System.Drawing.Size(606, 190);
            this.groupBoxQuanLy.TabIndex = 11;
            this.groupBoxQuanLy.TabStop = false;
            // 
            // btnQLDeAn
            // 
            this.btnQLDeAn.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDeAn.Image")));
            this.btnQLDeAn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLDeAn.Location = new System.Drawing.Point(414, 0);
            this.btnQLDeAn.Name = "btnQLDeAn";
            this.btnQLDeAn.Size = new System.Drawing.Size(191, 190);
            this.btnQLDeAn.TabIndex = 2;
            this.btnQLDeAn.Text = "Quản lý đề án";
            this.btnQLDeAn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLDeAn.UseVisualStyleBackColor = true;
            this.btnQLDeAn.Click += new System.EventHandler(this.btnQLDeAn_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.White;
            this.btnQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.Image")));
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(206, 190);
            this.btnQLNhanVien.TabIndex = 0;
            this.btnQLNhanVien.Text = "Quản lý nhân viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnQLPhongBan
            // 
            this.btnQLPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnQLPhongBan.Image")));
            this.btnQLPhongBan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLPhongBan.Location = new System.Drawing.Point(203, 0);
            this.btnQLPhongBan.Name = "btnQLPhongBan";
            this.btnQLPhongBan.Size = new System.Drawing.Size(213, 190);
            this.btnQLPhongBan.TabIndex = 1;
            this.btnQLPhongBan.Text = "Quản lý phòng ban";
            this.btnQLPhongBan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLPhongBan.UseVisualStyleBackColor = true;
            this.btnQLPhongBan.Click += new System.EventHandler(this.btnQLPhongBan_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxQuanLy);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đềToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thànhViênToolStripMenuItem1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBoxQuanLy;
        private System.Windows.Forms.Button btnQLDeAn;
        private System.Windows.Forms.Button btnQLPhongBan;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLoginStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLoginLevel;
    }
}