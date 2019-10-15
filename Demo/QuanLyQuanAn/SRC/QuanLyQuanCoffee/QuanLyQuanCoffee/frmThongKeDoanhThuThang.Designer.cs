namespace QuanLyQuanCoffee
{
    partial class frmThongKeDoanhThuThang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDoanhThuThang));
            this.VW_ThongKeDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDataSet = new QuanLyQuanCoffee.CoffeeDataSet();
            this.PhieuChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VW_ThongKeDoanhThuTableAdapter = new QuanLyQuanCoffee.CoffeeDataSetTableAdapters.VW_ThongKeDoanhThuTableAdapter();
            this.PhieuChiTableAdapter = new QuanLyQuanCoffee.CoffeeDataSetTableAdapters.PhieuChiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ThongKeDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuChiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VW_ThongKeDoanhThuBindingSource
            // 
            this.VW_ThongKeDoanhThuBindingSource.DataMember = "VW_ThongKeDoanhThu";
            this.VW_ThongKeDoanhThuBindingSource.DataSource = this.coffeeDataSet;
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhieuChiBindingSource
            // 
            this.PhieuChiBindingSource.DataMember = "PhieuChi";
            this.PhieuChiBindingSource.DataSource = this.coffeeDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_ThongKeDoanhThuBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.PhieuChiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCoffee.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(627, 656);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(253, 3);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(35, 21);
            this.cmbThang.TabIndex = 1;
            this.cmbThang.SelectedIndexChanged += new System.EventHandler(this.cmbThang_SelectedIndexChanged);
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(329, 3);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(54, 21);
            this.cmbNam.TabIndex = 2;
            this.cmbNam.SelectedIndexChanged += new System.EventHandler(this.cmbNam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm";
            // 
            // VW_ThongKeDoanhThuTableAdapter
            // 
            this.VW_ThongKeDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // PhieuChiTableAdapter
            // 
            this.PhieuChiTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKeDoanhThuThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                           Thống " +
    "kê doanh thu tháng";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_ThongKeDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuChiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CoffeeDataSetTableAdapters.VW_ThongKeDoanhThuTableAdapter VW_ThongKeDoanhThuTableAdapter;
        private CoffeeDataSetTableAdapters.PhieuChiTableAdapter PhieuChiTableAdapter;
        private System.Windows.Forms.BindingSource VW_ThongKeDoanhThuBindingSource;
        private CoffeeDataSet coffeeDataSet;
        private System.Windows.Forms.BindingSource PhieuChiBindingSource;
    }
}