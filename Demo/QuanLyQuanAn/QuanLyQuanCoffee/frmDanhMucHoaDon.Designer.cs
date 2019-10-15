namespace QuanLyQuanCoffee
{
    partial class frmDanhMucHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucHoaDon));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHoaDon = new System.Windows.Forms.ComboBox();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.MaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayLap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhuThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvChiTietHoaDon = new System.Windows.Forms.ListView();
            this.MaHD0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTriGiaHD = new System.Windows.Forms.Label();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách chi tiết hóa đơn:";
            // 
            // cmbHoaDon
            // 
            this.cmbHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHoaDon.FormattingEnabled = true;
            this.cmbHoaDon.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cmbHoaDon.Location = new System.Drawing.Point(111, 4);
            this.cmbHoaDon.Name = "cmbHoaDon";
            this.cmbHoaDon.Size = new System.Drawing.Size(118, 21);
            this.cmbHoaDon.TabIndex = 5;
            this.cmbHoaDon.SelectedIndexChanged += new System.EventHandler(this.cmbHoaDon_SelectedIndexChanged);
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHD,
            this.Ban,
            this.NhanVien,
            this.NgayLap,
            this.PhuThu,
            this.VAT,
            this.TinhTrang});
            this.lsvHoaDon.FullRowSelect = true;
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.Location = new System.Drawing.Point(0, 31);
            this.lsvHoaDon.MultiSelect = false;
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(654, 227);
            this.lsvHoaDon.TabIndex = 6;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            this.lsvHoaDon.SelectedIndexChanged += new System.EventHandler(this.lsvHoaDon_SelectedIndexChanged);
            this.lsvHoaDon.DoubleClick += new System.EventHandler(this.lsvHoaDon_DoubleClick);
            // 
            // MaHD
            // 
            this.MaHD.Text = "Mã hóa đơn";
            this.MaHD.Width = 72;
            // 
            // Ban
            // 
            this.Ban.Text = "Bàn";
            this.Ban.Width = 77;
            // 
            // NhanVien
            // 
            this.NhanVien.Text = "Nhân viên";
            this.NhanVien.Width = 143;
            // 
            // NgayLap
            // 
            this.NgayLap.Text = "Ngày lập";
            this.NgayLap.Width = 99;
            // 
            // PhuThu
            // 
            this.PhuThu.Text = "Phụ thu";
            this.PhuThu.Width = 89;
            // 
            // VAT
            // 
            this.VAT.Text = "VAT";
            // 
            // TinhTrang
            // 
            this.TinhTrang.Text = "Tình trạng";
            this.TinhTrang.Width = 108;
            // 
            // lsvChiTietHoaDon
            // 
            this.lsvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHD0,
            this.MaMon,
            this.TenMon,
            this.DonGia,
            this.SoLuong,
            this.GhiChu});
            this.lsvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvChiTietHoaDon.FullRowSelect = true;
            this.lsvChiTietHoaDon.GridLines = true;
            this.lsvChiTietHoaDon.Location = new System.Drawing.Point(0, 277);
            this.lsvChiTietHoaDon.MultiSelect = false;
            this.lsvChiTietHoaDon.Name = "lsvChiTietHoaDon";
            this.lsvChiTietHoaDon.Size = new System.Drawing.Size(654, 242);
            this.lsvChiTietHoaDon.TabIndex = 7;
            this.lsvChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvChiTietHoaDon.View = System.Windows.Forms.View.Details;
            this.lsvChiTietHoaDon.DoubleClick += new System.EventHandler(this.lsvChiTietHoaDon_DoubleClick);
            // 
            // MaHD0
            // 
            this.MaHD0.Text = "Mã hóa đơn";
            this.MaHD0.Width = 73;
            // 
            // MaMon
            // 
            this.MaMon.Text = "Mã món";
            this.MaMon.Width = 79;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            this.TenMon.Width = 147;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 92;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi chú";
            this.GhiChu.Width = 194;
            // 
            // lblTriGiaHD
            // 
            this.lblTriGiaHD.AutoSize = true;
            this.lblTriGiaHD.Location = new System.Drawing.Point(427, 7);
            this.lblTriGiaHD.Name = "lblTriGiaHD";
            this.lblTriGiaHD.Size = new System.Drawing.Size(117, 13);
            this.lblTriGiaHD.TabIndex = 8;
            this.lblTriGiaHD.Text = "Trị giá hóa đơn: 0 VNĐ";
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(573, 7);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(81, 13);
            this.lblSoHD.TabIndex = 9;
            this.lblSoHD.Text = "-- Số hóa đơn --";
            this.lblSoHD.TextChanged += new System.EventHandler(this.lblSoHD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Năm";
            // 
            // cmbThang
            // 
            this.cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(272, 4);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(41, 21);
            this.cmbThang.TabIndex = 12;
            this.cmbThang.SelectedIndexChanged += new System.EventHandler(this.cmbThang_SelectedIndexChanged);
            // 
            // cmbNam
            // 
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(351, 4);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(58, 21);
            this.cmbNam.TabIndex = 13;
            this.cmbNam.SelectedIndexChanged += new System.EventHandler(this.cmbNam_SelectedIndexChanged);
            // 
            // frmDanhMucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 519);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.lblTriGiaHD);
            this.Controls.Add(this.lsvChiTietHoaDon);
            this.Controls.Add(this.lsvHoaDon);
            this.Controls.Add(this.cmbHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDanhMucHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "       Danh mục hóa đơn";
            this.Load += new System.EventHandler(this.frmDanhMucHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHoaDon;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader MaHD;
        private System.Windows.Forms.ColumnHeader Ban;
        private System.Windows.Forms.ColumnHeader NhanVien;
        private System.Windows.Forms.ColumnHeader NgayLap;
        private System.Windows.Forms.ColumnHeader PhuThu;
        private System.Windows.Forms.ColumnHeader VAT;
        private System.Windows.Forms.ColumnHeader TinhTrang;
        private System.Windows.Forms.ListView lsvChiTietHoaDon;
        private System.Windows.Forms.ColumnHeader MaHD0;
        private System.Windows.Forms.ColumnHeader MaMon;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.Label lblTriGiaHD;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.ComboBox cmbNam;
    }
}