namespace QuanLyQuanCoffee
{
    partial class frmCaLamViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaLamViec));
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lsvCa = new System.Windows.Forms.ListView();
            this.MaCa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenCa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioBatDau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioKetThuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MucLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmMucLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmMucLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaCa
            // 
            this.txtMaCa.Enabled = false;
            this.txtMaCa.Location = new System.Drawing.Point(129, 4);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(251, 20);
            this.txtMaCa.TabIndex = 0;
            // 
            // txtTenCa
            // 
            this.txtTenCa.Location = new System.Drawing.Point(129, 30);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(251, 20);
            this.txtTenCa.TabIndex = 1;
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.CustomFormat = "";
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.Location = new System.Drawing.Point(129, 56);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(251, 20);
            this.dtpGioBatDau.TabIndex = 2;
            this.dtpGioBatDau.Value = new System.DateTime(2016, 7, 15, 10, 47, 0, 0);
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(129, 82);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(251, 20);
            this.dtpGioKetThuc.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(304, 132);
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
            this.btnThem.Location = new System.Drawing.Point(223, 132);
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
            this.btnLuu.Location = new System.Drawing.Point(142, 132);
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
            this.btnXoa.Location = new System.Drawing.Point(61, 132);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lsvCa
            // 
            this.lsvCa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaCa,
            this.TenCa,
            this.GioBatDau,
            this.GioKetThuc,
            this.MucLuong});
            this.lsvCa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvCa.FullRowSelect = true;
            this.lsvCa.GridLines = true;
            this.lsvCa.Location = new System.Drawing.Point(0, 176);
            this.lsvCa.MultiSelect = false;
            this.lsvCa.Name = "lsvCa";
            this.lsvCa.Size = new System.Drawing.Size(444, 175);
            this.lsvCa.TabIndex = 14;
            this.lsvCa.UseCompatibleStateImageBehavior = false;
            this.lsvCa.View = System.Windows.Forms.View.Details;
            this.lsvCa.SelectedIndexChanged += new System.EventHandler(this.lsvCa_SelectedIndexChanged);
            // 
            // MaCa
            // 
            this.MaCa.Text = "Mã ca";
            // 
            // TenCa
            // 
            this.TenCa.Text = "Tên ca";
            this.TenCa.Width = 81;
            // 
            // GioBatDau
            // 
            this.GioBatDau.Text = "Giờ bắt đầu";
            this.GioBatDau.Width = 88;
            // 
            // GioKetThuc
            // 
            this.GioKetThuc.Text = "Giờ kết thúc";
            this.GioKetThuc.Width = 82;
            // 
            // MucLuong
            // 
            this.MucLuong.Text = "Mức lương";
            this.MucLuong.Width = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên ca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giờ bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giờ kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mức lương:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Danh sách ca:";
            // 
            // nmMucLuong
            // 
            this.nmMucLuong.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmMucLuong.Location = new System.Drawing.Point(129, 106);
            this.nmMucLuong.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmMucLuong.Name = "nmMucLuong";
            this.nmMucLuong.Size = new System.Drawing.Size(251, 20);
            this.nmMucLuong.TabIndex = 21;
            this.nmMucLuong.ThousandsSeparator = true;
            // 
            // frmCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 351);
            this.Controls.Add(this.nmMucLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvCa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtpGioKetThuc);
            this.Controls.Add(this.dtpGioBatDau);
            this.Controls.Add(this.txtTenCa);
            this.Controls.Add(this.txtMaCa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCaLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                               Ca làm việc";
            this.Load += new System.EventHandler(this.frmCaLamViec_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCaLamViec_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nmMucLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lsvCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader MaCa;
        private System.Windows.Forms.ColumnHeader TenCa;
        private System.Windows.Forms.ColumnHeader GioBatDau;
        private System.Windows.Forms.ColumnHeader GioKetThuc;
        private System.Windows.Forms.ColumnHeader MucLuong;
        private System.Windows.Forms.NumericUpDown nmMucLuong;
    }
}