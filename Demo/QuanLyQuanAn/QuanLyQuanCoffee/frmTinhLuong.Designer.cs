namespace QuanLyQuanCoffee
{
    partial class frmTinhLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhLuong));
            this.lsvChamCong = new System.Windows.Forms.ListView();
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaLamViec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KhuVuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoBuoiLam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Luong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Xoa = new System.Windows.Forms.ToolStripButton();
            this.TSB_Thoat = new System.Windows.Forms.ToolStripButton();
            this.TSC_Thang = new System.Windows.Forms.ToolStripComboBox();
            this.TSC_Nam = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvChamCong
            // 
            this.lsvChamCong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNV,
            this.HoTen,
            this.CaLamViec,
            this.KhuVuc,
            this.SoBuoiLam,
            this.Luong});
            this.lsvChamCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvChamCong.FullRowSelect = true;
            this.lsvChamCong.GridLines = true;
            this.lsvChamCong.Location = new System.Drawing.Point(0, 28);
            this.lsvChamCong.MultiSelect = false;
            this.lsvChamCong.Name = "lsvChamCong";
            this.lsvChamCong.Size = new System.Drawing.Size(728, 306);
            this.lsvChamCong.TabIndex = 0;
            this.lsvChamCong.UseCompatibleStateImageBehavior = false;
            this.lsvChamCong.View = System.Windows.Forms.View.Details;
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã nhân viên";
            this.MaNV.Width = 78;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 166;
            // 
            // CaLamViec
            // 
            this.CaLamViec.Text = "Ca làm việc";
            this.CaLamViec.Width = 136;
            // 
            // KhuVuc
            // 
            this.KhuVuc.Text = "Khu vực";
            this.KhuVuc.Width = 131;
            // 
            // SoBuoiLam
            // 
            this.SoBuoiLam.Text = "Số buổi làm";
            this.SoBuoiLam.Width = 71;
            // 
            // Luong
            // 
            this.Luong.Text = "Lương";
            this.Luong.Width = 141;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Xoa,
            this.TSB_Thoat,
            this.TSC_Thang,
            this.TSC_Nam});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 25);
            this.toolStrip1.TabIndex = 16;
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
            // TSC_Thang
            // 
            this.TSC_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSC_Thang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSC_Thang.Name = "TSC_Thang";
            this.TSC_Thang.Size = new System.Drawing.Size(121, 25);
            this.TSC_Thang.SelectedIndexChanged += new System.EventHandler(this.TSC_Thang_SelectedIndexChanged);
            // 
            // TSC_Nam
            // 
            this.TSC_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSC_Nam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSC_Nam.Name = "TSC_Nam";
            this.TSC_Nam.Size = new System.Drawing.Size(121, 25);
            this.TSC_Nam.SelectedIndexChanged += new System.EventHandler(this.TSC_Nam_SelectedIndexChanged);
            // 
            // frmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 334);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lsvChamCong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng chấm công";
            this.Load += new System.EventHandler(this.frmBangChamCong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvChamCong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Xoa;
        private System.Windows.Forms.ToolStripButton TSB_Thoat;
        private System.Windows.Forms.ToolStripComboBox TSC_Thang;
        private System.Windows.Forms.ToolStripComboBox TSC_Nam;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader CaLamViec;
        private System.Windows.Forms.ColumnHeader SoBuoiLam;
        private System.Windows.Forms.ColumnHeader Luong;
        private System.Windows.Forms.ColumnHeader KhuVuc;
    }
}