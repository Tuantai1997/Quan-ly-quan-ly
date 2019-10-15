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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            foreach (NhanVien nv in (new BAL_NhanVien().Get_NhanVien()))
            {
                if(nv.Status == true)
                {
                    txtTaiKhoan.Text = nv.MaNV;
                    txtMatKhau.Text = nv.MatKhau;
                    cbNhoMatKhau.Checked = true;
                    btnDangNhap.Focus();
                    break;
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
            {
                MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }
            NhanVien nv = (new BAL_NhanVien()).Get_NhanVien(txtTaiKhoan.Text.Trim());
            if(nv != null)
            {
                if (nv.MatKhau == txtMatKhau.Text)
                {
                    //Nhớ mật khẩu
                    if(cbNhoMatKhau.Checked)
                    {
                        foreach (NhanVien n in (new BAL_NhanVien().Get_NhanVien()))
                        {
                            (new BAL_NhanVien()).SetStatus(n.MaNV, false);
                        }
                        (new BAL_NhanVien()).SetStatus(nv.MaNV, true);
                    }
                    else
                    {
                        foreach (NhanVien n in (new BAL_NhanVien().Get_NhanVien()))
                        {
                            (new BAL_NhanVien()).SetStatus(n.MaNV, false);
                        }                        
                    }

                    LichSuHoatDong ls = new LichSuHoatDong();
                    ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                    ls.MaNV = nv.MaNV;
                    ls.HoTen = nv.HoTen;
                    ls.HoatDong = "Đăng nhập!";
                    ls.ThoiGian = DateTime.Now;
                    ls.TinhTrang = "Thành công";
                    (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                    Program.NhanVienDangDangNhap = nv;
                    this.Visible = false;
                    (new frmMain()).ShowDialog();
                    this.Visible = true;
                    txtTaiKhoan.ResetText(); txtMatKhau.ResetText();
                    foreach (NhanVien n in (new BAL_NhanVien().Get_NhanVien()))
                    {
                        if(n.Status == true)
                        {
                            txtTaiKhoan.Text = n.MaNV;
                            txtMatKhau.Text = n.MatKhau;
                            break;
                        }
                    };
                }
                else
                {
                    LichSuHoatDong ls = new LichSuHoatDong();
                    ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                    ls.MaNV = nv.MaNV;
                    ls.HoTen = nv.HoTen;
                    ls.HoatDong = "Đăng nhập!";
                    ls.ThoiGian = DateTime.Now;
                    ls.TinhTrang = "Thất bại";
                    (new BAL_LichSuHoatDong()).ThemLichSu(ls);
                    MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau.ResetText();
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                txtTaiKhoan.Focus();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.Focus();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    btnDangNhap_Click(sender, e);
                }
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                btnThoat_Click(sender, e);
            }
        }
    }
}
