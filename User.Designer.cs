namespace Act4EDP
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.PlayerData = new System.Windows.Forms.DataGridView();
            this.FYA_Closing = new System.Windows.Forms.PictureBox();
            this.AcctList = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FYA_Closing)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerData
            // 
            this.PlayerData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerData.Location = new System.Drawing.Point(41, 146);
            this.PlayerData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerData.Name = "PlayerData";
            this.PlayerData.RowHeadersWidth = 51;
            this.PlayerData.RowTemplate.Height = 24;
            this.PlayerData.Size = new System.Drawing.Size(824, 469);
            this.PlayerData.TabIndex = 0;
            this.PlayerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FYA_Closing
            // 
            this.FYA_Closing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FYA_Closing.BackgroundImage")));
            this.FYA_Closing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FYA_Closing.Location = new System.Drawing.Point(12, 14);
            this.FYA_Closing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FYA_Closing.Name = "FYA_Closing";
            this.FYA_Closing.Size = new System.Drawing.Size(40, 45);
            this.FYA_Closing.TabIndex = 5;
            this.FYA_Closing.TabStop = false;
            this.FYA_Closing.Click += new System.EventHandler(this.FYA_Closing_Click);
            // 
            // AcctList
            // 
            this.AcctList.AutoSize = true;
            this.AcctList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctList.Location = new System.Drawing.Point(380, 25);
            this.AcctList.Name = "AcctList";
            this.AcctList.Size = new System.Drawing.Size(124, 24);
            this.AcctList.TabIndex = 6;
            this.AcctList.Text = "Account List";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(666, 102);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(199, 21);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(596, 102);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(64, 17);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search:";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(908, 654);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.AcctList);
            this.Controls.Add(this.FYA_Closing);
            this.Controls.Add(this.PlayerData);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FYA_Closing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerData;
        private System.Windows.Forms.PictureBox FYA_Closing;
        private System.Windows.Forms.Label AcctList;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label Search;
    }
}