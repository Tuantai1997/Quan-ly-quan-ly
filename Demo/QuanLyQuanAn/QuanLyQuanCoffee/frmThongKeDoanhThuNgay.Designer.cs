namespace QuanLyQuanCoffee
{
    partial class frmThongKeDoanhThuNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDoanhThuNgay));
            this.VW_ThongKeDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoffeeDataSet = new QuanLyQuanCoffee.QuanAnDataSet();
            this.VW_ThongKeMonTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_ThongKeDoanhThuTableAdapter = new QuanLyQuanCoffee.CoffeeDataSetTableAdapters.VW_ThongKeDoanhThuTableAdapter();
            this.VW_ThongKeMonTheoNgayTableAdapter = new QuanLyQuanCoffee.CoffeeDataSetTableAdapters.VW_ThongKeMonTheoNgayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ThongKeDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ThongKeMonTheoNgayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VW_ThongKeDoanhThuBindingSource
            // 
            this.VW_ThongKeDoanhThuBindingSource.DataMember = "VW_ThongKeDoanhThu";
            this.VW_ThongKeDoanhThuBindingSource.DataSource = this.CoffeeDataSet;
            // 
            // CoffeeDataSet
            // 
            this.CoffeeDataSet.DataSetName = "CoffeeDataSet";
            this.CoffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_ThongKeMonTheoNgayBindingSource
            // 
            this.VW_ThongKeMonTheoNgayBindingSource.DataMember = "VW_ThongKeMonTheoNgay";
            this.VW_ThongKeMonTheoNgayBindingSource.DataSource = this.CoffeeDataSet;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(285, 3);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(83, 20);
            this.dtpNgay.TabIndex = 2;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.DocumentMapWidth = 8;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_ThongKeDoanhThuBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.VW_ThongKeMonTheoNgayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCoffee.rpNgay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 29);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(629, 657);
            this.reportViewer1.TabIndex = 6;
            // 
            // VW_ThongKeDoanhThuTableAdapter
            // 
            this.VW_ThongKeDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // VW_ThongKeMonTheoNgayTableAdapter
            // 
            this.VW_ThongKeMonTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeDoanhThuNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 686);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKeDoanhThuNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "   Thống kê theo ngày";
            this.Load += new System.EventHandler(this.frmThongKeTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_ThongKeDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ThongKeMonTheoNgayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_ThongKeDoanhThuBindingSource;
        private QuanAnDataSet CoffeeDataSet;
        private System.Windows.Forms.BindingSource VW_ThongKeMonTheoNgayBindingSource;
        private CoffeeDataSetTableAdapters.VW_ThongKeDoanhThuTableAdapter VW_ThongKeDoanhThuTableAdapter;
        private CoffeeDataSetTableAdapters.VW_ThongKeMonTheoNgayTableAdapter VW_ThongKeMonTheoNgayTableAdapter;
    }
}