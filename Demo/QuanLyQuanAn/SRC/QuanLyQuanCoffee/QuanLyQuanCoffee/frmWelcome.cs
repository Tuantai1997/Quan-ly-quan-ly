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
using System.IO;

namespace QuanLyQuanCoffee
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            ThongTinQuan tt = (new BAL_ThongTinQuan()).Get();
            if(tt != null)
            {
                lblTenQuan.Text = "Welcome to " + tt.TenQuan;
                lblDiaChi.Text = "Địa chỉ: " + tt.DiaChi;
                lblSDT.Text = "SĐT: " + tt.SDT;
                lblEmail.Text = "Email: " + tt.Email;

                try
                {
                    // Load hình ảnh
                    byte[] image = tt.HinhAnh;
                    MemoryStream stream = new MemoryStream(image);

                    this.BackgroundImage = Image.FromStream(stream);
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
