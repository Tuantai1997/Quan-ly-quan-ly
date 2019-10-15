namespace QuanLyQuanCoffee
{
    partial class frmPhanCong
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
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lsvPhanCong = new System.Windows.Forms.ListView();
            this.KhuVuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioBatDau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioKetThuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.cmbCa = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNhanVien.Location = new System.Drawing.Point(0, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(426, 23);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "lblNhanVien";
            this.lblNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvPhanCong
            // 
            this.lsvPhanCong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KhuVuc,
            this.Ca,
            this.GioBatDau,
            this.GioKetThuc});
            this.lsvPhanCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvPhanCong.FullRowSelect = true;
            this.lsvPhanCong.GridLines = true;
            this.lsvPhanCong.Location = new System.Drawing.Point(0, 93);
            this.lsvPhanCong.MultiSelect = false;
            this.lsvPhanCong.Name = "lsvPhanCong";
            this.lsvPhanCong.Size = new System.Drawing.Size(426, 287);
            this.lsvPhanCong.TabIndex = 1;
            this.lsvPhanCong.UseCompatibleStateImageBehavior = false;
            this.lsvPhanCong.View = System.Windows.Forms.View.Details;
            this.lsvPhanCong.DoubleClick += new System.EventHandler(this.lsvPhanCong_DoubleClick);
            // 
            // KhuVuc
            // 
            this.KhuVuc.Text = "Khu vực";
            this.KhuVuc.Width = 90;
            // 
            // Ca
            // 
            this.Ca.Text = "Ca";
            this.Ca.Width = 86;
            // 
            // GioBatDau
            // 
            this.GioBatDau.Text = "Giờ bắt đầu";
            this.GioBatDau.Width = 82;
            // 
            // GioKetThuc
            // 
            this.GioKetThuc.Text = "Giờ kết thúc";
            this.GioKetThuc.Width = 83;
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhuVuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(50, 36);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(153, 21);
            this.cmbKhuVuc.TabIndex = 2;
            // 
            // cmbCa
            // 
            this.cmbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCa.FormattingEnabled = true;
            this.cmbCa.Location = new System.Drawing.Point(209, 36);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.Size = new System.Drawing.Size(166, 21);
            this.cmbCa.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(50, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "V";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 380);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCa);
            this.Controls.Add(this.cmbKhuVuc);
            this.Controls.Add(this.lsvPhanCong);
            this.Controls.Add(this.lblNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhanCong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công";
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ListView lsvPhanCong;
        private System.Windows.Forms.ColumnHeader KhuVuc;
        private System.Windows.Forms.ColumnHeader Ca;
        private System.Windows.Forms.ComboBox cmbKhuVuc;
        private System.Windows.Forms.ComboBox cmbCa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader GioBatDau;
        private System.Windows.Forms.ColumnHeader GioKetThuc;
    }
}