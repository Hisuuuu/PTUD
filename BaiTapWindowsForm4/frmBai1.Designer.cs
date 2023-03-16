namespace BaiTapWindowsForm4
{
    partial class frmBai1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbLoaiSP = new System.Windows.Forms.TextBox();
            this.tbNgaySX = new System.Windows.Forms.TextBox();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnHienThiThongTin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaSanPhamCanTim = new System.Windows.Forms.TextBox();
            this.btnXemNamHetHanSD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNamHetHan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sản xuất:";
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(115, 39);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(187, 20);
            this.tbMaSP.TabIndex = 4;
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(115, 80);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(187, 20);
            this.tbTenSP.TabIndex = 5;
            // 
            // tbLoaiSP
            // 
            this.tbLoaiSP.Location = new System.Drawing.Point(115, 129);
            this.tbLoaiSP.Name = "tbLoaiSP";
            this.tbLoaiSP.Size = new System.Drawing.Size(187, 20);
            this.tbLoaiSP.TabIndex = 6;
            // 
            // tbNgaySX
            // 
            this.tbNgaySX.Location = new System.Drawing.Point(115, 175);
            this.tbNgaySX.Name = "tbNgaySX";
            this.tbNgaySX.Size = new System.Drawing.Size(187, 20);
            this.tbNgaySX.TabIndex = 7;
            this.tbNgaySX.Text = "00/00/0000";
            this.tbNgaySX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(38, 222);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(264, 33);
            this.btnThemSanPham.TabIndex = 8;
            this.btnThemSanPham.Text = "Thêm sản phẩm vào danh sách";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnHienThiThongTin
            // 
            this.btnHienThiThongTin.Location = new System.Drawing.Point(357, 65);
            this.btnHienThiThongTin.Name = "btnHienThiThongTin";
            this.btnHienThiThongTin.Size = new System.Drawing.Size(308, 32);
            this.btnHienThiThongTin.TabIndex = 9;
            this.btnHienThiThongTin.Text = "Hiển thị thông tin sản phẩm theo mã sản phẩm";
            this.btnHienThiThongTin.UseVisualStyleBackColor = true;
            this.btnHienThiThongTin.Click += new System.EventHandler(this.btnHienThiThongTin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhập mã sản phẩm cần tìm";
            // 
            // tbMaSanPhamCanTim
            // 
            this.tbMaSanPhamCanTim.Location = new System.Drawing.Point(497, 36);
            this.tbMaSanPhamCanTim.Name = "tbMaSanPhamCanTim";
            this.tbMaSanPhamCanTim.Size = new System.Drawing.Size(168, 20);
            this.tbMaSanPhamCanTim.TabIndex = 11;
            // 
            // btnXemNamHetHanSD
            // 
            this.btnXemNamHetHanSD.Location = new System.Drawing.Point(357, 222);
            this.btnXemNamHetHanSD.Name = "btnXemNamHetHanSD";
            this.btnXemNamHetHanSD.Size = new System.Drawing.Size(308, 33);
            this.btnXemNamHetHanSD.TabIndex = 12;
            this.btnXemNamHetHanSD.Text = "Xem năm hết hạn sử dụng";
            this.btnXemNamHetHanSD.UseVisualStyleBackColor = true;
            this.btnXemNamHetHanSD.Click += new System.EventHandler(this.btnXemNamHetHanSD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Năm hết hạn:";
            // 
            // lblNamHetHan
            // 
            this.lblNamHetHan.AutoSize = true;
            this.lblNamHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHetHan.Location = new System.Drawing.Point(467, 178);
            this.lblNamHetHan.Name = "lblNamHetHan";
            this.lblNamHetHan.Size = new System.Drawing.Size(21, 20);
            this.lblNamHetHan.TabIndex = 14;
            this.lblNamHetHan.Text = "...";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 312);
            this.Controls.Add(this.lblNamHetHan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXemNamHetHanSD);
            this.Controls.Add(this.tbMaSanPhamCanTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHienThiThongTin);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.tbNgaySX);
            this.Controls.Add(this.tbLoaiSP);
            this.Controls.Add(this.tbTenSP);
            this.Controls.Add(this.tbMaSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbLoaiSP;
        private System.Windows.Forms.TextBox tbNgaySX;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnHienThiThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaSanPhamCanTim;
        private System.Windows.Forms.Button btnXemNamHetHanSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNamHetHan;
    }
}