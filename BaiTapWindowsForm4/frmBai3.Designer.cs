namespace BaiTapWindowsForm4
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
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoM = new System.Windows.Forms.TextBox();
            this.tbSoN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnXuatThongBao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnTimUSCLN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(108, 36);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(178, 20);
            this.tbHoTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(63, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(7, 44);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(7, 20);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số nguyên m:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số nguyên n:";
            // 
            // tbSoM
            // 
            this.tbSoM.Location = new System.Drawing.Point(412, 32);
            this.tbSoM.Name = "tbSoM";
            this.tbSoM.Size = new System.Drawing.Size(144, 20);
            this.tbSoM.TabIndex = 5;
            // 
            // tbSoN
            // 
            this.tbSoN.Location = new System.Drawing.Point(412, 66);
            this.tbSoN.Name = "tbSoN";
            this.tbSoN.Size = new System.Drawing.Size(144, 20);
            this.tbSoN.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ước số chung lớn nhất:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(518, 110);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(23, 17);
            this.lblKetQua.TabIndex = 8;
            this.lblKetQua.Text = "...";
            // 
            // btnXuatThongBao
            // 
            this.btnXuatThongBao.Location = new System.Drawing.Point(60, 209);
            this.btnXuatThongBao.Name = "btnXuatThongBao";
            this.btnXuatThongBao.Size = new System.Drawing.Size(223, 23);
            this.btnXuatThongBao.TabIndex = 9;
            this.btnXuatThongBao.Text = "Xuất thông báo";
            this.btnXuatThongBao.UseVisualStyleBackColor = true;
            this.btnXuatThongBao.Click += new System.EventHandler(this.btnXuatThongBao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thông báo:";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(157, 173);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(23, 17);
            this.lblThongBao.TabIndex = 11;
            this.lblThongBao.Text = "...";
            // 
            // btnTimUSCLN
            // 
            this.btnTimUSCLN.Location = new System.Drawing.Point(339, 153);
            this.btnTimUSCLN.Name = "btnTimUSCLN";
            this.btnTimUSCLN.Size = new System.Drawing.Size(217, 23);
            this.btnTimUSCLN.TabIndex = 12;
            this.btnTimUSCLN.Text = "Tìm ước chung lớn nhất";
            this.btnTimUSCLN.UseVisualStyleBackColor = true;
            this.btnTimUSCLN.Click += new System.EventHandler(this.btnTimUSCLN_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 272);
            this.Controls.Add(this.btnTimUSCLN);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXuatThongBao);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSoN);
            this.Controls.Add(this.tbSoM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbHoTen);
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
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoM;
        private System.Windows.Forms.TextBox tbSoN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnXuatThongBao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnTimUSCLN;
    }
}