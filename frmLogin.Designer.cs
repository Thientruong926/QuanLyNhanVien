namespace QuanLyNhanVien
{
    partial class frmLogin
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LinkForgot = new System.Windows.Forms.LinkLabel();
            this.lbLinkRegister = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbLogin.Location = new System.Drawing.Point(11, 9);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(259, 46);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "ĐĂNG NHẬP";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÀI KHOẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(41, 87);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(208, 25);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(41, 147);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(208, 24);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(39, 127);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(84, 18);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "MẬT KHẨU";
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPass.Location = new System.Drawing.Point(129, 183);
            this.ShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(118, 21);
            this.ShowPass.TabIndex = 5;
            this.ShowPass.Text = "Hiện mật khẩu";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.MediumPurple;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonLogin.Location = new System.Drawing.Point(43, 213);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(207, 40);
            this.ButtonLogin.TabIndex = 6;
            this.ButtonLogin.Text = "Đăng nhập";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LinkForgot
            // 
            this.LinkForgot.AutoSize = true;
            this.LinkForgot.DisabledLinkColor = System.Drawing.Color.Violet;
            this.LinkForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkForgot.LinkColor = System.Drawing.Color.Black;
            this.LinkForgot.Location = new System.Drawing.Point(97, 340);
            this.LinkForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkForgot.Name = "LinkForgot";
            this.LinkForgot.Size = new System.Drawing.Size(113, 17);
            this.LinkForgot.TabIndex = 7;
            this.LinkForgot.TabStop = true;
            this.LinkForgot.Text = "Quên mật khẩu?";
            this.LinkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkForgot_LinkClicked);
            // 
            // lbLinkRegister
            // 
            this.lbLinkRegister.AutoSize = true;
            this.lbLinkRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinkRegister.Location = new System.Drawing.Point(44, 375);
            this.lbLinkRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLinkRegister.Name = "lbLinkRegister";
            this.lbLinkRegister.Size = new System.Drawing.Size(221, 17);
            this.lbLinkRegister.TabIndex = 8;
            this.lbLinkRegister.Text = "Chưa có tài khoản? Đăng ký ngay";
            this.lbLinkRegister.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(42, 270);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Màn hình chính";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLinkRegister);
            this.Controls.Add(this.LinkForgot);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.CheckBox ShowPass;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.LinkLabel LinkForgot;
        private System.Windows.Forms.Label lbLinkRegister;
        private System.Windows.Forms.Button button1;
    }
}

