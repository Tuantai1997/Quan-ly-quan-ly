namespace QuanLyQuanCoffee
{
    partial class frmDanhMucBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucBan));
            this.lsvBan = new System.Windows.Forms.ListView();
            this.MaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KhuVuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.rdbCoKhach = new System.Windows.Forms.RadioButton();
            this.rdbTrong = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbKhuVuc0 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvBan
            // 
            this.lsvBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaBan,
            this.KhuVuc,
            this.TenBan});
            this.lsvBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvBan.FullRowSelect = true;
            this.lsvBan.GridLines = true;
            this.lsvBan.Location = new System.Drawing.Point(0, 168);
            this.lsvBan.MultiSelect = false;
            this.lsvBan.Name = "lsvBan";
            this.lsvBan.Size = new System.Drawing.Size(328, 140);
            this.lsvBan.TabIndex = 0;
            this.lsvBan.UseCompatibleStateImageBehavior = false;
            this.lsvBan.View = System.Windows.Forms.View.Details;
            this.lsvBan.SelectedIndexChanged += new System.EventHandler(this.lsvBan_SelectedIndexChanged);
            // 
            // MaBan
            // 
            this.MaBan.Text = "Mã bàn";
            this.MaBan.Width = 87;
            // 
            // KhuVuc
            // 
            this.KhuVuc.Text = "Khu vực";
            this.KhuVuc.Width = 88;
            // 
            // TenBan
            // 
            this.TenBan.Text = "Tên bàn";
            this.TenBan.Width = 129;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Enabled = false;
            this.txtMaBan.Location = new System.Drawing.Point(51, 6);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(272, 20);
            this.txtMaBan.TabIndex = 1;
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhuVuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(51, 32);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(272, 21);
            this.cmbKhuVuc.TabIndex = 2;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(51, 59);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(272, 20);
            this.txtTenBan.TabIndex = 3;
            // 
            // rdbCoKhach
            // 
            this.rdbCoKhach.AutoSize = true;
            this.rdbCoKhach.Enabled = false;
            this.rdbCoKhach.Location = new System.Drawing.Point(92, 85);
            this.rdbCoKhach.Name = "rdbCoKhach";
            this.rdbCoKhach.Size = new System.Drawing.Size(71, 17);
            this.rdbCoKhach.TabIndex = 4;
            this.rdbCoKhach.Text = "Có khách";
            this.rdbCoKhach.UseVisualStyleBackColor = true;
            // 
            // rdbTrong
            // 
            this.rdbTrong.AutoSize = true;
            this.rdbTrong.Checked = true;
            this.rdbTrong.Enabled = false;
            this.rdbTrong.Location = new System.Drawing.Point(169, 85);
            this.rdbTrong.Name = "rdbTrong";
            this.rdbTrong.Size = new System.Drawing.Size(53, 17);
            this.rdbTrong.TabIndex = 5;
            this.rdbTrong.TabStop = true;
            this.rdbTrong.Text = "Trống";
            this.rdbTrong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(5, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(86, 108);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(167, 108);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(248, 108);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbKhuVuc0
            // 
            this.cmbKhuVuc0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhuVuc0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhuVuc0.FormattingEnabled = true;
            this.cmbKhuVuc0.Location = new System.Drawing.Point(86, 141);
            this.cmbKhuVuc0.Name = "cmbKhuVuc0";
            this.cmbKhuVuc0.Size = new System.Drawing.Size(237, 21);
            this.cmbKhuVuc0.TabIndex = 10;
            this.cmbKhuVuc0.SelectedIndexChanged += new System.EventHandler(this.cmbKhuVuc0_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã bàn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khu vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên bàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Danh sách bàn:";
            // 
            // frmDanhMucBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 308);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKhuVuc0);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.rdbTrong);
            this.Controls.Add(this.rdbCoKhach);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.cmbKhuVuc);
            this.Controls.Add(this.txtMaBan);
            this.Controls.Add(this.lsvBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDanhMucBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                       Danh mục bàn";
            this.Load += new System.EventHandler(this.frmDanhMucBan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDanhMucBan_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvBan;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.ComboBox cmbKhuVuc;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.RadioButton rdbCoKhach;
        private System.Windows.Forms.RadioButton rdbTrong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbKhuVuc0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader MaBan;
        private System.Windows.Forms.ColumnHeader KhuVuc;
        private System.Windows.Forms.ColumnHeader TenBan;
    }
}