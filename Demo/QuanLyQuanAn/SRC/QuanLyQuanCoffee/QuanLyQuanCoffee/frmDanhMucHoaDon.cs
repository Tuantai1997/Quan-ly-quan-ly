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
    public partial class frmDanhMucHoaDon : Form
    {
        public frmDanhMucHoaDon()
        {
            InitializeComponent();
        }

        private void frmDanhMucHoaDon_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            for (int i = 2012; i <= DateTime.Now.Year; i++)
            {
                cmbNam.Items.Add(i);
            }

            cmbHoaDon.SelectedIndex = 0;
            cmbThang.SelectedItem = DateTime.Now.Month;
            cmbNam.SelectedItem = DateTime.Now.Year;
            LoadHoaDon();
        }
        private void LoadHoaDon()
        {
            lblTriGiaHD.Text = "Trị giá hóa đơn: 0 VNĐ";
            lblSoHD.Text = "-- Số hóa đơn --";
            lsvHoaDon.Items.Clear();

            #region Kiểm tra điều kiện lọc
            if (cmbHoaDon.SelectedIndex == -1 || cmbThang.SelectedItem == null || cmbNam.SelectedItem == null)
            {
                return;
            }
            #endregion

            #region Lọc dữ liệu
            List<HoaDon> List = new List<HoaDon>();
            if(cmbHoaDon.SelectedIndex == 0)//Tất cả
            {
                List = (new BAL_HoaDon()).Get_HoaDon();
            }
            else if(cmbHoaDon.SelectedIndex == 1)//Chưa thanh toán
            {
                List = (new BAL_HoaDon()).Get_HoaDonTheoTinhTrang(false);
            }
            else if(cmbHoaDon.SelectedIndex == 2)//Đã thanh toán
            {
                List = (new BAL_HoaDon()).Get_HoaDonTheoTinhTrang(true);
            }
            //Lọc theo tháng, năm
            for (int i = 0; i < List.Count; i++)
            {
                if(List[i].NgayLapHD.Value.Month != (int)cmbThang.SelectedItem || List[i].NgayLapHD.Value.Year != (int)cmbNam.SelectedItem)
                {
                    List.RemoveAt(i); i--;
                }
            }
            #endregion

            #region Load dữ liệu đã lọc lên lsvHoaDon
            foreach (HoaDon hd in List)
            {
                ListViewItem item = new ListViewItem(hd.MaHD);
                if(hd.MaBan != null)
                {
                    item.SubItems.Add(hd.Ban.TenBan);
                }
                else
                {
                    item.SubItems.Add("");
                }
                if(hd.MaNV != null)
                {
                    item.SubItems.Add(hd.NhanVien.HoTen);
                }
                else
                {
                    item.SubItems.Add("");
                }
                item.SubItems.Add(hd.NgayLapHD.Value.ToShortDateString());
                item.SubItems.Add(hd.PhuThu.Value.ToString());
                item.SubItems.Add(hd.VAT.Value.ToString());
                if(hd.DaThanhToan.Value)
                {
                    item.SubItems.Add("Đã thanh toán");
                }
                else
                {
                    item.SubItems.Add("Chưa thanh toán");
                }

                lsvHoaDon.Items.Add(item);
            }
            #endregion
        }
        private void cmbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void lsvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvHoaDon.SelectedItems.Count == 1)
            {
                HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lsvHoaDon.SelectedItems[0].SubItems[0].Text);
                if(hd != null)
                {
                    lblSoHD.Text = hd.MaHD;
                }
            }
        }
        private void LoadChiTietHD()
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHD.Text);
            lsvChiTietHoaDon.Items.Clear();
            if(hd != null)
            {
                foreach(ChiTietHoaDon ct in hd.ChiTietHoaDons)
                {
                    ListViewItem item = new ListViewItem(ct.MaHD);
                    item.SubItems.Add(ct.MaMon);
                    item.SubItems.Add(ct.Mon.TenMon);
                    item.SubItems.Add(ct.DonGia.Value.ToString());
                    item.SubItems.Add(ct.SoLuong.Value.ToString());
                    item.SubItems.Add(ct.GhiChu);

                    lsvChiTietHoaDon.Items.Add(item);
                }
            }
        }
        private void lblSoHD_TextChanged(object sender, EventArgs e)
        {
            LoadChiTietHD();

            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHD.Text);
            double TriGiaHD = 0;
            if(hd != null)
            {
                foreach(ChiTietHoaDon ct in hd.ChiTietHoaDons)
                {
                    TriGiaHD += ct.SoLuong.Value * ct.DonGia.Value;
                }
                TriGiaHD = (TriGiaHD + hd.PhuThu.Value)*(1 + hd.VAT.Value/100);
            }
            lblTriGiaHD.Text = "Trị giá hóa đơn: " + TriGiaHD.ToString() + " VNĐ";
        }

        private void lsvChiTietHoaDon_DoubleClick(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count == 1)
            {
                ChiTietHoaDon ct = (new BAL_ChiTietHoaDon()).Get_ChiTietHoaDon(lsvChiTietHoaDon.SelectedItems[0].SubItems[0].Text, lsvChiTietHoaDon.SelectedItems[0].SubItems[1].Text);
                if (ct != null)
                {
                    (new frmEditChiTietHoaDon(ct)).ShowDialog();
                    string SoHD = lblSoHD.Text;
                    lblSoHD.Text = ""; lblSoHD.Text = SoHD;
                }
            }
        }
        private void lsvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            if(lsvHoaDon.SelectedItems.Count == 1)
            {
                HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHD.Text);
                if(hd != null)
                {
                    (new frmEditHoaDon(hd)).ShowDialog();
                    LoadHoaDon();
                    lblSoHD.Text = "-- Số hóa đơn --";
                }
            }
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
    }
}
