namespace BT02_ThongTin
{
    partial class Form1
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
            this.tbHovaTen = new System.Windows.Forms.TextBox();
            this.lbHoVaTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoThich = new System.Windows.Forms.TextBox();
            this.lbSothich = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbHovaTen
            // 
            this.tbHovaTen.Location = new System.Drawing.Point(92, 12);
            this.tbHovaTen.Name = "tbHovaTen";
            this.tbHovaTen.Size = new System.Drawing.Size(200, 20);
            this.tbHovaTen.TabIndex = 0;
            // 
            // lbHoVaTen
            // 
            this.lbHoVaTen.AutoSize = true;
            this.lbHoVaTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoVaTen.Location = new System.Drawing.Point(12, 15);
            this.lbHoVaTen.Name = "lbHoVaTen";
            this.lbHoVaTen.Size = new System.Drawing.Size(50, 12);
            this.lbHoVaTen.TabIndex = 1;
            this.lbHoVaTen.Text = "Họ và Tên";
            this.lbHoVaTen.Click += new System.EventHandler(this.lbHoVaTen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm Sinh";
            // 
            // tbSoThich
            // 
            this.tbSoThich.Location = new System.Drawing.Point(92, 67);
            this.tbSoThich.Name = "tbSoThich";
            this.tbSoThich.Size = new System.Drawing.Size(200, 20);
            this.tbSoThich.TabIndex = 3;
            // 
            // lbSothich
            // 
            this.lbSothich.AutoSize = true;
            this.lbSothich.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSothich.Location = new System.Drawing.Point(12, 75);
            this.lbSothich.Name = "lbSothich";
            this.lbSothich.Size = new System.Drawing.Size(44, 12);
            this.lbSothich.TabIndex = 4;
            this.lbSothich.Text = "Sở Thích";
            this.lbSothich.Click += new System.EventHandler(this.lbSothich_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 41);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(1995, 11, 2, 0, 0, 0, 0);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(92, 93);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(66, 23);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(164, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 108);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 242);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbSothich);
            this.Controls.Add(this.tbSoThich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHoVaTen);
            this.Controls.Add(this.tbHovaTen);
            this.Name = "Form1";
            this.Text = "www.tamga.tk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHovaTen;
        private System.Windows.Forms.Label lbHoVaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoThich;
        private System.Windows.Forms.Label lbSothich;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox textBox1;
    }
}

