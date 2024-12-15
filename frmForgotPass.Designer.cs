namespace QuanLyNhanVien
{
    partial class frmForgotPass
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
            this.button1 = new System.Windows.Forms.Button();
            this.btVerify = new System.Windows.Forms.Button();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.lbOTP = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btSendCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(71, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btVerify
            // 
            this.btVerify.BackColor = System.Drawing.Color.MediumPurple;
            this.btVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerify.ForeColor = System.Drawing.SystemColors.Control;
            this.btVerify.Location = new System.Drawing.Point(71, 208);
            this.btVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVerify.Name = "btVerify";
            this.btVerify.Size = new System.Drawing.Size(276, 49);
            this.btVerify.TabIndex = 15;
            this.btVerify.Text = "Xác thực";
            this.btVerify.UseVisualStyleBackColor = false;
            this.btVerify.Click += new System.EventHandler(this.btVerify_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(72, 175);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOTP.Multiline = true;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(276, 29);
            this.txtOTP.TabIndex = 13;
            this.txtOTP.TextChanged += new System.EventHandler(this.txtOTP_TextChanged);
            // 
            // lbOTP
            // 
            this.lbOTP.AutoSize = true;
            this.lbOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOTP.ForeColor = System.Drawing.Color.Black;
            this.lbOTP.Location = new System.Drawing.Point(68, 150);
            this.lbOTP.Name = "lbOTP";
            this.lbOTP.Size = new System.Drawing.Size(112, 24);
            this.lbOTP.TabIndex = 12;
            this.lbOTP.Text = "Mã xác thực";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 53);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 30);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(67, 28);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 24);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "Email";
            // 
            // btSendCode
            // 
            this.btSendCode.BackColor = System.Drawing.Color.MediumPurple;
            this.btSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSendCode.ForeColor = System.Drawing.SystemColors.Control;
            this.btSendCode.Location = new System.Drawing.Point(71, 86);
            this.btSendCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSendCode.Name = "btSendCode";
            this.btSendCode.Size = new System.Drawing.Size(276, 49);
            this.btSendCode.TabIndex = 17;
            this.btSendCode.Text = "Gửi mã";
            this.btSendCode.UseVisualStyleBackColor = false;
            this.btSendCode.Click += new System.EventHandler(this.btSendCode_Click);
            // 
            // frmForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 359);
            this.Controls.Add(this.btSendCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btVerify);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.lbOTP);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btVerify;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label lbOTP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btSendCode;
    }
}