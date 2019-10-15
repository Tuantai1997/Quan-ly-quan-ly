namespace QuanLyQuanCoffee
{
    partial class frmEditHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditHoaDon));
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtPhuThu = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.rdbDaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdbChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_CapNhat = new System.Windows.Forms.ToolStripButton();
            this.TSB_Xoa = new System.Windows.Forms.ToolStripButton();
            this.TSB_Thoat = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TSB_InHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(75, 53);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(203, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(75, 79);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.ReadOnly = true;
            this.txtMaBan.Size = new System.Drawing.Size(203, 20);
            this.txtMaBan.TabIndex = 1;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(75, 105);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(203, 20);
            this.txtNhanVien.TabIndex = 2;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(75, 131);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(203, 20);
            this.txtNgayLap.TabIndex = 3;
            // 
            // txtPhuThu
            // 
            this.txtPhuThu.Location = new System.Drawing.Point(75, 157);
            this.txtPhuThu.Name = "txtPhuThu";
            this.txtPhuThu.Size = new System.Drawing.Size(203, 20);
            this.txtPhuThu.TabIndex = 4;
            this.txtPhuThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhuThu_KeyPress);
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(75, 183);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(203, 20);
            this.txtVAT.TabIndex = 5;
            this.txtVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVAT_KeyPress);
            // 
            // rdbDaThanhToan
            // 
            this.rdbDaThanhToan.AutoSize = true;
            this.rdbDaThanhToan.Enabled = false;
            this.rdbDaThanhToan.Location = new System.Drawing.Point(75, 209);
            this.rdbDaThanhToan.Name = "rdbDaThanhToan";
            this.rdbDaThanhToan.Size = new System.Drawing.Size(93, 17);
            this.rdbDaThanhToan.TabIndex = 6;
            this.rdbDaThanhToan.Text = "Đã thanh toán";
            this.rdbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdbChuaThanhToan
            // 
            this.rdbChuaThanhToan.AutoSize = true;
            this.rdbChuaThanhToan.Checked = true;
            this.rdbChuaThanhToan.Enabled = false;
            this.rdbChuaThanhToan.Location = new System.Drawing.Point(174, 209);
            this.rdbChuaThanhToan.Name = "rdbChuaThanhToan";
            this.rdbChuaThanhToan.Size = new System.Drawing.Size(104, 17);
            this.rdbChuaThanhToan.TabIndex = 7;
            this.rdbChuaThanhToan.TabStop = true;
            this.rdbChuaThanhToan.Text = "Chưa thanh toán";
            this.rdbChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_CapNhat,
            this.TSB_Xoa,
            this.TSB_Thoat,
            this.TSB_InHoaDon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(283, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_CapNhat
            // 
            this.TSB_CapNhat.Image = global::QuanLyQuanCoffee.Properties.Resources.edit;
            this.TSB_CapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CapNhat.Name = "TSB_CapNhat";
            this.TSB_CapNhat.Size = new System.Drawing.Size(75, 22);
            this.TSB_CapNhat.Text = "Cập nhật";
            this.TSB_CapNhat.Click += new System.EventHandler(this.TSB_CapNhat_Click);
            // 
            // TSB_Xoa
            // 
            this.TSB_Xoa.Image = global::QuanLyQuanCoffee.Properties.Resources.delete;
            this.TSB_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Xoa.Name = "TSB_Xoa";
            this.TSB_Xoa.Size = new System.Drawing.Size(47, 22);
            this.TSB_Xoa.Text = "Xóa";
            this.TSB_Xoa.Click += new System.EventHandler(this.TSB_Xoa_Click);
            // 
            // TSB_Thoat
            // 
            this.TSB_Thoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSB_Thoat.Image = global::QuanLyQuanCoffee.Properties.Resources.export;
            this.TSB_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Thoat.Name = "TSB_Thoat";
            this.TSB_Thoat.Size = new System.Drawing.Size(58, 22);
            this.TSB_Thoat.Text = "Thoát";
            this.TSB_Thoat.Click += new System.EventHandler(this.TSB_Thoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "CHỈNH SỬA HÓA ĐƠN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Phụ thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "VAT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tình trạng";
            // 
            // TSB_InHoaDon
            // 
            this.TSB_InHoaDon.Image = global::QuanLyQuanCoffee.Properties.Resources.register;
            this.TSB_InHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_InHoaDon.Name = "TSB_InHoaDon";
            this.TSB_InHoaDon.Size = new System.Drawing.Size(84, 20);
            this.TSB_InHoaDon.Text = "In hóa đơn";
            this.TSB_InHoaDon.Click += new System.EventHandler(this.TSB_InHoaDon_Click);
            // 
            // frmEditHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 230);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbChuaThanhToan);
            this.Controls.Add(this.rdbDaThanhToan);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtPhuThu);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.txtMaBan);
            this.Controls.Add(this.txtMaHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEditHoaDon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtPhuThu;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.RadioButton rdbDaThanhToan;
        private System.Windows.Forms.RadioButton rdbChuaThanhToan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_CapNhat;
        private System.Windows.Forms.ToolStripButton TSB_Xoa;
        private System.Windows.Forms.ToolStripButton TSB_Thoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton TSB_InHoaDon;
    }
}