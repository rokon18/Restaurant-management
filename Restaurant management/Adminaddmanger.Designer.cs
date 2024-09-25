namespace Restaurant_management
{
    partial class Adminaddmanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminaddmanger));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.joiningdatetime = new System.Windows.Forms.DateTimePicker();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.managergenderlabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.managernametxt = new System.Windows.Forms.TextBox();
            this.gendercombobox = new System.Windows.Forms.ComboBox();
            this.Joiningdatelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Deletebutton);
            this.panel1.Controls.Add(this.joiningdatetime);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.managergenderlabel);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.managernametxt);
            this.panel1.Controls.Add(this.gendercombobox);
            this.panel1.Controls.Add(this.Joiningdatelabel);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 534);
            this.panel1.TabIndex = 29;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.Black;
            this.Deletebutton.Location = new System.Drawing.Point(68, 446);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(107, 44);
            this.Deletebutton.TabIndex = 17;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = false;
            // 
            // joiningdatetime
            // 
            this.joiningdatetime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joiningdatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joiningdatetime.Location = new System.Drawing.Point(25, 288);
            this.joiningdatetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joiningdatetime.Name = "joiningdatetime";
            this.joiningdatetime.Size = new System.Drawing.Size(192, 30);
            this.joiningdatetime.TabIndex = 4;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(126, 373);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(107, 44);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager Name";
            // 
            // managergenderlabel
            // 
            this.managergenderlabel.AutoSize = true;
            this.managergenderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managergenderlabel.Location = new System.Drawing.Point(20, 173);
            this.managergenderlabel.Name = "managergenderlabel";
            this.managergenderlabel.Size = new System.Drawing.Size(174, 25);
            this.managergenderlabel.TabIndex = 1;
            this.managergenderlabel.Text = "Manager Gender";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(11, 373);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 44);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // managernametxt
            // 
            this.managernametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.managernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managernametxt.Location = new System.Drawing.Point(25, 110);
            this.managernametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.managernametxt.Name = "managernametxt";
            this.managernametxt.Size = new System.Drawing.Size(192, 30);
            this.managernametxt.TabIndex = 0;
            // 
            // gendercombobox
            // 
            this.gendercombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendercombobox.FormattingEnabled = true;
            this.gendercombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombobox.Location = new System.Drawing.Point(25, 200);
            this.gendercombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gendercombobox.Name = "gendercombobox";
            this.gendercombobox.Size = new System.Drawing.Size(192, 28);
            this.gendercombobox.TabIndex = 1;
            // 
            // Joiningdatelabel
            // 
            this.Joiningdatelabel.AutoSize = true;
            this.Joiningdatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joiningdatelabel.Location = new System.Drawing.Point(29, 261);
            this.Joiningdatelabel.Name = "Joiningdatelabel";
            this.Joiningdatelabel.Size = new System.Drawing.Size(133, 25);
            this.Joiningdatelabel.TabIndex = 1;
            this.Joiningdatelabel.Text = "Joining Date";
            // 
            // Adminaddmanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel1);
            this.Name = "Adminaddmanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminaddmanger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label managergenderlabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox managernametxt;
        private System.Windows.Forms.ComboBox gendercombobox;
        private System.Windows.Forms.Label Joiningdatelabel;
        private System.Windows.Forms.DateTimePicker joiningdatetime;
        private System.Windows.Forms.Button Deletebutton;
    }
}