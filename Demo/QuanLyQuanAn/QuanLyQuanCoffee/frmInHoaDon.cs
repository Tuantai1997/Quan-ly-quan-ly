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
    public partial class frmInHoaDon : Form
    {
        HoaDon HD = new HoaDon();
        public frmInHoaDon()
        {
            InitializeComponent();
        }
        public frmInHoaDon(HoaDon hd)
        {
            InitializeComponent();
            HD = hd;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.VW_Bill' table. You can move, or remove it, as needed.
            this.VW_BillTableAdapter.Fill(this.coffeeDataSet.VW_Bill);
            SetParameters();
            this.reportViewer1.RefreshReport();
        }

        private void SetParameters()
        {
            ThongTinQuan tt = (new BAL_ThongTinQuan()).Get();
            double vat = 0;
            double TongTienNew = 0;
            double TongTien = 0;
            foreach (ChiTietHoaDon ct in HD.ChiTietHoaDons)
            {
                TongTien += ct.SoLuong.Value * ct.DonGia.Value;
            }
            TongTienNew = (TongTien + HD.PhuThu.Value) * (1 + HD.VAT.Value / 100);
            vat = TongTienNew - TongTien;
            //Ban, NhanVien, KhuVuc
            string TenBan = "null", HoTenNhanVien = "null", TenKhuVuc = "null";
            if (HD.MaBan != null) TenBan = HD.Ban.TenBan;
            if (HD.MaNV != null) HoTenNhanVien = HD.NhanVien.HoTen;
            if (HD.MaBan != null && HD.Ban.MaKV != null) TenKhuVuc = HD.Ban.KhuVuc.TenKV;

            ReportParameter[] param = new ReportParameter[]
                {
                    new ReportParameter("TenQuan", tt.TenQuan),
                    new ReportParameter("DiaChi","Địa chỉ: " + tt.DiaChi),
                    new ReportParameter("SDT", "SĐT: " + tt.SDT),
                    new ReportParameter("Email", "Email: " + tt.Email),
                    new ReportParameter("MaHD0", HD.MaHD),
                    new ReportParameter("NgayGio", HD.NgayLapHD.Value.ToString()),
                    new ReportParameter("Ban", TenBan),
                    new ReportParameter("NhanVien", HoTenNhanVien),

                    new ReportParameter("KhuVuc", TenKhuVuc),
                    new ReportParameter("PhuThu", HD.PhuThu.Value.ToString()),
                    new ReportParameter("VAT", HD.VAT.Value.ToString()),
                   //new ReportParameter("GiaVAT", vat.ToString()),
                    new ReportParameter("TongTien", TongTienNew.ToString()),
                    new ReportParameter("NgayIn", DateTime.Now.ToString())
                };

            reportViewer1.LocalReport.SetParameters(param);
        }
    }
}
