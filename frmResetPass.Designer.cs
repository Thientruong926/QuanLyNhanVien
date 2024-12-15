namespace QuanLyNhanVien
{
    partial class frmResetPass
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
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.lbConfirmNewPass = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Location = new System.Drawing.Point(67, 101);
            this.txtConfirmNewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmNewPass.Multiline = true;
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '*';
            this.txtConfirmNewPass.Size = new System.Drawing.Size(208, 24);
            this.txtConfirmNewPass.TabIndex = 26;
            this.txtConfirmNewPass.TextChanged += new System.EventHandler(this.txtConfirmNewPass_TextChanged);
            // 
            // lbConfirmNewPass
            // 
            this.lbConfirmNewPass.AutoSize = true;
            this.lbConfirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmNewPass.ForeColor = System.Drawing.Color.Black;
            this.lbConfirmNewPass.Location = new System.Drawing.Point(64, 82);
            this.lbConfirmNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmNewPass.Name = "lbConfirmNewPass";
            this.lbConfirmNewPass.Size = new System.Drawing.Size(185, 18);
            this.lbConfirmNewPass.TabIndex = 25;
            this.lbConfirmNewPass.Text = "NHẬP LẠI MẬT KHẨU MỚI";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(67, 51);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(208, 24);
            this.txtNewPassword.TabIndex = 24;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.ForeColor = System.Drawing.Color.Black;
            this.lbNewPassword.Location = new System.Drawing.Point(64, 32);
            this.lbNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(116, 18);
            this.lbNewPassword.TabIndex = 23;
            this.lbNewPassword.Text = "MẬT KHẨU MỚI";
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPass.Location = new System.Drawing.Point(155, 138);
            this.ShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(137, 21);
            this.ShowPass.TabIndex = 27;
            this.ShowPass.Text = "Hiển thị mật khẩu";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.BackColor = System.Drawing.Color.MediumPurple;
            this.ButtonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonConfirm.Location = new System.Drawing.Point(67, 167);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(207, 40);
            this.ButtonConfirm.TabIndex = 28;
            this.ButtonConfirm.Text = "Xác nhận";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonCofirm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(67, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.txtConfirmNewPass);
            this.Controls.Add(this.lbConfirmNewPass);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lbNewPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.Label lbConfirmNewPass;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.CheckBox ShowPass;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Button button1;
    }
}