namespace QuanLyQuanCoffee
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.lsvMon = new System.Windows.Forms.ListView();
            this.MaMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lsvMonSapHet = new System.Windows.Forms.ListView();
            this.MaMon0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenMon0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsvMon
            // 
            this.lsvMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaMon,
            this.TenMon,
            this.DonGia,
            this.SoLuong,
            this.GiaNhap});
            this.lsvMon.FullRowSelect = true;
            this.lsvMon.GridLines = true;
            this.lsvMon.Location = new System.Drawing.Point(335, 32);
            this.lsvMon.MultiSelect = false;
            this.lsvMon.Name = "lsvMon";
            this.lsvMon.Size = new System.Drawing.Size(458, 443);
            this.lsvMon.TabIndex = 1;
            this.lsvMon.UseCompatibleStateImageBehavior = false;
            this.lsvMon.View = System.Windows.Forms.View.Details;
            this.lsvMon.SelectedIndexChanged += new System.EventHandler(this.lsvMon_SelectedIndexChanged);
            // 
            // MaMon
            // 
            this.MaMon.Text = "Mã món";
            this.MaMon.Width = 90;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            this.TenMon.Width = 141;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 72;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            // 
            // GiaNhap
            // 
            this.GiaNhap.Text = "Giá nhập";
            this.GiaNhap.Width = 72;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(387, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(406, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(84, 32);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.ReadOnly = true;
            this.txtMaMon.Size = new System.Drawing.Size(189, 20);
            this.txtMaMon.TabIndex = 4;
            this.txtMaMon.TextChanged += new System.EventHandler(this.txtMaMon_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(84, 84);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(189, 20);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(84, 110);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(153, 20);
            this.txtGiaNhap.TabIndex = 6;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Enabled = false;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Location = new System.Drawing.Point(279, 32);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(50, 98);
            this.btnNhap.TabIndex = 7;
            this.btnNhap.Text = ">>";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá nhập";
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(5, 136);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(324, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lsvMonSapHet
            // 
            this.lsvMonSapHet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaMon0,
            this.TenMon0,
            this.SoLuong0});
            this.lsvMonSapHet.FullRowSelect = true;
            this.lsvMonSapHet.GridLines = true;
            this.lsvMonSapHet.Location = new System.Drawing.Point(5, 178);
            this.lsvMonSapHet.MultiSelect = false;
            this.lsvMonSapHet.Name = "lsvMonSapHet";
            this.lsvMonSapHet.Size = new System.Drawing.Size(324, 297);
            this.lsvMonSapHet.TabIndex = 12;
            this.lsvMonSapHet.UseCompatibleStateImageBehavior = false;
            this.lsvMonSapHet.View = System.Windows.Forms.View.Details;
            this.lsvMonSapHet.SelectedIndexChanged += new System.EventHandler(this.lsvMonSapHet_SelectedIndexChanged);
            // 
            // MaMon0
            // 
            this.MaMon0.Text = "Mã món";
            this.MaMon0.Width = 69;
            // 
            // TenMon0
            // 
            this.TenMon0.Text = "Tên món";
            this.TenMon0.Width = 182;
            // 
            // SoLuong0
            // 
            this.SoLuong0.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Danh sách món sắp hết:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tên món";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(84, 58);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(189, 20);
            this.txtTenMon.TabIndex = 15;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsvMonSapHet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lsvMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                        Nhập hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNhapHang_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMon;
        private System.Windows.Forms.ColumnHeader MaMon;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader GiaNhap;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView lsvMonSapHet;
        private System.Windows.Forms.ColumnHeader MaMon0;
        private System.Windows.Forms.ColumnHeader TenMon0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader SoLuong0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenMon;
    }
}