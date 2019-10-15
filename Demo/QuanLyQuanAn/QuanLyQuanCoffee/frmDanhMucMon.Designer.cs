namespace QuanLyQuanCoffee
{
    partial class frmDanhMucMon
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
            this.lsvMon = new System.Windows.Forms.ListView();
            this.MaMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoaiMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.cmbLoaiMon = new System.Windows.Forms.ComboBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLoaiMon0 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvMon
            // 
            this.lsvMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaMon,
            this.LoaiMon,
            this.TenMon,
            this.SoLuong,
            this.DonGia,
            this.GiaNhap});
            this.lsvMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvMon.FullRowSelect = true;
            this.lsvMon.GridLines = true;
            this.lsvMon.Location = new System.Drawing.Point(0, 160);
            this.lsvMon.MultiSelect = false;
            this.lsvMon.Name = "lsvMon";
            this.lsvMon.Size = new System.Drawing.Size(974, 359);
            this.lsvMon.TabIndex = 0;
            this.lsvMon.UseCompatibleStateImageBehavior = false;
            this.lsvMon.View = System.Windows.Forms.View.Details;
            this.lsvMon.SelectedIndexChanged += new System.EventHandler(this.lsvMon_SelectedIndexChanged);
            // 
            // MaMon
            // 
            this.MaMon.Text = "Mã món";
            this.MaMon.Width = 126;
            // 
            // LoaiMon
            // 
            this.LoaiMon.Text = "Loại món";
            this.LoaiMon.Width = 150;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            this.TenMon.Width = 290;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.Width = 85;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 142;
            // 
            // GiaNhap
            // 
            this.GiaNhap.Text = "Giá nhập";
            this.GiaNhap.Width = 135;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Enabled = false;
            this.txtMaMon.Location = new System.Drawing.Point(275, 12);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(222, 20);
            this.txtMaMon.TabIndex = 3;
            // 
            // cmbLoaiMon
            // 
            this.cmbLoaiMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiMon.FormattingEnabled = true;
            this.cmbLoaiMon.Location = new System.Drawing.Point(275, 38);
            this.cmbLoaiMon.Name = "cmbLoaiMon";
            this.cmbLoaiMon.Size = new System.Drawing.Size(222, 21);
            this.cmbLoaiMon.TabIndex = 4;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(275, 65);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(222, 20);
            this.txtTenMon.TabIndex = 5;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(565, 12);
            this.nmSoLuong.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(184, 20);
            this.nmSoLuong.TabIndex = 6;
            this.nmSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmSoLuong_KeyPress);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(565, 38);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(184, 20);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.Text = "0";
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(565, 64);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(184, 20);
            this.txtGiaNhap.TabIndex = 8;
            this.txtGiaNhap.Text = "0";
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(593, 90);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(674, 90);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loại món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giá nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Danh mục món:";
            // 
            // cmbLoaiMon0
            // 
            this.cmbLoaiMon0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiMon0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiMon0.FormattingEnabled = true;
            this.cmbLoaiMon0.Location = new System.Drawing.Point(100, 133);
            this.cmbLoaiMon0.Name = "cmbLoaiMon0";
            this.cmbLoaiMon0.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiMon0.TabIndex = 18;
            this.cmbLoaiMon0.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiMon0_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(275, 90);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(222, 20);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(512, 90);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmDanhMucMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 519);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cmbLoaiMon0);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.nmSoLuong);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.cmbLoaiMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.lsvMon);
            this.KeyPreview = true;
            this.Name = "frmDanhMucMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhMucMon";
            this.Load += new System.EventHandler(this.frmDanhMucMon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDanhMucMon_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMon;
        private System.Windows.Forms.ColumnHeader MaMon;
        private System.Windows.Forms.ColumnHeader LoaiMon;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader GiaNhap;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.ComboBox cmbLoaiMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLoaiMon0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXoa;

    }
}