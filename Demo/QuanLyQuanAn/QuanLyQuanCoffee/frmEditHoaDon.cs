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
    public partial class frmEditHoaDon : Form
    {
        HoaDon HD = new HoaDon();
        public frmEditHoaDon()
        {
            InitializeComponent();
        }
        public frmEditHoaDon(HoaDon hd)
        {
            HD = hd;
            InitializeComponent();
        }

        private void frmEditHoaDon_Load(object sender, EventArgs e)
        {
            if(HD != null)
            {
                txtMaHD.Text = HD.MaHD;
                if(HD.MaBan != null)
                {
                    txtMaBan.Text = HD.MaBan;
                }
                if(HD.MaNV != null)
                {
                    txtNhanVien.Text = HD.NhanVien.HoTen;
                }
                txtNgayLap.Text = HD.NgayLapHD.Value.ToString();
                txtPhuThu.Text = HD.PhuThu.Value.ToString();
                txtVAT.Text = HD.VAT.Value.ToString();
                if (HD.DaThanhToan.Value) rdbDaThanhToan.Checked = true;
                else rdbChuaThanhToan.Checked = true;
            }
        }
        private void TSB_CapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhuThu.Text.Trim())) txtPhuThu.Text = "0";
            if (string.IsNullOrWhiteSpace(txtVAT.Text.Trim())) txtVAT.Text = "0";

            HD.PhuThu = Convert.ToDouble(txtPhuThu.Text);
            HD.VAT = Convert.ToDouble(txtVAT.Text);

            (new BAL_HoaDon()).CapNhatHoaDon(HD);

            LichSuHoatDong ls = new LichSuHoatDong();
            ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
            ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
            ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
            ls.HoatDong = "Cập nhật hóa đơn (" + HD.MaHD + ")";
            ls.ThoiGian = DateTime.Now;
            ls.TinhTrang = "Thành công";
            (new BAL_LichSuHoatDong()).ThemLichSu(ls);

            this.Close();
        }
        private void TSB_Xoa_Click(object sender, EventArgs e)
        {
            if(rdbChuaThanhToan.Checked)
            {
                MessageBox.Show("Hóa đơn này chưa thanh toán!", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            //Xóa chi tiết hóa đơn
            foreach(ChiTietHoaDon ct in HD.ChiTietHoaDons)
            {
                (new BAL_ChiTietHoaDon()).XoaChiTietHoaDon(ct.MaHD, ct.MaMon);
            }
            //Xóa hóa đơn
            (new BAL_HoaDon()).XoaHoaDon(txtMaHD.Text);

            LichSuHoatDong ls = new LichSuHoatDong();
            ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
            ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
            ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
            ls.HoatDong = "Xóa hóa đơn (" + txtMaHD.Text + ")";
            ls.ThoiGian = DateTime.Now;
            ls.TinhTrang = "Thành công";
            (new BAL_LichSuHoatDong()).ThemLichSu(ls);

            this.Close();
        }
        private void TSB_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TSB_InHoaDon_Click(object sender, EventArgs e)
        {
            if(HD != null)
            {
                (new frmInHoaDon(HD)).ShowDialog();
            }
        }
    }
}
