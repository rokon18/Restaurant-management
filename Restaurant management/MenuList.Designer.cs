namespace Restaurant_management
{
    partial class MenuList
    {
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuList));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.GoProfile = new System.Windows.Forms.Button();
            this.GoCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(6, 163);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1348, 527);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLunch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnLunch.Location = new System.Drawing.Point(275, 44);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(179, 61);
            this.btnLunch.TabIndex = 1;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click_1);
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDinner.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnDinner.Location = new System.Drawing.Point(485, 45);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(171, 62);
            this.btnDinner.TabIndex = 2;
            this.btnDinner.Text = "Dinner";
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click_1);
            // 
            // GoProfile
            // 
            this.GoProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoProfile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.GoProfile.ForeColor = System.Drawing.Color.Black;
            this.GoProfile.Location = new System.Drawing.Point(25, 34);
            this.GoProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoProfile.Name = "GoProfile";
            this.GoProfile.Size = new System.Drawing.Size(192, 83);
            this.GoProfile.TabIndex = 34;
            this.GoProfile.Text = "    Go to Profile";
            this.GoProfile.UseVisualStyleBackColor = false;
            this.GoProfile.Click += new System.EventHandler(this.GoProfile_Click);
            // 
            // GoCart
            // 
            this.GoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoCart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.GoCart.ForeColor = System.Drawing.Color.Black;
            this.GoCart.Location = new System.Drawing.Point(1051, 45);
            this.GoCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoCart.Name = "GoCart";
            this.GoCart.Size = new System.Drawing.Size(202, 62);
            this.GoCart.TabIndex = 32;
            this.GoCart.Text = "Go to Cart";
            this.GoCart.UseVisualStyleBackColor = false;
            this.GoCart.Click += new System.EventHandler(this.GoCart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_management.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(25, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon.Image")));
            this.SearchIcon.InitialImage = null;
            this.SearchIcon.Location = new System.Drawing.Point(970, 117);
            this.SearchIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(45, 40);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 1;
            this.SearchIcon.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(704, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 40);
            this.textBox1.TabIndex = 38;
            // 
            // MenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 799);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.GoCart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GoProfile);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "MenuList";
            this.Text = "MenuList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Button GoProfile;
        private System.Windows.Forms.Button GoCart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.TextBox textBox1;
    }
}
