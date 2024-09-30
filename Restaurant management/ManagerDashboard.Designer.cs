namespace Restaurant_management
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            this.panel1manager = new System.Windows.Forms.Panel();
            this.btnchgpass = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btndeProduct = new System.Windows.Forms.Button();
            this.btnupdateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1manager
            // 
            this.panel1manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(132)))), ((int)(((byte)(89)))));
            this.panel1manager.Controls.Add(this.btnchgpass);
            this.panel1manager.Controls.Add(this.btnLogout);
            this.panel1manager.Controls.Add(this.btndeProduct);
            this.panel1manager.Controls.Add(this.btnupdateProduct);
            this.panel1manager.Controls.Add(this.label1);
            this.panel1manager.Controls.Add(this.pictureBox1);
            this.panel1manager.Controls.Add(this.btnAddProduct);
            this.panel1manager.Location = new System.Drawing.Point(1, 0);
            this.panel1manager.Name = "panel1manager";
            this.panel1manager.Size = new System.Drawing.Size(244, 651);
            this.panel1manager.TabIndex = 0;
            // 
            // btnchgpass
            // 
            this.btnchgpass.Location = new System.Drawing.Point(48, 417);
            this.btnchgpass.Name = "btnchgpass";
            this.btnchgpass.Size = new System.Drawing.Size(123, 48);
            this.btnchgpass.TabIndex = 6;
            this.btnchgpass.Text = "Change password";
            this.btnchgpass.UseVisualStyleBackColor = true;
            this.btnchgpass.Click += new System.EventHandler(this.btnchgpass_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(48, 583);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btndeProduct
            // 
            this.btndeProduct.Location = new System.Drawing.Point(48, 339);
            this.btndeProduct.Name = "btndeProduct";
            this.btndeProduct.Size = new System.Drawing.Size(123, 42);
            this.btndeProduct.TabIndex = 4;
            this.btndeProduct.Text = "Delete Product";
            this.btndeProduct.UseVisualStyleBackColor = true;
            this.btndeProduct.Click += new System.EventHandler(this.btndeProduct_Click);
            // 
            // btnupdateProduct
            // 
            this.btnupdateProduct.Location = new System.Drawing.Point(48, 254);
            this.btnupdateProduct.Name = "btnupdateProduct";
            this.btnupdateProduct.Size = new System.Drawing.Size(123, 52);
            this.btnupdateProduct.TabIndex = 3;
            this.btnupdateProduct.Text = "Update Product";
            this.btnupdateProduct.UseVisualStyleBackColor = true;
            this.btnupdateProduct.Click += new System.EventHandler(this.btnupdateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(66, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 76);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(48, 170);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(123, 42);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 230);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 50);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(377, 347);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 53);
            this.textBox3.TabIndex = 6;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(913, 663);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1manager);
            this.Name = "ManagerDashboard";
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.panel1manager.ResumeLayout(false);
            this.panel1manager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1manager;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btndeProduct;
        private System.Windows.Forms.Button btnupdateProduct;
        private System.Windows.Forms.Button btnchgpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}