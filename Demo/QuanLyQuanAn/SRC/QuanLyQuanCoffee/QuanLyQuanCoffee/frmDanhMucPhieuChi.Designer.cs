namespace QuanLyQuanCoffee
{
    partial class frmDanhMucPhieuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucPhieuChi));
            this.lsvPhieuChi = new System.Windows.Forms.ListView();
            this.MaPhieuChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MucDichChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtMucDich = new System.Windows.Forms.TextBox();
            this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.nmTongTien = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvPhieuChi
            // 
            this.lsvPhieuChi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhieuChi,
            this.MaNV,
            this.HoTen,
            this.MucDichChi,
            this.TongTien,
            this.NgayChi});
            this.lsvPhieuChi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvPhieuChi.FullRowSelect = true;
            this.lsvPhieuChi.GridLines = true;
            this.lsvPhieuChi.Location = new System.Drawing.Point(0, 166);
            this.lsvPhieuChi.MultiSelect = false;
            this.lsvPhieuChi.Name = "lsvPhieuChi";
            this.lsvPhieuChi.Size = new System.Drawing.Size(586, 158);
            this.lsvPhieuChi.TabIndex = 0;
            this.lsvPhieuChi.UseCompatibleStateImageBehavior = false;
            this.lsvPhieuChi.View = System.Windows.Forms.View.Details;
            this.lsvPhieuChi.SelectedIndexChanged += new System.EventHandler(this.lsvPhieuChi_SelectedIndexChanged);
            // 
            // MaPhieuChi
            // 
            this.MaPhieuChi.Text = "Mã phiếu";
            this.MaPhieuChi.Width = 89;
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã NV";
            this.MaNV.Width = 92;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 196;
            // 
            // MucDichChi
            // 
            this.MucDichChi.Text = "Mục đích chi";
            this.MucDichChi.Width = 207;
            // 
            // TongTien
            // 
            this.TongTien.Text = "Tổng tiền";
            this.TongTien.Width = 111;
            // 
            // NgayChi
            // 
            this.NgayChi.Text = "Ngày chi";
            this.NgayChi.Width = 107;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Location = new System.Drawing.Point(212, 12);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(200, 20);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // txtMucDich
            // 
            this.txtMucDich.Location = new System.Drawing.Point(212, 38);
            this.txtMucDich.Name = "txtMucDich";
            this.txtMucDich.Size = new System.Drawing.Size(200, 20);
            this.txtMucDich.TabIndex = 2;
            // 
            // dtpNgayChi
            // 
            this.dtpNgayChi.Enabled = false;
            this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChi.Location = new System.Drawing.Point(212, 90);
            this.dtpNgayChi.Name = "dtpNgayChi";
            this.dtpNgayChi.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayChi.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(374, 115);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(293, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(212, 115);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(131, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mục đích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày chi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Danh sách phiếu chi:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(118, 144);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(344, 20);
            this.txtTimKiem.TabIndex = 20;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // nmTongTien
            // 
            this.nmTongTien.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmTongTien.Location = new System.Drawing.Point(212, 64);
            this.nmTongTien.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmTongTien.Name = "nmTongTien";
            this.nmTongTien.Size = new System.Drawing.Size(200, 20);
            this.nmTongTien.TabIndex = 21;
            this.nmTongTien.ThousandsSeparator = true;
            // 
            // frmDanhMucPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 324);
            this.Controls.Add(this.nmTongTien);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtpNgayChi);
            this.Controls.Add(this.txtMucDich);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.lsvPhieuChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDanhMucPhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                             Danh" +
    " mục phiếu chi";
            this.Load += new System.EventHandler(this.frmDanhMucPhieuChi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDanhMucPhieuChi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nmTongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvPhieuChi;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtMucDich;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private System.Windows.Forms.ColumnHeader MaPhieuChi;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader MucDichChi;
        private System.Windows.Forms.ColumnHeader TongTien;
        private System.Windows.Forms.ColumnHeader NgayChi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.NumericUpDown nmTongTien;
    }
}