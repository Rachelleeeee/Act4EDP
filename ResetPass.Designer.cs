namespace Act4EDP
{
    partial class ResetPass
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
            this.ResetPassword = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.Label();
            this.confirmpass = new System.Windows.Forms.Label();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.passnew = new System.Windows.Forms.TextBox();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetPassword
            // 
            this.ResetPassword.AutoSize = true;
            this.ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassword.Location = new System.Drawing.Point(81, 11);
            this.ResetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(146, 20);
            this.ResetPassword.TabIndex = 0;
            this.ResetPassword.Text = "Reset Password";
            this.ResetPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // newpass
            // 
            this.newpass.AutoSize = true;
            this.newpass.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(16, 55);
            this.newpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(81, 16);
            this.newpass.TabIndex = 1;
            this.newpass.Text = "Old Password";
            // 
            // confirmpass
            // 
            this.confirmpass.AutoSize = true;
            this.confirmpass.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpass.Location = new System.Drawing.Point(16, 128);
            this.confirmpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(88, 16);
            this.confirmpass.TabIndex = 2;
            this.confirmpass.Text = "New Password";
            // 
            // oldpass
            // 
            this.oldpass.Location = new System.Drawing.Point(20, 75);
            this.oldpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oldpass.Name = "oldpass";
            this.oldpass.Size = new System.Drawing.Size(271, 22);
            this.oldpass.TabIndex = 3;
            // 
            // passnew
            // 
            this.passnew.Location = new System.Drawing.Point(20, 159);
            this.passnew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passnew.Name = "passnew";
            this.passnew.Size = new System.Drawing.Size(271, 22);
            this.passnew.TabIndex = 4;
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Resetbtn.Location = new System.Drawing.Point(85, 215);
            this.Resetbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(132, 28);
            this.Resetbtn.TabIndex = 5;
            this.Resetbtn.Text = "Reset Password";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 273);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.passnew);
            this.Controls.Add(this.oldpass);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.ResetPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPass";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResetPassword;
        private System.Windows.Forms.Label newpass;
        private System.Windows.Forms.Label confirmpass;
        private System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.TextBox passnew;
        private System.Windows.Forms.Button Resetbtn;
    }
}