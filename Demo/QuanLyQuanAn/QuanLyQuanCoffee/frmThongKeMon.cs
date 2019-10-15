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
    public partial class frmThongKeMon : Form
    {
        public frmThongKeMon()
        {
            InitializeComponent();
        }

        private void frmThongKeMon_Load(object sender, EventArgs e)
        {
            this.VW_MonTableAdapter.Fill(this.coffeeDataSet.VW_Mon);

            ThongTinQuan tt = (new BAL_ThongTinQuan()).Get();
            double TongDoanhThu = 0, TongTienLoi = 0;
            TongDoanhThu = (new QuanAnEntities()).VW_Mon.Sum(v => v.DoanhThu.Value);
            TongTienLoi = (new QuanAnEntities()).VW_Mon.Sum(v => v.TienLoi.Value);

            ReportParameter[] param = new ReportParameter[]
                {
                    new ReportParameter("TenQuan", tt.TenQuan),
                    new ReportParameter("DiaChi","Địa chỉ: " + tt.DiaChi),
                    new ReportParameter("SDT", "SĐT: " + tt.SDT),
                    new ReportParameter("Email", "Email: " + tt.Email),
                    new ReportParameter("NgayLap", DateTime.Now.ToShortDateString()),

                    new ReportParameter("NguoiLapBaoCao", Program.NhanVienDangDangNhap.HoTen),
                    new ReportParameter("TongDoanhThu", TongDoanhThu.ToString()),
                    new ReportParameter("TongTienLoi", TongTienLoi.ToString())
                };

            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
