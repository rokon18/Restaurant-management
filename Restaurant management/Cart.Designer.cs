
namespace Restaurant_management
{
    partial class CartPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplyPromo = new System.Windows.Forms.Button();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.button9chkout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.GrandTotal = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GoMenu = new System.Windows.Forms.Button();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cart";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ApplyPromo);
            this.panel1.Controls.Add(this.DiscountTextBox);
            this.panel1.Controls.Add(this.button9chkout);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.GrandTotal);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.SubTotal);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(842, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 351);
            this.panel1.TabIndex = 1;
            // 
            // ApplyPromo
            // 
            this.ApplyPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ApplyPromo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyPromo.ForeColor = System.Drawing.Color.Black;
            this.ApplyPromo.Location = new System.Drawing.Point(372, 128);
            this.ApplyPromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApplyPromo.Name = "ApplyPromo";
            this.ApplyPromo.Size = new System.Drawing.Size(104, 45);
            this.ApplyPromo.TabIndex = 33;
            this.ApplyPromo.Text = "Apply";
            this.ApplyPromo.UseVisualStyleBackColor = false;
            this.ApplyPromo.Click += new System.EventHandler(this.ApplyDiscount);
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(238, 135);
            this.DiscountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(114, 26);
            this.DiscountTextBox.TabIndex = 14;
            // 
            // button9chkout
            // 
            this.button9chkout.BackColor = System.Drawing.Color.Black;
            this.button9chkout.Font = new System.Drawing.Font("Arial", 18F);
            this.button9chkout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9chkout.Location = new System.Drawing.Point(42, 265);
            this.button9chkout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9chkout.Name = "button9chkout";
            this.button9chkout.Size = new System.Drawing.Size(360, 72);
            this.button9chkout.TabIndex = 3;
            this.button9chkout.Text = "Checkout Now";
            this.button9chkout.UseVisualStyleBackColor = false;
            this.button9chkout.Click += new System.EventHandler(this.button9chkout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(354, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 36);
            this.label8.TabIndex = 11;
            this.label8.Text = "৳";
            // 
            // GrandTotal
            // 
            this.GrandTotal.AutoSize = true;
            this.GrandTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotal.Location = new System.Drawing.Point(394, 212);
            this.GrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.Size = new System.Drawing.Size(71, 36);
            this.GrandTotal.TabIndex = 10;
            this.GrandTotal.Text = "0.00";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label33.Location = new System.Drawing.Point(354, 52);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 36);
            this.label33.TabIndex = 9;
            this.label33.Text = "৳";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(394, 52);
            this.SubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(71, 36);
            this.SubTotal.TabIndex = 8;
            this.SubTotal.Text = "0.00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(42, 192);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 0);
            this.panel3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Grand Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(46, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(46, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtotal";
            // 
            // GoMenu
            // 
            this.GoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.5F, System.Drawing.FontStyle.Bold);
            this.GoMenu.ForeColor = System.Drawing.Color.Black;
            this.GoMenu.Location = new System.Drawing.Point(1032, 18);
            this.GoMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoMenu.Name = "GoMenu";
            this.GoMenu.Size = new System.Drawing.Size(321, 83);
            this.GoMenu.TabIndex = 32;
            this.GoMenu.Text = "Go Back to Menu";
            this.GoMenu.UseVisualStyleBackColor = false;
            this.GoMenu.Click += new System.EventHandler(this.GoMenu_Click);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.AllowUserToResizeColumns = false;
            this.dataGridViewCart.AllowUserToResizeRows = false;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCart.Location = new System.Drawing.Point(13, 163);
            this.dataGridViewCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.RowHeadersWidth = 62;
            this.dataGridViewCart.Size = new System.Drawing.Size(821, 609);
            this.dataGridViewCart.TabIndex = 3;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            this.dataGridViewCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellValueChanged);
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1412, 786);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.GoMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CartPage";
            this.Text = "CartPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label GrandTotal;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Button button9chkout;
        private System.Windows.Forms.Button GoMenu;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Button ApplyPromo;
    }
}