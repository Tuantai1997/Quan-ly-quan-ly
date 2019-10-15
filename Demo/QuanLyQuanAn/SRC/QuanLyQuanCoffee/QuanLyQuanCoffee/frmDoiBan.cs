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

namespace QuanLyQuanCoffee
{
    public partial class frmDoiBan : Form
    {
        HoaDon HD;
        public static bool Huy = true;
        public frmDoiBan()
        {
            InitializeComponent();
        }
        public frmDoiBan(HoaDon hd)
        {
            InitializeComponent();
            HD = hd;
        }

        private void frmDoiBan_Load(object sender, EventArgs e)
        {
            if(HD != null)
                lblTenBan.Text = HD.Ban.TenBan;

            cmbBanChuyenToi.DataSource = (new BAL_Ban()).Get_BanTrong();
            cmbBanChuyenToi.DisplayMember = "TenBan";
            cmbBanChuyenToi.ValueMember = "MaBan";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(HD != null)
            {
                //Cập nhật lại hóa đơn
                HoaDon hd = new HoaDon();
                hd.MaHD = HD.MaHD;
                hd.MaBan = cmbBanChuyenToi.SelectedValue.ToString();
                hd.MaNV = HD.MaNV;
                hd.NgayLapHD = HD.NgayLapHD.Value;
                hd.PhuThu = HD.PhuThu;
                hd.VAT = HD.VAT;
                hd.DaThanhToan = HD.DaThanhToan;
                (new BAL_HoaDon()).CapNhatHoaDon(hd);
                //Cập nhật lại tình trạng của bàn
                (new BAL_Ban()).CapNhatTinhTrangCuaBan(HD.MaBan, false);
                (new BAL_Ban()).CapNhatTinhTrangCuaBan(cmbBanChuyenToi.SelectedValue.ToString(), true);

                Huy = false;
                this.Close();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Huy = true;
            this.Close();
        }

        private void frmDoiBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.X))
                {
                    btnXacNhan_Click(sender, e);
                }
                
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                btnHuy_Click(sender, e);
            }
        }
    }
}
