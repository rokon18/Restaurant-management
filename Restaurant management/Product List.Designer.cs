namespace Restaurant_management
{
    partial class Product_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_List));
            this.label1 = new System.Windows.Forms.Label();
            this.textpid = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.Label();
            this.textBoxpname = new System.Windows.Forms.TextBox();
            this.labelquantity = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelcategory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelimg = new System.Windows.Forms.Label();
            this.buttonimg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.pictureBoxsearch = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxPRICE = new System.Windows.Forms.TextBox();
            this.labelPRICE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product id:";
            // 
            // textpid
            // 
            this.textpid.Location = new System.Drawing.Point(41, 57);
            this.textpid.Name = "textpid";
            this.textpid.Size = new System.Drawing.Size(144, 26);
            this.textpid.TabIndex = 1;
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Location = new System.Drawing.Point(37, 109);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(114, 20);
            this.pname.TabIndex = 2;
            this.pname.Text = "Product Name:";
            // 
            // textBoxpname
            // 
            this.textBoxpname.Location = new System.Drawing.Point(41, 132);
            this.textBoxpname.Name = "textBoxpname";
            this.textBoxpname.Size = new System.Drawing.Size(144, 26);
            this.textBoxpname.TabIndex = 3;
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Location = new System.Drawing.Point(37, 264);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(72, 20);
            this.labelquantity.TabIndex = 4;
            this.labelquantity.Text = "Quantity:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lunch",
            "Dinner"});
            this.comboBox1.Location = new System.Drawing.Point(41, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // labelcategory
            // 
            this.labelcategory.AutoSize = true;
            this.labelcategory.Location = new System.Drawing.Point(37, 191);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(77, 20);
            this.labelcategory.TabIndex = 6;
            this.labelcategory.Text = "Category:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 96);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelimg
            // 
            this.labelimg.AutoSize = true;
            this.labelimg.Location = new System.Drawing.Point(37, 402);
            this.labelimg.Name = "labelimg";
            this.labelimg.Size = new System.Drawing.Size(56, 20);
            this.labelimg.TabIndex = 9;
            this.labelimg.Text = "image:";
            // 
            // buttonimg
            // 
            this.buttonimg.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonimg.Location = new System.Drawing.Point(41, 527);
            this.buttonimg.Name = "buttonimg";
            this.buttonimg.Size = new System.Drawing.Size(115, 42);
            this.buttonimg.TabIndex = 10;
            this.buttonimg.Text = "insert image";
            this.buttonimg.UseVisualStyleBackColor = false;
            this.buttonimg.Click += new System.EventHandler(this.buttonimg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(768, 402);
            this.dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += DataGridView1_CellClick;

            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonadd.Location = new System.Drawing.Point(511, 527);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(115, 42);
            this.buttonadd.TabIndex = 12;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackColor = System.Drawing.Color.Yellow;
            this.buttonupdate.Location = new System.Drawing.Point(693, 527);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(115, 42);
            this.buttonupdate.TabIndex = 13;
            this.buttonupdate.Text = "update";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttondel
            // 
            this.buttondel.BackColor = System.Drawing.Color.Red;
            this.buttondel.Location = new System.Drawing.Point(841, 527);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(115, 42);
            this.buttondel.TabIndex = 14;
            this.buttondel.Text = "Delete";
            this.buttondel.UseVisualStyleBackColor = false;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxsearch.Location = new System.Drawing.Point(594, 12);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(259, 30);
            this.textBoxsearch.TabIndex = 15;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // pictureBoxsearch
            // 
            this.pictureBoxsearch.Image = global::Restaurant_management.Properties.Resources.icons8_search_24;
            this.pictureBoxsearch.Location = new System.Drawing.Point(823, 12);
            this.pictureBoxsearch.Name = "pictureBoxsearch";
            this.pictureBoxsearch.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxsearch.TabIndex = 16;
            this.pictureBoxsearch.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 28);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxPRICE
            // 
            this.textBoxPRICE.Location = new System.Drawing.Point(39, 362);
            this.textBoxPRICE.Name = "textBoxPRICE";
            this.textBoxPRICE.Size = new System.Drawing.Size(144, 26);
            this.textBoxPRICE.TabIndex = 19;
            // 
            // labelPRICE
            // 
            this.labelPRICE.AutoSize = true;
            this.labelPRICE.Location = new System.Drawing.Point(35, 339);
            this.labelPRICE.Name = "labelPRICE";
            this.labelPRICE.Size = new System.Drawing.Size(48, 20);
            this.labelPRICE.TabIndex = 20;
            this.labelPRICE.Text = "Price:";
            // 
            // Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 693);
            this.Controls.Add(this.labelPRICE);
            this.Controls.Add(this.textBoxPRICE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxsearch);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonimg);
            this.Controls.Add(this.labelimg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelcategory);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelquantity);
            this.Controls.Add(this.textBoxpname);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.textpid);
            this.Controls.Add(this.label1);
            this.Name = "Product_List";
            this.Text = "Product_List";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textpid;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.TextBox textBoxpname;
        private System.Windows.Forms.Label labelquantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelimg;
        private System.Windows.Forms.Button buttonimg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.PictureBox pictureBoxsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxPRICE;
        private System.Windows.Forms.Label labelPRICE;
    }
}