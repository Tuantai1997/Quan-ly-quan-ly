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
    public partial class frmGopBan : Form
    {
        HoaDon HD;
        public static bool Huy = true;
        public frmGopBan()
        {
            InitializeComponent();
        }
        public frmGopBan(HoaDon hd)
        {
            InitializeComponent();
            HD = hd;
        }

        private void frmGopBan_Load(object sender, EventArgs e)
        {
            if (HD != null) lblTenBan.Text = HD.Ban.TenBan;

            List<Ban> List = (new BAL_Ban()).Get_BanCoKhach();
            foreach(Ban b in List)
            {
                if(b.MaBan == HD.MaBan)
                {
                    List.Remove(b);
                    break;
                }
            }
            cmbBanGop.DataSource = List;
            cmbBanGop.DisplayMember = "TenBan";
            cmbBanGop.ValueMember = "MaBan";
           
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(HD != null)
            {
                DialogResult QS = MessageBox.Show("Hóa đơn của " + HD.Ban.TenBan + " sẽ được chuyển qua "
                    + (new BAL_Ban()).Get_Ban(cmbBanGop.SelectedValue.ToString()).TenBan 
                    + ". Bạn có chắc muốn gộp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(QS == DialogResult.Yes)
                {
                    //Thêm hoặc cập nhật chi tiết hóa đơn cho bàn nhận
                    HoaDon HDNhan = (new BAL_Ban()).Get_HoaDonBanChuaThanhToanTheoMaBan(cmbBanGop.SelectedValue.ToString());
                    foreach(ChiTietHoaDon ct in HD.ChiTietHoaDons)
                    {
                        ChiTietHoaDon c = (new BAL_ChiTietHoaDon()).Get_ChiTietHoaDon(HDNhan.MaHD, ct.MaMon);
                        if(c != null)//Hóa đơn nhận đã có món này, chỉ cập nhật số lượng
                        {
                            (new BAL_ChiTietHoaDon()).CapNhatChiTietHoaDon(c.MaHD, c.MaMon, c.DonGia.Value, c.SoLuong.Value + ct.SoLuong.Value, c.GhiChu + " -- " + ct.GhiChu);
                        }
                        else//Hóa đơn nhận chưa có món này, thêm mới chi tiết hóa đơn
                        {
                            (new BAL_ChiTietHoaDon()).ThemChiTietHoaDon(HDNhan.MaHD, ct.MaMon, ct.DonGia.Value, ct.SoLuong.Value, ct.GhiChu);
                        }
                    }
                    
                    //Xóa hóa đơn và chi tiết hóa đơn của bàn hiện tại
                    foreach (ChiTietHoaDon ct in HD.ChiTietHoaDons)
                    {
                        (new BAL_ChiTietHoaDon()).XoaChiTietHoaDon(ct.MaHD, ct.MaMon);
                    }
                    (new BAL_HoaDon()).XoaHoaDon(HD.MaHD);
                    //Cập nhật lại tình trạng của bàn hiện tại
                    (new BAL_Ban()).CapNhatTinhTrangCuaBan(HD.MaBan, false);
                    //Thoát
                    Huy = false;
                    this.Close();
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Huy = true;
            this.Close();
        }

        private void frmGopBan_KeyDown(object sender, KeyEventArgs e)
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
