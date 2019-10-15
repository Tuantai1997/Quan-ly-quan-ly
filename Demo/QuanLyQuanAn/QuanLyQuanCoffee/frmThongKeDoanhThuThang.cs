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
    public partial class frmThongKeDoanhThuThang : Form
    {
        public frmThongKeDoanhThuThang()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            for (int i = 2012; i <= DateTime.Now.Year; i++)
            {
                cmbNam.Items.Add(i);
            }
            cmbThang.SelectedItem = DateTime.Now.Month;
            cmbNam.SelectedItem = DateTime.Now.Year;            
        }
        private void LoadReport()
        {
            this.VW_ThongKeDoanhThuTableAdapter.Fill(this.coffeeDataSet.VW_ThongKeDoanhThu);
            this.PhieuChiTableAdapter.Fill(this.coffeeDataSet.PhieuChi);

            //Set parameter
            ThongTinQuan tt = (new BAL_ThongTinQuan()).Get();
            if (tt == null) return;
            DateTime NgayBatDau = new DateTime((int)cmbNam.SelectedItem, (int)cmbThang.SelectedItem, 1);
            DateTime NgayKetThuc = NgayBatDau.AddMonths(1);

            double DoanhThu = 0;
            var List = (from v in (new QuanAnEntities()).VW_ThongKeDoanhThu
                        where v.NgayLapHD.Value.Month == (int)cmbThang.SelectedItem && v.NgayLapHD.Value.Year == (int)cmbNam.SelectedItem
                        select v);
            foreach(var v in List)
            {
                DoanhThu += v.TriGiaHD.Value;
            }

            double TongChi = 0;
            var List0 = (from pc in (new QuanAnEntities()).PhieuChi
                         where pc.NgayChi.Value.Month == (int)cmbThang.SelectedItem && pc.NgayChi.Value.Year == (int)cmbNam.SelectedItem
                        select pc);
            foreach (var pc in List0)
            {
                TongChi += pc.TongTien.Value;
            }

            ReportParameter[] param = new ReportParameter[]
                {
                    new ReportParameter("TenQuan", tt.TenQuan),
                    new ReportParameter("DiaChi","Địa chỉ: " + tt.DiaChi),
                    new ReportParameter("SDT", "SĐT: " + tt.SDT),
                    new ReportParameter("Email", "Email: " + tt.Email),
                    new ReportParameter("TieuDe", "THỐNG KÊ DOANH THU THÁNG " + cmbThang.SelectedItem.ToString() + " NĂM " + cmbNam.SelectedItem.ToString()),
                    new ReportParameter("NgayLap", DateTime.Now.ToShortDateString()),
                    new ReportParameter("NgayBatDau", NgayBatDau.ToShortDateString()),
                    new ReportParameter("NgayKetThuc", NgayKetThuc.ToShortDateString()),

                    new ReportParameter("NguoiLapBaoCao", Program.NhanVienDangDangNhap.HoTen),
                    new ReportParameter("DoanhThu", DoanhThu.ToString()),
                    new ReportParameter("TongChi", TongChi.ToString())
                };

            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThang.SelectedItem == null || cmbNam.SelectedItem == null) return;
            LoadReport();
        }
        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThang.SelectedItem == null || cmbNam.SelectedItem == null) return;
            LoadReport();
        }
    }
}
