namespace QuanLyQuanCoffee
{
    partial class frmDanhMucLoaiMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucLoaiMon));
            this.lsvLoaiMon = new System.Windows.Forms.ListView();
            this.MaLoaiMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenLoaiMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaLoaiMon = new System.Windows.Forms.TextBox();
            this.txtTenLoaiMon = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvLoaiMon
            // 
            this.lsvLoaiMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaLoaiMon,
            this.TenLoaiMon});
            this.lsvLoaiMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvLoaiMon.FullRowSelect = true;
            this.lsvLoaiMon.GridLines = true;
            this.lsvLoaiMon.Location = new System.Drawing.Point(0, 113);
            this.lsvLoaiMon.MultiSelect = false;
            this.lsvLoaiMon.Name = "lsvLoaiMon";
            this.lsvLoaiMon.Size = new System.Drawing.Size(329, 158);
            this.lsvLoaiMon.TabIndex = 0;
            this.lsvLoaiMon.UseCompatibleStateImageBehavior = false;
            this.lsvLoaiMon.View = System.Windows.Forms.View.Details;
            this.lsvLoaiMon.SelectedIndexChanged += new System.EventHandler(this.lsvLoaiMon_SelectedIndexChanged);
            // 
            // MaLoaiMon
            // 
            this.MaLoaiMon.Text = "Mã loại món";
            this.MaLoaiMon.Width = 102;
            // 
            // TenLoaiMon
            // 
            this.TenLoaiMon.Text = "Tên loại món";
            this.TenLoaiMon.Width = 200;
            // 
            // txtMaLoaiMon
            // 
            this.txtMaLoaiMon.Enabled = false;
            this.txtMaLoaiMon.Location = new System.Drawing.Point(73, 6);
            this.txtMaLoaiMon.Name = "txtMaLoaiMon";
            this.txtMaLoaiMon.Size = new System.Drawing.Size(250, 20);
            this.txtMaLoaiMon.TabIndex = 1;
            // 
            // txtTenLoaiMon
            // 
            this.txtTenLoaiMon.Location = new System.Drawing.Point(73, 32);
            this.txtTenLoaiMon.Name = "txtTenLoaiMon";
            this.txtTenLoaiMon.Size = new System.Drawing.Size(250, 20);
            this.txtTenLoaiMon.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(6, 58);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(87, 58);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(168, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã loại món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên loại món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách loại món:";
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(248, 58);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDanhMucLoaiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 271);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTenLoaiMon);
            this.Controls.Add(this.txtMaLoaiMon);
            this.Controls.Add(this.lsvLoaiMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDanhMucLoaiMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                   Danh mục loại món";
            this.Load += new System.EventHandler(this.frmDanhMucLoaiMon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDanhMucLoaiMon_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvLoaiMon;
        private System.Windows.Forms.ColumnHeader MaLoaiMon;
        private System.Windows.Forms.ColumnHeader TenLoaiMon;
        private System.Windows.Forms.TextBox txtMaLoaiMon;
        private System.Windows.Forms.TextBox txtTenLoaiMon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
    }
}