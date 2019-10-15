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
    public partial class frmDoiMatKhau : Form
    {
      
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(Program.NhanVienDangDangNhap != null)
            {
                if(Program.NhanVienDangDangNhap.MatKhau != txtMatKhauCu.Text)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhauCu.ResetText(); txtMatKhauCu.Focus();
                    return;
                }
                if(txtMatKhauMoi.Text != txtNhapLai.Text)
                {
                    MessageBox.Show("Xác nhận không khớp với mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNhapLai.ResetText(); txtNhapLai.Focus();
                    return;
                }
                 NhanVien nv = Program.NhanVienDangDangNhap;
                 nv.MatKhau = txtMatKhauMoi.Text;
                (new BAL_NhanVien()).CapNhat(nv);
                this.Close();
                
            }
        }

        private void frmDoiMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.Enter))
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
