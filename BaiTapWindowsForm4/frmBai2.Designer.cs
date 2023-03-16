namespace BaiTapWindowsForm4
{
    partial class frmBai2
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
            this.tbDiemLyThuyet = new System.Windows.Forms.TextBox();
            this.tbDiemThucHanh = new System.Windows.Forms.TextBox();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQuaXepLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm lý thuyết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập điểm thực hành:";
            // 
            // tbDiemLyThuyet
            // 
            this.tbDiemLyThuyet.Location = new System.Drawing.Point(140, 45);
            this.tbDiemLyThuyet.Name = "tbDiemLyThuyet";
            this.tbDiemLyThuyet.Size = new System.Drawing.Size(138, 20);
            this.tbDiemLyThuyet.TabIndex = 2;
            // 
            // tbDiemThucHanh
            // 
            this.tbDiemThucHanh.Location = new System.Drawing.Point(140, 85);
            this.tbDiemThucHanh.Name = "tbDiemThucHanh";
            this.tbDiemThucHanh.Size = new System.Drawing.Size(138, 20);
            this.tbDiemThucHanh.TabIndex = 3;
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXepLoai.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnXepLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXepLoai.Location = new System.Drawing.Point(140, 128);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(138, 23);
            this.btnXepLoai.TabIndex = 4;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = false;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả xếp loại:";
            // 
            // lblKetQuaXepLoai
            // 
            this.lblKetQuaXepLoai.AutoSize = true;
            this.lblKetQuaXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaXepLoai.ForeColor = System.Drawing.Color.Red;
            this.lblKetQuaXepLoai.Location = new System.Drawing.Point(195, 187);
            this.lblKetQuaXepLoai.Name = "lblKetQuaXepLoai";
            this.lblKetQuaXepLoai.Size = new System.Drawing.Size(24, 20);
            this.lblKetQuaXepLoai.TabIndex = 6;
            this.lblKetQuaXepLoai.Text = "...";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 246);
            this.Controls.Add(this.lblKetQuaXepLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.tbDiemThucHanh);
            this.Controls.Add(this.tbDiemLyThuyet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDiemLyThuyet;
        private System.Windows.Forms.TextBox tbDiemThucHanh;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQuaXepLoai;
    }
}