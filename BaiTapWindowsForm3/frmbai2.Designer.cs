namespace BaiTapWindowsForm3
{
    partial class frmbai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhNGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdTinhTong = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.tbSoN = new System.Windows.Forms.TextBox();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một số nguyên dương N:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhNGiaiThua);
            this.groupBox1.Controls.Add(this.rdTinhTong);
            this.groupBox1.Location = new System.Drawing.Point(207, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc:";
            // 
            // rdTinhNGiaiThua
            // 
            this.rdTinhNGiaiThua.AutoSize = true;
            this.rdTinhNGiaiThua.Location = new System.Drawing.Point(7, 66);
            this.rdTinhNGiaiThua.Name = "rdTinhNGiaiThua";
            this.rdTinhNGiaiThua.Size = new System.Drawing.Size(122, 17);
            this.rdTinhNGiaiThua.TabIndex = 1;
            this.rdTinhNGiaiThua.TabStop = true;
            this.rdTinhNGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdTinhNGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdTinhTong
            // 
            this.rdTinhTong.AutoSize = true;
            this.rdTinhTong.Location = new System.Drawing.Point(7, 31);
            this.rdTinhTong.Name = "rdTinhTong";
            this.rdTinhTong.Size = new System.Drawing.Size(122, 17);
            this.rdTinhTong.TabIndex = 0;
            this.rdTinhTong.TabStop = true;
            this.rdTinhTong.Text = "Tính tổng 1+2+...+N";
            this.rdTinhTong.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả là:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(297, 219);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(23, 17);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "...";
            // 
            // tbSoN
            // 
            this.tbSoN.Location = new System.Drawing.Point(225, 21);
            this.tbSoN.Name = "tbSoN";
            this.tbSoN.Size = new System.Drawing.Size(138, 20);
            this.tbSoN.TabIndex = 4;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXemKetQua.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnXemKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.Location = new System.Drawing.Point(225, 168);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(112, 29);
            this.btnXemKetQua.TabIndex = 5;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = false;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // frmbai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 257);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.tbSoN);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmbai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhNGiaiThua;
        private System.Windows.Forms.RadioButton rdTinhTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox tbSoN;
        private System.Windows.Forms.Button btnXemKetQua;
    }
}