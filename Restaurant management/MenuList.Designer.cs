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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(10, 46);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1097, 557);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.OliveDrab;
            this.btnLunch.Location = new System.Drawing.Point(267, 0);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(110, 40);
            this.btnLunch.TabIndex = 1;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click_1);
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDinner.Location = new System.Drawing.Point(557, 0);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(97, 40);
            this.btnDinner.TabIndex = 2;
            this.btnDinner.Text = "Dinner";
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click_1);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCart.Location = new System.Drawing.Point(847, 0);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(151, 40);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Go To Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            // 
            // MenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 615);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnDinner);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "MenuList";
            this.Text = "MenuList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Button btnCart;
    }
}
