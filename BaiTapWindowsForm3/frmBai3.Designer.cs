namespace BaiTapWindowsForm3
{
    partial class frmBai3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHoVaTen = new System.Windows.Forms.TextBox();
            this.tbSoN1 = new System.Windows.Forms.TextBox();
            this.tbSoN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdKiemTraHaiSoNguyenCoLienTiep = new System.Windows.Forms.RadioButton();
            this.rdTachHoTen = new System.Windows.Forms.RadioButton();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số nguyên n1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số nguyên n2:";
            // 
            // tbHoVaTen
            // 
            this.tbHoVaTen.Location = new System.Drawing.Point(141, 51);
            this.tbHoVaTen.Name = "tbHoVaTen";
            this.tbHoVaTen.Size = new System.Drawing.Size(163, 20);
            this.tbHoVaTen.TabIndex = 4;
            // 
            // tbSoN1
            // 
            this.tbSoN1.Location = new System.Drawing.Point(141, 85);
            this.tbSoN1.Name = "tbSoN1";
            this.tbSoN1.Size = new System.Drawing.Size(163, 20);
            this.tbSoN1.TabIndex = 5;
            // 
            // tbSoN2
            // 
            this.tbSoN2.Location = new System.Drawing.Point(141, 124);
            this.tbSoN2.Name = "tbSoN2";
            this.tbSoN2.Size = new System.Drawing.Size(163, 20);
            this.tbSoN2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kết quả:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdKiemTraHaiSoNguyenCoLienTiep);
            this.groupBox1.Controls.Add(this.rdTachHoTen);
            this.groupBox1.Location = new System.Drawing.Point(51, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdKiemTraHaiSoNguyenCoLienTiep
            // 
            this.rdKiemTraHaiSoNguyenCoLienTiep.AutoSize = true;
            this.rdKiemTraHaiSoNguyenCoLienTiep.Location = new System.Drawing.Point(6, 63);
            this.rdKiemTraHaiSoNguyenCoLienTiep.Name = "rdKiemTraHaiSoNguyenCoLienTiep";
            this.rdKiemTraHaiSoNguyenCoLienTiep.Size = new System.Drawing.Size(219, 17);
            this.rdKiemTraHaiSoNguyenCoLienTiep.TabIndex = 1;
            this.rdKiemTraHaiSoNguyenCoLienTiep.TabStop = true;
            this.rdKiemTraHaiSoNguyenCoLienTiep.Text = "Kiểm tra hai số nguyên có liên tiếp không";
            this.rdKiemTraHaiSoNguyenCoLienTiep.UseVisualStyleBackColor = true;
            // 
            // rdTachHoTen
            // 
            this.rdTachHoTen.AutoSize = true;
            this.rdTachHoTen.Checked = true;
            this.rdTachHoTen.Location = new System.Drawing.Point(6, 28);
            this.rdTachHoTen.Name = "rdTachHoTen";
            this.rdTachHoTen.Size = new System.Drawing.Size(83, 17);
            this.rdTachHoTen.TabIndex = 0;
            this.rdTachHoTen.TabStop = true;
            this.rdTachHoTen.Text = "Tách họ tên";
            this.rdTachHoTen.UseVisualStyleBackColor = true;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(136, 410);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(20, 17);
            this.lbKetQua.TabIndex = 9;
            this.lbKetQua.Text = "...";
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(49, 451);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnXemKetQua.TabIndex = 10;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Họ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên:";
            // 
            // tbHo
            // 
            this.tbHo.Location = new System.Drawing.Point(97, 332);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(207, 20);
            this.tbHo.TabIndex = 13;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(97, 369);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(207, 20);
            this.tbTen.TabIndex = 14;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 536);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbHo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSoN2);
            this.Controls.Add(this.tbSoN1);
            this.Controls.Add(this.tbHoVaTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHoVaTen;
        private System.Windows.Forms.TextBox tbSoN1;
        private System.Windows.Forms.TextBox tbSoN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.RadioButton rdKiemTraHaiSoNguyenCoLienTiep;
        private System.Windows.Forms.RadioButton rdTachHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.TextBox tbTen;
    }
}