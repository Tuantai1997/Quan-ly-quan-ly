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
    public partial class frmEditThongTinQuan : Form
    {
        public frmEditThongTinQuan()
        {
            InitializeComponent();
        }

        private void frmEditThongTinQuan_Load(object sender, EventArgs e)
        {
            ThongTinQuan tt = (new BAL_ThongTinQuan()).Get();
            if(tt != null)
            {
                txtTenQuan.Text = tt.TenQuan;
                txtDiaChi.Text = tt.DiaChi;
                txtSDT.Text = tt.SDT;
                txtEmail.Text = tt.Email;

                try
                {
                    // Load hình ảnh lên pictureBox
                    byte[] image = tt.HinhAnh;
                    MemoryStream stream = new MemoryStream(image);

                    ptbHinhAnh.Image = Image.FromStream(stream);
                }
                catch (Exception)
                {
                }
            }
        }
        private void ptbHinhAnh_Click(object sender, EventArgs e)
        {
            // Lấy hình ảnh từ đĩa
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string FileName = ofd.FileName;

                if (string.IsNullOrEmpty(FileName)) return;

                try
                {
                    ptbHinhAnh.Image = Image.FromFile(FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("Tệp tin không hợp lệ.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                ThongTinQuan tt0 = new ThongTinQuan();
                tt0.TenQuan = txtTenQuan.Text;
                tt0.DiaChi = txtDiaChi.Text;
                tt0.SDT = txtSDT.Text;
                tt0.Email = txtEmail.Text;
                MemoryStream stream = new MemoryStream();
                ptbHinhAnh.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                tt0.HinhAnh = stream.ToArray();

                (new BAL_ThongTinQuan()).CapNhat(tt0);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Cập nhật thông tin quán!";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể cập nhật, vui lòng kiểm tra lại các thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmEditThongTinQuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.C))
                {
                    btnCapNhap_Click(sender, e);
                }
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                btnHuy_Click(sender, e);
            }
        }
    }
}
