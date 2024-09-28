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
            this.panel10 = new System.Windows.Forms.Panel();
            this.GoProfile = new System.Windows.Forms.Button();
            this.GoCart = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(4, 106);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(899, 509);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLunch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnLunch.Location = new System.Drawing.Point(412, 22);
            this.btnLunch.Margin = new System.Windows.Forms.Padding(2);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(85, 54);
            this.btnLunch.TabIndex = 1;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click_1);
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDinner.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnDinner.Location = new System.Drawing.Point(515, 22);
            this.btnDinner.Margin = new System.Windows.Forms.Padding(2);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(114, 54);
            this.btnDinner.TabIndex = 2;
            this.btnDinner.Text = "Dinner";
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click_1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.Location = new System.Drawing.Point(15, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(60, 64);
            this.panel10.TabIndex = 35;
            // 
            // GoProfile
            // 
            this.GoProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoProfile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.GoProfile.ForeColor = System.Drawing.Color.Black;
            this.GoProfile.Location = new System.Drawing.Point(90, 22);
            this.GoProfile.Name = "GoProfile";
            this.GoProfile.Size = new System.Drawing.Size(128, 54);
            this.GoProfile.TabIndex = 34;
            this.GoProfile.Text = "Go to Profile";
            this.GoProfile.UseVisualStyleBackColor = false;
            // 
            // GoCart
            // 
            this.GoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoCart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.GoCart.ForeColor = System.Drawing.Color.Black;
            this.GoCart.Location = new System.Drawing.Point(233, 22);
            this.GoCart.Name = "GoCart";
            this.GoCart.Size = new System.Drawing.Size(156, 54);
            this.GoCart.TabIndex = 32;
            this.GoCart.Text = "Go to Cart";
            this.GoCart.UseVisualStyleBackColor = false;
            this.GoCart.Click += new System.EventHandler(this.GoCart_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.Window;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.SearchIcon);
            this.panel15.Controls.Add(this.SearchBox);
            this.panel15.Location = new System.Drawing.Point(656, 35);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(229, 31);
            this.panel15.TabIndex = 36;
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon.Image")));
            this.SearchIcon.InitialImage = null;
            this.SearchIcon.Location = new System.Drawing.Point(198, -1);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(30, 31);
            this.SearchIcon.TabIndex = 1;
            this.SearchIcon.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SearchBox.Location = new System.Drawing.Point(3, 9);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(189, 13);
            this.SearchBox.TabIndex = 0;
            // 
            // MenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 618);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.GoCart);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.GoProfile);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.flowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuList";
            this.Text = "MenuList";
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button GoProfile;
        private System.Windows.Forms.Button GoCart;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.TextBox SearchBox;
    }
}
