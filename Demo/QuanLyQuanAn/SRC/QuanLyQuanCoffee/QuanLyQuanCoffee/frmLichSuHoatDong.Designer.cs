namespace QuanLyQuanCoffee
{
    partial class frmLichSuHoatDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuHoatDong));
            this.lsvLichSuHoatDong = new System.Windows.Forms.ListView();
            this.MaLichSu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoatDong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThoiGian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Xoa = new System.Windows.Forms.ToolStripButton();
            this.TSB_Thoat = new System.Windows.Forms.ToolStripButton();
            this.TSB_XoaTatCa = new System.Windows.Forms.ToolStripButton();
            this.TSCMB_HienThi = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvLichSuHoatDong
            // 
            this.lsvLichSuHoatDong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaLichSu,
            this.MaNV,
            this.HoTen,
            this.HoatDong,
            this.ThoiGian,
            this.TinhTrang});
            this.lsvLichSuHoatDong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvLichSuHoatDong.FullRowSelect = true;
            this.lsvLichSuHoatDong.GridLines = true;
            this.lsvLichSuHoatDong.Location = new System.Drawing.Point(0, 28);
            this.lsvLichSuHoatDong.Name = "lsvLichSuHoatDong";
            this.lsvLichSuHoatDong.Size = new System.Drawing.Size(922, 475);
            this.lsvLichSuHoatDong.TabIndex = 0;
            this.lsvLichSuHoatDong.UseCompatibleStateImageBehavior = false;
            this.lsvLichSuHoatDong.View = System.Windows.Forms.View.Details;
            // 
            // MaLichSu
            // 
            this.MaLichSu.Text = "Mã lịch sử";
            this.MaLichSu.Width = 90;
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã NV";
            this.MaNV.Width = 87;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 144;
            // 
            // HoatDong
            // 
            this.HoatDong.Text = "Hoạt động";
            this.HoatDong.Width = 368;
            // 
            // ThoiGian
            // 
            this.ThoiGian.Text = "Thời gian";
            this.ThoiGian.Width = 135;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Text = "Tình trạng";
            this.TinhTrang.Width = 92;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Xoa,
            this.TSB_Thoat,
            this.TSB_XoaTatCa,
            this.TSCMB_HienThi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
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
            // TSB_XoaTatCa
            // 
            this.TSB_XoaTatCa.Image = global::QuanLyQuanCoffee.Properties.Resources.bindingNavigatorDeleteItem_Image;
            this.TSB_XoaTatCa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_XoaTatCa.Name = "TSB_XoaTatCa";
            this.TSB_XoaTatCa.Size = new System.Drawing.Size(79, 22);
            this.TSB_XoaTatCa.Text = "Xóa tất cả";
            this.TSB_XoaTatCa.Click += new System.EventHandler(this.TSB_XoaTatCa_Click);
            // 
            // TSCMB_HienThi
            // 
            this.TSCMB_HienThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSCMB_HienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSCMB_HienThi.Items.AddRange(new object[] {
            "Cá nhân",
            "Tất cả"});
            this.TSCMB_HienThi.Name = "TSCMB_HienThi";
            this.TSCMB_HienThi.Size = new System.Drawing.Size(121, 25);
            this.TSCMB_HienThi.SelectedIndexChanged += new System.EventHandler(this.TSCMB_HienThi_SelectedIndexChanged);
            // 
            // frmLichSuHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 503);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lsvLichSuHoatDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLichSuHoatDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                                       Lịch sử hoạt động";
            this.Load += new System.EventHandler(this.frmLichSuHoatDong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvLichSuHoatDong;
        private System.Windows.Forms.ColumnHeader MaLichSu;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader HoatDong;
        private System.Windows.Forms.ColumnHeader ThoiGian;
        private System.Windows.Forms.ColumnHeader TinhTrang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Xoa;
        private System.Windows.Forms.ToolStripButton TSB_Thoat;
        private System.Windows.Forms.ToolStripButton TSB_XoaTatCa;
        private System.Windows.Forms.ToolStripComboBox TSCMB_HienThi;
    }
}