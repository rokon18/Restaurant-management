
namespace Restaurant_management
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            this.AddProductPanelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.Userlabel = new System.Windows.Forms.Label();
            this.ProductShowCase = new System.Windows.Forms.PictureBox();
            this.ImageChoiceDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImageChoiceDialogButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.MenuItemDataTable = new System.Windows.Forms.DataGridView();
            this.rMSDataSet3 = new Restaurant_management.RMSDataSet3();
            this.menuItemTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuItemTableTableAdapter = new Restaurant_management.RMSDataSet3TableAdapters.MenuItemTableTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductShowCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductPanelButton
            // 
            this.AddProductPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddProductPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductPanelButton.FlatAppearance.BorderSize = 0;
            this.AddProductPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductPanelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductPanelButton.ForeColor = System.Drawing.Color.Black;
            this.AddProductPanelButton.Location = new System.Drawing.Point(136, 374);
            this.AddProductPanelButton.Name = "AddProductPanelButton";
            this.AddProductPanelButton.Size = new System.Drawing.Size(121, 36);
            this.AddProductPanelButton.TabIndex = 37;
            this.AddProductPanelButton.Text = "Add Product";
            this.AddProductPanelButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Category";
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(31, 217);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(226, 23);
            this.PriceBox.TabIndex = 34;
            this.PriceBox.UseSystemPasswordChar = true;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(35, 196);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(42, 18);
            this.passwordlabel.TabIndex = 33;
            this.passwordlabel.Text = "Price";
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameBox.Location = new System.Drawing.Point(31, 165);
            this.ProductNameBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(226, 23);
            this.ProductNameBox.TabIndex = 32;
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlabel.Location = new System.Drawing.Point(35, 143);
            this.Userlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(103, 18);
            this.Userlabel.TabIndex = 31;
            this.Userlabel.Text = "Product Name";
            // 
            // ProductShowCase
            // 
            this.ProductShowCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductShowCase.Location = new System.Drawing.Point(157, 31);
            this.ProductShowCase.Name = "ProductShowCase";
            this.ProductShowCase.Size = new System.Drawing.Size(100, 100);
            this.ProductShowCase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductShowCase.TabIndex = 38;
            this.ProductShowCase.TabStop = false;
            // 
            // ImageChoiceDialog
            // 
            this.ImageChoiceDialog.FileName = "openFileDialog1";
            // 
            // ImageChoiceDialogButton
            // 
            this.ImageChoiceDialogButton.BackColor = System.Drawing.Color.White;
            this.ImageChoiceDialogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageChoiceDialogButton.FlatAppearance.BorderSize = 0;
            this.ImageChoiceDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageChoiceDialogButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.ImageChoiceDialogButton.ForeColor = System.Drawing.Color.Black;
            this.ImageChoiceDialogButton.Location = new System.Drawing.Point(31, 321);
            this.ImageChoiceDialogButton.Name = "ImageChoiceDialogButton";
            this.ImageChoiceDialogButton.Size = new System.Drawing.Size(226, 36);
            this.ImageChoiceDialogButton.TabIndex = 39;
            this.ImageChoiceDialogButton.Text = "Choose Image";
            this.ImageChoiceDialogButton.UseVisualStyleBackColor = false;
            this.ImageChoiceDialogButton.Click += new System.EventHandler(this.ImageChoiceDialogButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Lunch",
            "Dinner"});
            this.CategoryComboBox.Location = new System.Drawing.Point(31, 278);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(226, 21);
            this.CategoryComboBox.TabIndex = 40;
            // 
            // MenuItemDataTable
            // 
            this.MenuItemDataTable.AutoGenerateColumns = false;
            this.MenuItemDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuItemDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.MenuItemDataTable.DataSource = this.menuItemTableBindingSource;
            this.MenuItemDataTable.Location = new System.Drawing.Point(292, 73);
            this.MenuItemDataTable.Name = "MenuItemDataTable";
            this.MenuItemDataTable.Size = new System.Drawing.Size(297, 306);
            this.MenuItemDataTable.TabIndex = 41;
            // 
            // rMSDataSet3
            // 
            this.rMSDataSet3.DataSetName = "RMSDataSet3";
            this.rMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemTableBindingSource
            // 
            this.menuItemTableBindingSource.DataMember = "MenuItemTable";
            this.menuItemTableBindingSource.DataSource = this.rMSDataSet3;
            // 
            // menuItemTableTableAdapter
            // 
            this.menuItemTableTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(38, 31);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(60, 28);
            this.BackButton.TabIndex = 42;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 433);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MenuItemDataTable);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ImageChoiceDialogButton);
            this.Controls.Add(this.ProductShowCase);
            this.Controls.Add(this.AddProductPanelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.Userlabel);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductShowCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductPanelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.PictureBox ProductShowCase;
        private System.Windows.Forms.OpenFileDialog ImageChoiceDialog;
        private System.Windows.Forms.Button ImageChoiceDialogButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DataGridView MenuItemDataTable;
        private RMSDataSet3 rMSDataSet3;
        private System.Windows.Forms.BindingSource menuItemTableBindingSource;
        private RMSDataSet3TableAdapters.MenuItemTableTableAdapter menuItemTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackButton;
    }
}