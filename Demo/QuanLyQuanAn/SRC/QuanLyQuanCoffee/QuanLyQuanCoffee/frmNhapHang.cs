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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            LoadMon();
            LoadMonSapHet();
        }
        private void LoadMon()
        {
            lsvMon.Items.Clear();
            List<Mon> List = (new BAL_Mon()).Get_Mon();
            foreach(Mon m in List)
            {
                ListViewItem item = new ListViewItem(m.MaMon);
                item.SubItems.Add(m.TenMon);
                item.SubItems.Add(m.DonGia.Value.ToString());
                item.SubItems.Add(m.SoLuong.Value.ToString());
                item.SubItems.Add(m.GiaNhap.Value.ToString());

                lsvMon.Items.Add(item);
            }
        }

        //Load những món có số lượng còn dưới 10
        private void LoadMonSapHet()
        {
            lsvMonSapHet.Items.Clear();
            List<Mon> List = (new BAL_Mon()).Get_Mon();
            foreach (Mon m in List.OrderBy(m => m.SoLuong.Value))
            {
                if (m.SoLuong.Value <= 10)
                {
                    ListViewItem item = new ListViewItem(m.MaMon);
                    item.SubItems.Add(m.TenMon);
                    item.SubItems.Add(m.SoLuong.Value.ToString());

                    lsvMonSapHet.Items.Add(item);
                }
            }
        }

        private void lsvMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvMon.SelectedItems.Count == 1)
            {
                Mon m = (new BAL_Mon()).Get_Mon(lsvMon.SelectedItems[0].SubItems[0].Text);
                if(m != null)
                {
                    txtMaMon.Text = m.MaMon;
                    txtTenMon.Text = m.TenMon;
                    txtSoLuong.Text = "0";
                    txtGiaNhap.Text = m.GiaNhap.Value.ToString();
                }
            }
        }
        private void lsvMonSapHet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMonSapHet.SelectedItems.Count == 1)
            {
                Mon m = (new BAL_Mon()).Get_Mon(lsvMonSapHet.SelectedItems[0].SubItems[0].Text);
                if (m != null)
                {
                    txtMaMon.Text = m.MaMon;
                    txtTenMon.Text = m.TenMon;
                    txtSoLuong.Text = "0";
                    txtGiaNhap.Text = m.GiaNhap.Value.ToString();
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text.Trim())) txtSoLuong.Text = "0";
            if (string.IsNullOrWhiteSpace(txtGiaNhap.Text.Trim())) txtGiaNhap.Text = "0";

            Mon m = (new BAL_Mon()).Get_Mon(txtMaMon.Text);
            if(m != null)
            {
                m.SoLuong += Convert.ToInt32(txtSoLuong.Text);
                m.GiaNhap = Convert.ToDouble(txtGiaNhap.Text);

                (new BAL_Mon()).CapNhatMon(m);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Nhập hàng (" + txtMaMon.Text + ") SL(" + txtSoLuong.Text + ") ĐG(" + txtGiaNhap.Text + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                btnReset_Click(new Button(), new EventArgs());
                LoadMon();
                LoadMonSapHet();
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lsvMon.Items.Clear();
            string str = txtTimKiem.Text.Trim().ToUpper();
            List<Mon> List = (new BAL_Mon()).Get_Mon();
            var ListTK = (from m in List
                              where m.MaMon.ToUpper().Contains(str) || m.TenMon.ToUpper().Contains(str)
                              select m);
            foreach (Mon m in ListTK)
            {
                ListViewItem item = new ListViewItem(m.MaMon);
                item.SubItems.Add(m.TenMon);
                item.SubItems.Add(m.DonGia.Value.ToString());
                item.SubItems.Add(m.SoLuong.Value.ToString());
                item.SubItems.Add(m.GiaNhap.Value.ToString());

                lsvMon.Items.Add(item);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaMon.ResetText();
            txtTenMon.ResetText();
            txtSoLuong.Text = "0";
            txtGiaNhap.Text = "0";
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaMon.Text.Trim()))
            {
                btnNhap.Enabled = false;
            }
            else
            {
                btnNhap.Enabled = true;
            }
        }

        private void frmNhapHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.R))
                {
                    btnReset_Click(sender, e);
                }
                
            }
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnNhap_Click(sender, e);
            }
        }
    }
}
