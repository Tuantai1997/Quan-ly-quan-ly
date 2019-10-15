namespace QuanLyQuanCoffee
{
    partial class frmQuanLyBanHang
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
            this.panell = new System.Windows.Forms.Panel();
            this.pnlBan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvChiTietHoaDon = new System.Windows.Forms.ListView();
            this.MaMon0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMon0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblThongTinBan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lsvMon = new System.Windows.Forms.ListView();
            this.MaMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbLoaiMon = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgayLapHD = new System.Windows.Forms.TextBox();
            this.btnInHoaDonXuongBep = new System.Windows.Forms.Button();
            this.lblBan = new System.Windows.Forms.Label();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnGopBan = new System.Windows.Forms.Button();
            this.btnDoiBan = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTraLai = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKhachDua = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtPhuThu = new System.Windows.Forms.TextBox();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.panell.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panell
            // 
            this.panell.AutoScroll = true;
            this.panell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panell.Controls.Add(this.pnlBan);
            this.panell.Controls.Add(this.label1);
            this.panell.Controls.Add(this.cmbKhuVuc);
            this.panell.Dock = System.Windows.Forms.DockStyle.Left;
            this.panell.Location = new System.Drawing.Point(0, 0);
            this.panell.Name = "panell";
            this.panell.Size = new System.Drawing.Size(300, 513);
            this.panell.TabIndex = 0;
            // 
            // pnlBan
            // 
            this.pnlBan.AutoScroll = true;
            this.pnlBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBan.Location = new System.Drawing.Point(0, 29);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(296, 480);
            this.pnlBan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khu vực";
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.BackColor = System.Drawing.Color.White;
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(89, 3);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(158, 21);
            this.cmbKhuVuc.TabIndex = 0;
            this.cmbKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cmbKhuVuc_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lsvChiTietHoaDon);
            this.panel2.Controls.Add(this.lblThongTinBan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(300, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 268);
            this.panel2.TabIndex = 2;
            // 
            // lsvChiTietHoaDon
            // 
            this.lsvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaMon0,
            this.TenMon0,
            this.DonGia0,
            this.SoLuong0,
            this.ThanhTien,
            this.GhiChu});
            this.lsvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvChiTietHoaDon.FullRowSelect = true;
            this.lsvChiTietHoaDon.GridLines = true;
            this.lsvChiTietHoaDon.Location = new System.Drawing.Point(0, 33);
            this.lsvChiTietHoaDon.MultiSelect = false;
            this.lsvChiTietHoaDon.Name = "lsvChiTietHoaDon";
            this.lsvChiTietHoaDon.Size = new System.Drawing.Size(666, 231);
            this.lsvChiTietHoaDon.TabIndex = 1;
            this.lsvChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvChiTietHoaDon.View = System.Windows.Forms.View.Details;
            this.lsvChiTietHoaDon.DoubleClick += new System.EventHandler(this.lsvChiTietHoaDon_DoubleClick);
            // 
            // MaMon0
            // 
            this.MaMon0.Text = "Mã món";
            this.MaMon0.Width = 92;
            // 
            // TenMon0
            // 
            this.TenMon0.Text = "Tên Món";
            this.TenMon0.Width = 182;
            // 
            // DonGia0
            // 
            this.DonGia0.Text = "Đơn giá";
            this.DonGia0.Width = 110;
            // 
            // SoLuong0
            // 
            this.SoLuong0.Text = "Số lượng";
            this.SoLuong0.Width = 69;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.Width = 110;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi chú";
            this.GhiChu.Width = 200;
            // 
            // lblThongTinBan
            // 
            this.lblThongTinBan.AutoSize = true;
            this.lblThongTinBan.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinBan.Location = new System.Drawing.Point(266, 8);
            this.lblThongTinBan.Name = "lblThongTinBan";
            this.lblThongTinBan.Size = new System.Drawing.Size(161, 22);
            this.lblThongTinBan.TabIndex = 0;
            this.lblThongTinBan.Text = "Thông tin bàn số ...";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lsvMon);
            this.panel3.Controls.Add(this.cmbLoaiMon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 245);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại món";
            // 
            // lsvMon
            // 
            this.lsvMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaMon,
            this.TenMon,
            this.DonGia,
            this.SoLuong,
            this.GiaNhap});
            this.lsvMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvMon.FullRowSelect = true;
            this.lsvMon.GridLines = true;
            this.lsvMon.Location = new System.Drawing.Point(0, 28);
            this.lsvMon.MultiSelect = false;
            this.lsvMon.Name = "lsvMon";
            this.lsvMon.Size = new System.Drawing.Size(384, 213);
            this.lsvMon.TabIndex = 0;
            this.lsvMon.UseCompatibleStateImageBehavior = false;
            this.lsvMon.View = System.Windows.Forms.View.Details;
            this.lsvMon.DoubleClick += new System.EventHandler(this.lsvMon_DoubleClick);
            // 
            // MaMon
            // 
            this.MaMon.Text = "Mã món";
            this.MaMon.Width = 93;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            this.TenMon.Width = 179;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 111;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            // 
            // GiaNhap
            // 
            this.GiaNhap.Text = "Giá nhập";
            this.GiaNhap.Width = 111;
            // 
            // cmbLoaiMon
            // 
            this.cmbLoaiMon.BackColor = System.Drawing.Color.White;
            this.cmbLoaiMon.FormattingEnabled = true;
            this.cmbLoaiMon.Location = new System.Drawing.Point(145, 6);
            this.cmbLoaiMon.Name = "cmbLoaiMon";
            this.cmbLoaiMon.Size = new System.Drawing.Size(158, 21);
            this.cmbLoaiMon.TabIndex = 2;
            this.cmbLoaiMon.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiMon_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNgayLapHD);
            this.panel1.Controls.Add(this.btnInHoaDonXuongBep);
            this.panel1.Controls.Add(this.lblBan);
            this.panel1.Controls.Add(this.btnHuyHoaDon);
            this.panel1.Controls.Add(this.btnGopBan);
            this.panel1.Controls.Add(this.btnDoiBan);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtTraLai);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtKhachDua);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtVAT);
            this.panel1.Controls.Add(this.txtPhuThu);
            this.panel1.Controls.Add(this.lblSoHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(688, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 245);
            this.panel1.TabIndex = 14;
            // 
            // txtNgayLapHD
            // 
            this.txtNgayLapHD.Enabled = false;
            this.txtNgayLapHD.Location = new System.Drawing.Point(73, 28);
            this.txtNgayLapHD.Name = "txtNgayLapHD";
            this.txtNgayLapHD.Size = new System.Drawing.Size(161, 20);
            this.txtNgayLapHD.TabIndex = 27;
            // 
            // btnInHoaDonXuongBep
            // 
            this.btnInHoaDonXuongBep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDonXuongBep.Location = new System.Drawing.Point(9, 213);
            this.btnInHoaDonXuongBep.Name = "btnInHoaDonXuongBep";
            this.btnInHoaDonXuongBep.Size = new System.Drawing.Size(128, 23);
            this.btnInHoaDonXuongBep.TabIndex = 26;
            this.btnInHoaDonXuongBep.Text = "In hóa đơn xuống bếp";
            this.btnInHoaDonXuongBep.UseVisualStyleBackColor = true;
            this.btnInHoaDonXuongBep.Click += new System.EventHandler(this.btnInHoaDonXuongBep_Click);
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBan.Location = new System.Drawing.Point(1, 3);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(54, 18);
            this.lblBan.TabIndex = 24;
            this.lblBan.Text = "Bàn ...";
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHoaDon.Location = new System.Drawing.Point(143, 213);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(126, 23);
            this.btnHuyHoaDon.TabIndex = 22;
            this.btnHuyHoaDon.Text = "Hủy hóa đơn";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyHoaDon_Click);
            // 
            // btnGopBan
            // 
            this.btnGopBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGopBan.Location = new System.Drawing.Point(194, 184);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(75, 23);
            this.btnGopBan.TabIndex = 21;
            this.btnGopBan.Text = "Gộp bàn";
            this.btnGopBan.UseVisualStyleBackColor = true;
            this.btnGopBan.Click += new System.EventHandler(this.btnGopBan_Click);
            // 
            // btnDoiBan
            // 
            this.btnDoiBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiBan.Location = new System.Drawing.Point(101, 184);
            this.btnDoiBan.Name = "btnDoiBan";
            this.btnDoiBan.Size = new System.Drawing.Size(75, 23);
            this.btnDoiBan.TabIndex = 20;
            this.btnDoiBan.Text = "Đổi bàn";
            this.btnDoiBan.UseVisualStyleBackColor = true;
            this.btnDoiBan.Click += new System.EventHandler(this.btnDoiBan_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Location = new System.Drawing.Point(9, 184);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 19;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(243, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "VNĐ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "Trả lại";
            // 
            // txtTraLai
            // 
            this.txtTraLai.Enabled = false;
            this.txtTraLai.Location = new System.Drawing.Point(73, 157);
            this.txtTraLai.Name = "txtTraLai";
            this.txtTraLai.Size = new System.Drawing.Size(161, 20);
            this.txtTraLai.TabIndex = 16;
            this.txtTraLai.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(243, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "VNĐ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Khách đưa";
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Location = new System.Drawing.Point(73, 131);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(161, 20);
            this.txtKhachDua.TabIndex = 13;
            this.txtKhachDua.Text = "0";
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_TextChanged);
            this.txtKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhachDua_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(243, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(243, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tổng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "VAT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Phụ thu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Ngày lập HĐ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(73, 105);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(161, 20);
            this.txtTongTien.TabIndex = 4;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(73, 79);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(161, 20);
            this.txtVAT.TabIndex = 3;
            this.txtVAT.Text = "0";
            this.txtVAT.TextChanged += new System.EventHandler(this.txtVAT_TextChanged);
            this.txtVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVAT_KeyPress);
            // 
            // txtPhuThu
            // 
            this.txtPhuThu.Location = new System.Drawing.Point(73, 53);
            this.txtPhuThu.Name = "txtPhuThu";
            this.txtPhuThu.Size = new System.Drawing.Size(161, 20);
            this.txtPhuThu.TabIndex = 2;
            this.txtPhuThu.Text = "0";
            this.txtPhuThu.TextChanged += new System.EventHandler(this.txtPhuThu_TextChanged);
            this.txtPhuThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhuThu_KeyPress);
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Location = new System.Drawing.Point(112, 3);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(75, 13);
            this.lblSoHoaDon.TabIndex = 1;
            this.lblSoHoaDon.Text = "--Số hóa đơn--";
            // 
            // frmQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panell);
            this.KeyPreview = true;
            this.Name = "frmQuanLyBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmQuanLyBanHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQuanLyBanHang_KeyDown);
            this.panell.ResumeLayout(false);
            this.panell.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhuVuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvChiTietHoaDon;
        private System.Windows.Forms.ColumnHeader MaMon0;
        private System.Windows.Forms.ColumnHeader TenMon0;
        private System.Windows.Forms.ColumnHeader DonGia0;
        private System.Windows.Forms.ColumnHeader SoLuong0;
        private System.Windows.Forms.Label lblThongTinBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvMon;
        private System.Windows.Forms.ColumnHeader MaMon;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ComboBox cmbLoaiMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnGopBan;
        private System.Windows.Forms.Button btnDoiBan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTraLai;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKhachDua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtPhuThu;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Panel pnlBan;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.ColumnHeader GiaNhap;
        private System.Windows.Forms.Button btnInHoaDonXuongBep;
        private System.Windows.Forms.TextBox txtNgayLapHD;
    }
}

