namespace Act4EDP
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userlogo = new System.Windows.Forms.PictureBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.AddAcct = new System.Windows.Forms.LinkLabel();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.AddAcct);
            this.loginpanel.Controls.Add(this.pictureBox2);
            this.loginpanel.Controls.Add(this.userlogo);
            this.loginpanel.Controls.Add(this.SignInBtn);
            this.loginpanel.Controls.Add(this.passwordlabel);
            this.loginpanel.Controls.Add(this.usernamelabel);
            this.loginpanel.Controls.Add(this.forgotpass);
            this.loginpanel.Controls.Add(this.login);
            this.loginpanel.Controls.Add(this.password);
            this.loginpanel.Controls.Add(this.Username);
            this.loginpanel.Location = new System.Drawing.Point(53, 100);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(403, 366);
            this.loginpanel.TabIndex = 2;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(36, 162);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // userlogo
            // 
            this.userlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userlogo.BackgroundImage")));
            this.userlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userlogo.Location = new System.Drawing.Point(36, 111);
            this.userlogo.Margin = new System.Windows.Forms.Padding(4);
            this.userlogo.Name = "userlogo";
            this.userlogo.Size = new System.Drawing.Size(36, 36);
            this.userlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userlogo.TabIndex = 4;
            this.userlogo.TabStop = false;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignInBtn.Location = new System.Drawing.Point(143, 257);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(100, 28);
            this.SignInBtn.TabIndex = 6;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(76, 150);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(77, 17);
            this.passwordlabel.TabIndex = 5;
            this.passwordlabel.Text = "Password";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(76, 97);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(81, 17);
            this.usernamelabel.TabIndex = 4;
            this.usernamelabel.Text = "Username";
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.LinkColor = System.Drawing.Color.Black;
            this.forgotpass.Location = new System.Drawing.Point(139, 224);
            this.forgotpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(109, 16);
            this.forgotpass.TabIndex = 3;
            this.forgotpass.TabStop = true;
            this.forgotpass.Text = "Forgot Password";
            this.forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpass_LinkClicked);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(164, 33);
            this.login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(56, 17);
            this.login.TabIndex = 2;
            this.login.Text = "LOGIN";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(80, 170);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(226, 24);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Control;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Location = new System.Drawing.Point(80, 117);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(226, 24);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // AddAcct
            // 
            this.AddAcct.AutoSize = true;
            this.AddAcct.LinkColor = System.Drawing.Color.Black;
            this.AddAcct.Location = new System.Drawing.Point(145, 305);
            this.AddAcct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddAcct.Name = "AddAcct";
            this.AddAcct.Size = new System.Drawing.Size(98, 16);
            this.AddAcct.TabIndex = 7;
            this.AddAcct.TabStop = true;
            this.AddAcct.Text = "Create Account";
            this.AddAcct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddAcct_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.loginpanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.LinkLabel forgotpass;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.PictureBox userlogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel AddAcct;
    }
}

