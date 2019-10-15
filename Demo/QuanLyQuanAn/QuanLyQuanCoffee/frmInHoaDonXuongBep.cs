using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BusinessAcessLayer;

namespace QuanLyQuanCoffee
{
    public partial class frmInHoaDonXuongBep : Form
    {
        HoaDon HD = new HoaDon();
        public frmInHoaDonXuongBep()
        {
            InitializeComponent();
        }
        public frmInHoaDonXuongBep(HoaDon hd)
        {
            InitializeComponent();
            HD = hd;
        }

        private void frmInHoaDonXuongBep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.VW_Bill' table. You can move, or remove it, as needed.
            this.VW_BillTableAdapter.Fill(this.coffeeDataSet.VW_Bill);

            ReportParameter[] param = new ReportParameter[]
                {
                    new ReportParameter("MaHD", HD.MaHD),
                    new ReportParameter("NgayGio", HD.NgayLapHD.Value.ToString()),
                    new ReportParameter("Ban", HD.Ban.TenBan),
                    new ReportParameter("KhuVuc", HD.Ban.KhuVuc.TenKV),
                    new ReportParameter("NgayIn", DateTime.Now.ToString())
                };

            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
