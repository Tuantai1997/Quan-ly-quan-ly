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
    public partial class frmDanhMucBan : Form
    {
        public frmDanhMucBan()
        {
            InitializeComponent();
        }

        private void frmDanhMucBan_Load(object sender, EventArgs e)
        {
            cmbKhuVuc.DataSource = (new BAL_KhuVuc()).Get_KhuVuc();
            cmbKhuVuc.DisplayMember = "TenKV";
            cmbKhuVuc.ValueMember = "MaKV";


            List<KhuVuc> List = (new BAL_KhuVuc()).Get_KhuVuc();
            KhuVuc k = new KhuVuc()
            {
                MaKV = "ALL",
                TenKV = "Tất cả"
            };
            List.Insert(0, k);
            cmbKhuVuc0.DataSource = List;
            cmbKhuVuc0.DisplayMember = "TenKV";
            cmbKhuVuc0.ValueMember = "MaKV";

            LoadBan();
        }
        private void LoadBan()
        {
            List<Ban> List = (new BAL_Ban()).Get_Ban();
            lsvBan.Items.Clear();
            foreach(Ban b in List)
            {
                ListViewItem item = new ListViewItem(b.MaBan);
                if(b.MaKV != null)
                {
                    item.SubItems.Add(b.KhuVuc.TenKV);
                }
                else
                {
                    item.SubItems.Add("null");
                }
                item.SubItems.Add(b.TenBan);

                lsvBan.Items.Add(item);
            }
        }

        private void lsvBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvBan.SelectedItems.Count == 1)
            {
                Ban b = (new BAL_Ban()).Get_Ban(lsvBan.SelectedItems[0].SubItems[0].Text);
                if(b != null)
                {
                    txtMaBan.Text = b.MaBan;
                    if(b.MaKV != null)
                    {
                        cmbKhuVuc.SelectedValue = b.MaKV;
                    }
                    else
                    {
                        cmbKhuVuc.SelectedValue = "";
                    }
                    txtTenBan.Text = b.TenBan;
                    if (b.TinhTrang == true) rdbCoKhach.Checked = true;
                    else rdbTrong.Checked = true;
                }
            }
        }
        private void cmbKhuVuc0_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ban> List = (new BAL_Ban()).Get_BanTheoMaKhuVuc(cmbKhuVuc0.SelectedValue.ToString());
            lsvBan.Items.Clear();
            foreach (Ban b in List)
            {
                ListViewItem item = new ListViewItem(b.MaBan);
                if (b.MaKV != null)
                {
                    item.SubItems.Add(b.KhuVuc.TenKV);
                }
                else
                {
                    item.SubItems.Add("null");
                }
                item.SubItems.Add(b.TenBan);

                lsvBan.Items.Add(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text))
            {
                MessageBox.Show("Chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Ban b = (new BAL_Ban()).Get_Ban(txtMaBan.Text);
            if(b.TinhTrang == true)
            {
                MessageBox.Show("Bàn đang có khách!", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa bàn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Cập nhật các hóa đơn
                foreach(HoaDon hd in b.HoaDons)
                {
                    hd.MaBan = null;
                    (new BAL_HoaDon()).CapNhatHoaDon(hd);
                }
                //Xóa bàn
                (new BAL_Ban()).Xoa(b.MaBan);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Xóa bàn (" + b.MaBan + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";

                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
                LoadBan();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text))
            {
                MessageBox.Show("Chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Ban b = (new BAL_Ban()).Get_Ban(txtMaBan.Text);
            if (b != null) //Cập nhật
            {
                b.MaKV = cmbKhuVuc.SelectedValue.ToString();
                b.TenBan = txtTenBan.Text;
                b.TinhTrang = rdbCoKhach.Checked;

                (new BAL_Ban()).CapNhat(b);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Cập nhật bàn (" + b.MaBan + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
            }
            else //Thêm mới
            {
                b = new Ban();
                b.MaBan = txtMaBan.Text;
                b.MaKV = cmbKhuVuc.SelectedValue.ToString();
                b.TenBan = txtTenBan.Text;
                b.TinhTrang = false;

                (new BAL_Ban()).Them(b);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Thêm bàn (" + b.MaBan + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                btnXoa.Enabled = true;
                btnThem.Text = "Thêm";
            }
            txtMaBan.ResetText();
            txtTenBan.ResetText();
            cmbKhuVuc.SelectedIndex = 0;

            LoadBan();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnXoa.Enabled = false;

                txtMaBan.Text = (new BAL_Ban()).GetMaBanTiepTheo();
                cmbKhuVuc.SelectedIndex = 0;
                txtTenBan.ResetText();
                rdbTrong.Checked = true;

                txtTenBan.Focus();
            }
            else if (btnThem.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;

                txtMaBan.ResetText();
                cmbKhuVuc.SelectedIndex = 0;
                txtTenBan.ResetText();
                rdbTrong.Checked = true;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhMucBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.X))
                {
                    btnXoa_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.L))
                {
                    btnLuu_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.T))
                {
                    btnThem_Click(sender, e);
                }   
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                btnThoat_Click(sender, e);
            }
        }
    }
}
