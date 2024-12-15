using System;

namespace QuanLyNhanVien
{
    partial class frmActive
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
            this.lbNotice = new System.Windows.Forms.Label();
            this.btAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(83, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btVerify
            // 
            this.btVerify.BackColor = System.Drawing.Color.MediumPurple;
            this.btVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerify.ForeColor = System.Drawing.SystemColors.Control;
            this.btVerify.Location = new System.Drawing.Point(83, 151);
            this.btVerify.Margin = new System.Windows.Forms.Padding(2);
            this.btVerify.Name = "btVerify";
            this.btVerify.Size = new System.Drawing.Size(207, 40);
            this.btVerify.TabIndex = 22;
            this.btVerify.Text = "Xác thực";
            this.btVerify.UseVisualStyleBackColor = false;
            this.btVerify.Click += new System.EventHandler(this.btVerify_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(85, 124);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(2);
            this.txtOTP.Multiline = true;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(208, 24);
            this.txtOTP.TabIndex = 21;
            this.txtOTP.TextChanged += new System.EventHandler(this.txtOTP_TextChanged_1);
            // 
            // lbOTP
            // 
            this.lbOTP.AutoSize = true;
            this.lbOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOTP.ForeColor = System.Drawing.Color.Black;
            this.lbOTP.Location = new System.Drawing.Point(82, 104);
            this.lbOTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOTP.Name = "lbOTP";
            this.lbOTP.Size = new System.Drawing.Size(88, 18);
            this.lbOTP.TabIndex = 20;
            this.lbOTP.Text = "Mã xác thực";
            // 
            // lbNotice
            // 
            this.lbNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotice.Location = new System.Drawing.Point(11, 44);
            this.lbNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(374, 50);
            this.lbNotice.TabIndex = 24;
            this.lbNotice.Text = "Vui lòng nhập mã xác thực được gửi về Email \r\nđể kích hoạt tài khoản. Mã có hiệu " +
    "lực trong vòng 1 phút\r\n";
            this.lbNotice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btAgain
            // 
            this.btAgain.BackColor = System.Drawing.Color.MediumPurple;
            this.btAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgain.ForeColor = System.Drawing.SystemColors.Control;
            this.btAgain.Location = new System.Drawing.Point(83, 195);
            this.btAgain.Margin = new System.Windows.Forms.Padding(2);
            this.btAgain.Name = "btAgain";
            this.btAgain.Size = new System.Drawing.Size(207, 40);
            this.btAgain.TabIndex = 25;
            this.btAgain.Text = "Gửi lại mã";
            this.btAgain.UseVisualStyleBackColor = false;
            this.btAgain.Click += new System.EventHandler(this.btAgain_Click);
            // 
            // frmActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 292);
            this.Controls.Add(this.btAgain);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btVerify);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.lbOTP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmActive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KÍCH HOẠT TÀI KHOẢN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btVerify;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label lbOTP;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Button btAgain;
        private EventHandler txtOTP_TextChanged;
        private EventHandler lbOTP_Click;
        private EventHandler lbNotice_Click;
    }
}