namespace Act4EDP
{
    partial class FYA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FYA));
            this.findyouraccount = new System.Windows.Forms.Label();
            this.Findyouracct = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.resetbtn = new System.Windows.Forms.Button();
            this.FYA_Closing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FYA_Closing)).BeginInit();
            this.SuspendLayout();
            // 
            // findyouraccount
            // 
            this.findyouraccount.AutoSize = true;
            this.findyouraccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findyouraccount.Location = new System.Drawing.Point(60, 59);
            this.findyouraccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findyouraccount.Name = "findyouraccount";
            this.findyouraccount.Size = new System.Drawing.Size(190, 25);
            this.findyouraccount.TabIndex = 0;
            this.findyouraccount.Text = "Find Your Account";
            // 
            // Findyouracct
            // 
            this.Findyouracct.AutoSize = true;
            this.Findyouracct.Location = new System.Drawing.Point(62, 94);
            this.Findyouracct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Findyouracct.Name = "Findyouracct";
            this.Findyouracct.Size = new System.Drawing.Size(412, 16);
            this.Findyouracct.TabIndex = 1;
            this.Findyouracct.Text = "Enter the email that associate with your account to change password.";
            this.Findyouracct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Findyouracct.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(54, 139);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(444, 22);
            this.email.TabIndex = 2;
            this.email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.IndianRed;
            this.resetbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetbtn.Location = new System.Drawing.Point(398, 212);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(100, 38);
            this.resetbtn.TabIndex = 3;
            this.resetbtn.Text = "Next";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FYA_Closing
            // 
            this.FYA_Closing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FYA_Closing.BackgroundImage")));
            this.FYA_Closing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FYA_Closing.Location = new System.Drawing.Point(12, 12);
            this.FYA_Closing.Name = "FYA_Closing";
            this.FYA_Closing.Size = new System.Drawing.Size(25, 31);
            this.FYA_Closing.TabIndex = 4;
            this.FYA_Closing.TabStop = false;
            this.FYA_Closing.Click += new System.EventHandler(this.FYA_Closing_Click);
            // 
            // FYA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 295);
            this.Controls.Add(this.FYA_Closing);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Findyouracct);
            this.Controls.Add(this.findyouraccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FYA";
            this.Text = "Find Your Account";
            ((System.ComponentModel.ISupportInitialize)(this.FYA_Closing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findyouraccount;
        private System.Windows.Forms.Label Findyouracct;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.PictureBox FYA_Closing;
    }
}