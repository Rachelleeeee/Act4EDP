namespace Act4EDP
{
    partial class UpdateProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProf));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateUN = new System.Windows.Forms.Label();
            this.UpdateEmail = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(115, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateUN
            // 
            this.UpdateUN.AutoSize = true;
            this.UpdateUN.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUN.Location = new System.Drawing.Point(23, 155);
            this.UpdateUN.Name = "UpdateUN";
            this.UpdateUN.Size = new System.Drawing.Size(144, 24);
            this.UpdateUN.TabIndex = 1;
            this.UpdateUN.Text = "New Username:";
            this.UpdateUN.Click += new System.EventHandler(this.UpdateUN_Click);
            // 
            // UpdateEmail
            // 
            this.UpdateEmail.AutoSize = true;
            this.UpdateEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmail.Location = new System.Drawing.Point(23, 237);
            this.UpdateEmail.Name = "UpdateEmail";
            this.UpdateEmail.Size = new System.Drawing.Size(105, 24);
            this.UpdateEmail.TabIndex = 2;
            this.UpdateEmail.Text = "New Email:";
            this.UpdateEmail.Click += new System.EventHandler(this.UpdateEmail_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(24, 192);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(307, 22);
            this.usernamebox.TabIndex = 3;
            this.usernamebox.TextChanged += new System.EventHandler(this.UpUNtxt_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(24, 277);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(307, 22);
            this.emailbox.TabIndex = 4;
            this.emailbox.TextChanged += new System.EventHandler(this.UpEmailxt_TextChanged);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(24, 338);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 33);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UpdateProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 394);
            this.Controls.Add(this.update);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.UpdateEmail);
            this.Controls.Add(this.UpdateUN);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateProf";
            this.Text = "Edit Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UpdateUN;
        private System.Windows.Forms.Label UpdateEmail;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.Button update;
    }
}