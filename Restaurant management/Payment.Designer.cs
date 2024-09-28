namespace Restaurant_management
{
    partial class Payment
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttoncancard = new System.Windows.Forms.Button();
            this.buttoncardcon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.texbxamount2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncanbks = new System.Windows.Forms.Button();
            this.buttonconbks = new System.Windows.Forms.Button();
            this.texbxamount = new System.Windows.Forms.TextBox();
            this.amntlbl = new System.Windows.Forms.Label();
            this.textBoxbkspass = new System.Windows.Forms.TextBox();
            this.acclblpass = new System.Windows.Forms.Label();
            this.textBoxaccno = new System.Windows.Forms.TextBox();
            this.leblf1accno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(315, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Bkash";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(477, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(22)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.btncanbks);
            this.panel1.Controls.Add(this.buttonconbks);
            this.panel1.Controls.Add(this.texbxamount);
            this.panel1.Controls.Add(this.amntlbl);
            this.panel1.Controls.Add(this.textBoxbkspass);
            this.panel1.Controls.Add(this.acclblpass);
            this.panel1.Controls.Add(this.textBoxaccno);
            this.panel1.Controls.Add(this.leblf1accno);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(238, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 327);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.buttoncancard);
            this.panel2.Controls.Add(this.buttoncardcon);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.texbxamount2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(223, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 279);
            this.panel2.TabIndex = 3;
            // 
            // buttoncancard
            // 
            this.buttoncancard.BackColor = System.Drawing.Color.LightGray;
            this.buttoncancard.Location = new System.Drawing.Point(355, 239);
            this.buttoncancard.Name = "buttoncancard";
            this.buttoncancard.Size = new System.Drawing.Size(84, 37);
            this.buttoncancard.TabIndex = 9;
            this.buttoncancard.Text = "Cancel";
            this.buttoncancard.UseVisualStyleBackColor = false;
            this.buttoncancard.Click += new System.EventHandler(this.buttoncancard_Click);
            // 
            // buttoncardcon
            // 
            this.buttoncardcon.BackColor = System.Drawing.Color.Silver;
            this.buttoncardcon.Location = new System.Drawing.Point(141, 239);
            this.buttoncardcon.Name = "buttoncardcon";
            this.buttoncardcon.Size = new System.Drawing.Size(98, 37);
            this.buttoncardcon.TabIndex = 14;
            this.buttoncardcon.Text = "Confirm";
            this.buttoncardcon.UseVisualStyleBackColor = false;
            this.buttoncardcon.Click += new System.EventHandler(this.buttoncardcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Card Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "CVV:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(433, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 26);
            this.textBox4.TabIndex = 10;
            // 
            // texbxamount2
            // 
            this.texbxamount2.Location = new System.Drawing.Point(141, 139);
            this.texbxamount2.Name = "texbxamount2";
            this.texbxamount2.Size = new System.Drawing.Size(223, 26);
            this.texbxamount2.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 26);
            this.textBox2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(22)))), ((int)(((byte)(118)))));
            this.pictureBox2.Image = global::Restaurant_management.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(88, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(372, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btncanbks
            // 
            this.btncanbks.BackColor = System.Drawing.Color.LightGray;
            this.btncanbks.Location = new System.Drawing.Point(269, 287);
            this.btncanbks.Name = "btncanbks";
            this.btncanbks.Size = new System.Drawing.Size(84, 37);
            this.btncanbks.TabIndex = 8;
            this.btncanbks.Text = "Cancel";
            this.btncanbks.UseVisualStyleBackColor = false;
            this.btncanbks.Click += new System.EventHandler(this.btncanbks_Click);
            // 
            // buttonconbks
            // 
            this.buttonconbks.BackColor = System.Drawing.Color.Silver;
            this.buttonconbks.Location = new System.Drawing.Point(69, 287);
            this.buttonconbks.Name = "buttonconbks";
            this.buttonconbks.Size = new System.Drawing.Size(98, 37);
            this.buttonconbks.TabIndex = 7;
            this.buttonconbks.Text = "Confirm";
            this.buttonconbks.UseVisualStyleBackColor = false;
            this.buttonconbks.Click += new System.EventHandler(this.buttonconbks_Click);
            // 
            // texbxamount
            // 
            this.texbxamount.Location = new System.Drawing.Point(125, 195);
            this.texbxamount.Name = "texbxamount";
            this.texbxamount.Size = new System.Drawing.Size(181, 26);
            this.texbxamount.TabIndex = 6;
            // 
            // amntlbl
            // 
            this.amntlbl.AutoSize = true;
            this.amntlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amntlbl.Location = new System.Drawing.Point(16, 195);
            this.amntlbl.Name = "amntlbl";
            this.amntlbl.Size = new System.Drawing.Size(83, 22);
            this.amntlbl.TabIndex = 5;
            this.amntlbl.Text = "Amount:";
            // 
            // textBoxbkspass
            // 
            this.textBoxbkspass.Location = new System.Drawing.Point(125, 145);
            this.textBoxbkspass.Name = "textBoxbkspass";
            this.textBoxbkspass.Size = new System.Drawing.Size(181, 26);
            this.textBoxbkspass.TabIndex = 4;
            // 
            // acclblpass
            // 
            this.acclblpass.AutoSize = true;
            this.acclblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acclblpass.Location = new System.Drawing.Point(16, 145);
            this.acclblpass.Name = "acclblpass";
            this.acclblpass.Size = new System.Drawing.Size(103, 22);
            this.acclblpass.TabIndex = 3;
            this.acclblpass.Text = "Password:";
            // 
            // textBoxaccno
            // 
            this.textBoxaccno.Location = new System.Drawing.Point(125, 87);
            this.textBoxaccno.Name = "textBoxaccno";
            this.textBoxaccno.Size = new System.Drawing.Size(181, 26);
            this.textBoxaccno.TabIndex = 2;
            // 
            // leblf1accno
            // 
            this.leblf1accno.AutoSize = true;
            this.leblf1accno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leblf1accno.Location = new System.Drawing.Point(42, 87);
            this.leblf1accno.Name = "leblf1accno";
            this.leblf1accno.Size = new System.Drawing.Size(77, 22);
            this.leblf1accno.TabIndex = 1;
            this.leblf1accno.Text = "Acc no:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(22)))), ((int)(((byte)(118)))));
            this.pictureBox1.Image = global::Restaurant_management.Properties.Resources.bkash_payment_logo;
            this.pictureBox1.Location = new System.Drawing.Point(56, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(95)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please Select Pyment Method";
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printbtn.Location = new System.Drawing.Point(678, 535);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(162, 46);
            this.printbtn.TabIndex = 4;
            this.printbtn.Text = "Print bill";
            this.printbtn.UseVisualStyleBackColor = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 675);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxaccno;
        private System.Windows.Forms.Label leblf1accno;
        private System.Windows.Forms.TextBox texbxamount;
        private System.Windows.Forms.Label amntlbl;
        private System.Windows.Forms.TextBox textBoxbkspass;
        private System.Windows.Forms.Label acclblpass;
        private System.Windows.Forms.Button btncanbks;
        private System.Windows.Forms.Button buttonconbks;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox texbxamount2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoncancard;
        private System.Windows.Forms.Button buttoncardcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button printbtn;
    }
}