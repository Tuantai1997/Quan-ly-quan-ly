using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAcessLayer;
using Microsoft.Reporting.WinForms;

namespace QuanLyQuanCoffee
{
    public partial class frmThongKeDoanhThuNgay : Form
    {
        public frmThongKeDoanhThuNgay()
        {
            InitializeComponent();
        }

        private void frmThongKeTheoNgay_Load(object sender, EventArgs e)
        {
            LoadReport();

        }
        private void LoadReport()
        {

            // TODO: This line of code loads data into the 'CoffeeDataSet.VW_ThongKeDoanhThu' table. You can move, or remove it, as needed.
            this.VW_ThongKeDoanhThuTableAdapter.Fill(this.CoffeeDataSet.VW_ThongKeDoanhThu);
            // TODO: This line of code loads data into the 'CoffeeDataSet.VW_ThongKeMonTheoNgay' table. You can move, or remove it, as needed.
            this.VW_ThongKeMonTheoNgayTableAdapter.Fill(this.CoffeeDataSet.VW_ThongKeMonTheoNgay);

            //Set parameter
            ThongTinQuan tt = (new BAL_ThongTinQuan()).Get();
            if (tt == null) return;
            DateTime ChanDau = (new DateTime(dtpNgay.Value.Year, dtpNgay.Value.Month, dtpNgay.Value.Day, 23, 59, 59));
            DateTime ChanCuoi = (new DateTime(dtpNgay.Value.Year, dtpNgay.Value.Month, dtpNgay.Value.Day, 0, 0, 0));
            string NgayLoc = dtpNgay.Value.ToShortDateString();
            double DoanhThu = 0;
            var List = (from v in (new CoffeeEntities()).VW_ThongKeDoanhThu
                        where v.NgayLapHD.Value >= ChanCuoi && v.NgayLapHD.Value <= ChanDau
                        select v);
            foreach (var v in List)
            {
                DoanhThu += v.TriGiaHD.Value;
            }
            double Tong = 0;
            var List0 = (from v in (new CoffeeEntities()).VW_ThongKeMonTheoNgay
                        where v.Ngay == NgayLoc
                        select v);
            foreach (var v in List0)
            {
                Tong += v.DoanhThu.Value;
            }

            ReportParameter[] param = new ReportParameter[]
                {
                    new ReportParameter("TenQuan", tt.TenQuan),
                    new ReportParameter("DiaChi","Địa chỉ: " + tt.DiaChi),
                    new ReportParameter("SDT", "SĐT: " + tt.SDT),
                    new ReportParameter("Email", "Email: " + tt.Email),
                    new ReportParameter("TieuDe", "THỐNG KÊ DOANH THU NGÀY " + dtpNgay.Value.ToShortDateString()),
                    new ReportParameter("NgayIn", DateTime.Now.ToShortDateString()),
                    new ReportParameter("ChanDau", ChanDau.ToString()),
                    new ReportParameter("ChanCuoi", ChanCuoi.ToString()),
                    new ReportParameter("NgayLoc", NgayLoc),
                    new ReportParameter("NguoiLapBaoCao", Program.NhanVienDangDangNhap.HoTen),
                    new ReportParameter("DoanhThu", DoanhThu.ToString()),
                    new ReportParameter("Tong", Tong.ToString())
                };

            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
