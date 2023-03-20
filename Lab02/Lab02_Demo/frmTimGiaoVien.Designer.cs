namespace Lab02_Demo
{
    partial class frmTimGiaoVien
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
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.lblTimTheo = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Checked = true;
            this.rdMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaGV.Location = new System.Drawing.Point(25, 32);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(58, 17);
            this.rdMaGV.TabIndex = 0;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            this.rdMaGV.CheckedChanged += new System.EventHandler(this.rdMaGV_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSoDT);
            this.groupBox1.Controls.Add(this.rdTen);
            this.groupBox1.Controls.Add(this.rdMaGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSoDT.Location = new System.Drawing.Point(207, 32);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(88, 17);
            this.rdSoDT.TabIndex = 0;
            this.rdSoDT.TabStop = true;
            this.rdSoDT.Text = "Số điện thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            this.rdSoDT.CheckedChanged += new System.EventHandler(this.rdSoDT_CheckedChanged);
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTen.Location = new System.Drawing.Point(116, 32);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(44, 17);
            this.rdTen.TabIndex = 0;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Tên";
            this.rdTen.UseVisualStyleBackColor = true;
            this.rdTen.CheckedChanged += new System.EventHandler(this.rdTen_CheckedChanged);
            // 
            // lblTimTheo
            // 
            this.lblTimTheo.AutoSize = true;
            this.lblTimTheo.Location = new System.Drawing.Point(60, 127);
            this.lblTimTheo.Name = "lblTimTheo";
            this.lblTimTheo.Size = new System.Drawing.Size(40, 13);
            this.lblTimTheo.TabIndex = 1;
            this.lblTimTheo.Text = "Mã GV";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(128, 123);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(135, 20);
            this.txtTim.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(291, 122);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmTimGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 208);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lblTimTheo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimGiaoVien";
            this.Text = "frmTimGiaoVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.Label lblTimTheo;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnOK;
    }
}