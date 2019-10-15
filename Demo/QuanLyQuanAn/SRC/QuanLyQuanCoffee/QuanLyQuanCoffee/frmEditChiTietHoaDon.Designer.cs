namespace QuanLyQuanCoffee
{
    partial class frmEditChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditChiTietHoaDon));
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_CapNhat = new System.Windows.Forms.ToolStripButton();
            this.TSB_Xoa = new System.Windows.Forms.ToolStripButton();
            this.TSB_Thoat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(58, 50);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.ReadOnly = true;
            this.txtMaMon.Size = new System.Drawing.Size(242, 20);
            this.txtMaMon.TabIndex = 5;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(58, 75);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(242, 20);
            this.txtTenMon.TabIndex = 6;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(58, 127);
            this.nmSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(58, 20);
            this.nmSoLuong.TabIndex = 1;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmSoLuong_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(58, 153);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(242, 120);
            this.txtGhiChu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "CHỈNH SỬA MÓN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(58, 101);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(242, 20);
            this.txtDonGia.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_CapNhat,
            this.TSB_Xoa,
            this.TSB_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(314, 25);
            this.toolStrip1.TabIndex = 13;
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
            // frmEditChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 279);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.nmSoLuong);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEditChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_CapNhat;
        private System.Windows.Forms.ToolStripButton TSB_Xoa;
        private System.Windows.Forms.ToolStripButton TSB_Thoat;
    }
}