namespace QuanLyQuanCoffee
{
    partial class frmThongKeMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeMon));
            this.VW_MonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDataSet = new QuanLyQuanCoffee.CoffeeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_MonTableAdapter = new QuanLyQuanCoffee.CoffeeDataSetTableAdapters.VW_MonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VW_MonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VW_MonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCoffee.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(655, 605);
            this.reportViewer1.TabIndex = 0;
            // 
            // VW_MonBindingSource
            // 
            this.VW_MonBindingSource.DataMember = "VW_Mon";
            this.VW_MonBindingSource.DataSource = this.coffeeDataSet;
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_MonTableAdapter
            // 
            this.VW_MonTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 605);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKeMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "            Thống kê món";
            this.Load += new System.EventHandler(this.frmThongKeMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_MonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VW_MonBindingSource;
        private CoffeeDataSetTableAdapters.VW_MonTableAdapter VW_MonTableAdapter;
        private CoffeeDataSet coffeeDataSet;
    }
}