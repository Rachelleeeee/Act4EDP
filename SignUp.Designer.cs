namespace Act4EDP
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.birthday = new System.Windows.Forms.Label();
            this.SU_Closing = new System.Windows.Forms.PictureBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.NewPasstxtbx = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.Label();
            this.NewUNtxtb = new System.Windows.Forms.TextBox();
            this.NewUsername = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.newacctlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SU_Closing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.birthdate);
            this.panel1.Controls.Add(this.birthday);
            this.panel1.Controls.Add(this.SU_Closing);
            this.panel1.Controls.Add(this.SignUpBtn);
            this.panel1.Controls.Add(this.NewPasstxtbx);
            this.panel1.Controls.Add(this.NewPass);
            this.panel1.Controls.Add(this.NewUNtxtb);
            this.panel1.Controls.Add(this.NewUsername);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.emaillabel);
            this.panel1.Controls.Add(this.newacctlbl);
            this.panel1.Location = new System.Drawing.Point(168, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 277);
            this.panel1.TabIndex = 0;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(16, 162);
            this.birthdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(170, 20);
            this.birthdate.TabIndex = 14;
            this.birthdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(14, 146);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(57, 13);
            this.birthday.TabIndex = 13;
            this.birthday.Text = "Birthday:";
            this.birthday.Click += new System.EventHandler(this.label1_Click);
            // 
            // SU_Closing
            // 
            this.SU_Closing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SU_Closing.BackgroundImage")));
            this.SU_Closing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SU_Closing.Location = new System.Drawing.Point(16, 14);
            this.SU_Closing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SU_Closing.Name = "SU_Closing";
            this.SU_Closing.Size = new System.Drawing.Size(16, 19);
            this.SU_Closing.TabIndex = 12;
            this.SU_Closing.TabStop = false;
            this.SU_Closing.Click += new System.EventHandler(this.SU_Closing_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignUpBtn.Location = new System.Drawing.Point(61, 238);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(70, 24);
            this.SignUpBtn.TabIndex = 11;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // NewPasstxtbx
            // 
            this.NewPasstxtbx.BackColor = System.Drawing.SystemColors.Control;
            this.NewPasstxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPasstxtbx.Location = new System.Drawing.Point(16, 212);
            this.NewPasstxtbx.Multiline = true;
            this.NewPasstxtbx.Name = "NewPasstxtbx";
            this.NewPasstxtbx.Size = new System.Drawing.Size(170, 20);
            this.NewPasstxtbx.TabIndex = 10;
            this.NewPasstxtbx.TextChanged += new System.EventHandler(this.NewPasstxtbx_TextChanged);
            // 
            // NewPass
            // 
            this.NewPass.AutoSize = true;
            this.NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass.Location = new System.Drawing.Point(14, 195);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(65, 13);
            this.NewPass.TabIndex = 9;
            this.NewPass.Text = "Password:";
            this.NewPass.Click += new System.EventHandler(this.NewPass_Click);
            // 
            // NewUNtxtb
            // 
            this.NewUNtxtb.BackColor = System.Drawing.SystemColors.Control;
            this.NewUNtxtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewUNtxtb.Location = new System.Drawing.Point(16, 112);
            this.NewUNtxtb.Multiline = true;
            this.NewUNtxtb.Name = "NewUNtxtb";
            this.NewUNtxtb.Size = new System.Drawing.Size(170, 20);
            this.NewUNtxtb.TabIndex = 8;
            this.NewUNtxtb.TextChanged += new System.EventHandler(this.NewUNtxtb_TextChanged);
            // 
            // NewUsername
            // 
            this.NewUsername.AutoSize = true;
            this.NewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUsername.Location = new System.Drawing.Point(14, 95);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(67, 13);
            this.NewUsername.TabIndex = 7;
            this.NewUsername.Text = "Username:";
            this.NewUsername.Click += new System.EventHandler(this.NewUsername_Click);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.Control;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Location = new System.Drawing.Point(16, 65);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(170, 20);
            this.Email.TabIndex = 6;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(14, 48);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(41, 13);
            this.emaillabel.TabIndex = 5;
            this.emaillabel.Text = "Email:";
            this.emaillabel.Click += new System.EventHandler(this.emaillabel_Click);
            // 
            // newacctlbl
            // 
            this.newacctlbl.AutoSize = true;
            this.newacctlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newacctlbl.Location = new System.Drawing.Point(58, 14);
            this.newacctlbl.Name = "newacctlbl";
            this.newacctlbl.Size = new System.Drawing.Size(119, 13);
            this.newacctlbl.TabIndex = 3;
            this.newacctlbl.Text = "CREATE ACCOUNT";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(546, 307);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SU_Closing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label newacctlbl;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label NewUsername;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox NewPasstxtbx;
        private System.Windows.Forms.Label NewPass;
        private System.Windows.Forms.TextBox NewUNtxtb;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.PictureBox SU_Closing;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label birthday;
    }
}