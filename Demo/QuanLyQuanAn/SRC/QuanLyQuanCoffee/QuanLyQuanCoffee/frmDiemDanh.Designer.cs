namespace QuanLyQuanCoffee
{
    partial class frmDiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemDanh));
            this.dtpID = new System.Windows.Forms.DateTimePicker();
            this.cmbCa = new System.Windows.Forms.ComboBox();
            this.pnlNhanVien = new System.Windows.Forms.Panel();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.cmbKhuVuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpID
            // 
            this.dtpID.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpID.Location = new System.Drawing.Point(2, 2);
            this.dtpID.Name = "dtpID";
            this.dtpID.Size = new System.Drawing.Size(85, 20);
            this.dtpID.TabIndex = 0;
            this.dtpID.ValueChanged += new System.EventHandler(this.dtpID_ValueChanged);
            // 
            // cmbCa
            // 
            this.cmbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCa.FormattingEnabled = true;
            this.cmbCa.Location = new System.Drawing.Point(220, 1);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.Size = new System.Drawing.Size(121, 21);
            this.cmbCa.TabIndex = 1;
            this.cmbCa.SelectedIndexChanged += new System.EventHandler(this.cmbCa_SelectedIndexChanged);
            // 
            // pnlNhanVien
            // 
            this.pnlNhanVien.AutoScroll = true;
            this.pnlNhanVien.Location = new System.Drawing.Point(0, 51);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(341, 356);
            this.pnlNhanVien.TabIndex = 2;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Location = new System.Drawing.Point(2, 25);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(339, 23);
            this.lblThoiGian.TabIndex = 3;
            this.lblThoiGian.Text = "label1";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbKhuVuc
            // 
            this.cmbKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhuVuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhuVuc.FormattingEnabled = true;
            this.cmbKhuVuc.Location = new System.Drawing.Point(93, 1);
            this.cmbKhuVuc.Name = "cmbKhuVuc";
            this.cmbKhuVuc.Size = new System.Drawing.Size(121, 21);
            this.cmbKhuVuc.TabIndex = 4;
            this.cmbKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cmbKhuVuc_SelectedIndexChanged);
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 407);
            this.Controls.Add(this.cmbKhuVuc);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.pnlNhanVien);
            this.Controls.Add(this.cmbCa);
            this.Controls.Add(this.dtpID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                      Điểm danh";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpID;
        private System.Windows.Forms.ComboBox cmbCa;
        private System.Windows.Forms.Panel pnlNhanVien;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.ComboBox cmbKhuVuc;
    }
}