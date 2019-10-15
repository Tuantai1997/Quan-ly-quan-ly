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
    public partial class frmEditChiTietHoaDon : Form
    {
        ChiTietHoaDon CT = new ChiTietHoaDon();
        public frmEditChiTietHoaDon()
        {
            InitializeComponent();
        }
        public frmEditChiTietHoaDon(ChiTietHoaDon ct)
        {
            InitializeComponent();
            CT = ct;
        }

        private void frmEditChiTietHoaDon_Load(object sender, EventArgs e)
        {
            txtMaMon.Text = CT.MaMon;
            txtTenMon.Text = CT.Mon.TenMon;
            nmSoLuong.Value = CT.SoLuong.Value;
            txtGhiChu.Text = CT.GhiChu;
            txtDonGia.Text = CT.DonGia.Value.ToString();
            nmSoLuong.Maximum = int.MaxValue;
        }
        private void nmSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 8 && (int)e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }
        private void TSB_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int SoLuong = Convert.ToInt32(nmSoLuong.Value);
                if (SoLuong > (CT.Mon.SoLuong.Value + CT.SoLuong))
                {
                    MessageBox.Show("Hiện tại chỉ có thể cập nhật tối đa " + (CT.Mon.SoLuong.Value + CT.SoLuong.Value) + " " + CT.Mon.TenMon + "!", "Số lượng không đủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nmSoLuong.Value = CT.Mon.SoLuong.Value + CT.SoLuong.Value;
                    return;
                }
                bool KQ = false;
                KQ = (new BAL_ChiTietHoaDon()).CapNhatChiTietHoaDon(CT.MaHD, CT.MaMon, CT.DonGia.Value, SoLuong, txtGhiChu.Text);
                if (!KQ)
                {
                    MessageBox.Show("Không cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                //Cập nhật lại số lượng còn lại của món
                (new BAL_Mon()).CapNhatSoLuong(CT.MaMon, CT.SoLuong.Value - SoLuong);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập lại số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TSB_Xoa_Click(object sender, EventArgs e)
        {
            bool KQ = false;
            KQ = (new BAL_ChiTietHoaDon()).XoaChiTietHoaDon(CT.MaHD, CT.MaMon);
            if (!KQ)
            {
                MessageBox.Show("Không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            //Cập nhật lại số lượng còn lại của món
            (new BAL_Mon()).CapNhatSoLuong(CT.MaMon, CT.SoLuong.Value);
            this.Close();
        }
        private void TSB_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
