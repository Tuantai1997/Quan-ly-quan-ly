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
    public partial class frmDanhMucLoaiMon : Form
    {
        public frmDanhMucLoaiMon()
        {
            InitializeComponent();
        }

        private void frmDanhMucLoaiMon_Load(object sender, EventArgs e)
        {
            LoadLoaiMon();
        }
        private void LoadLoaiMon()
        {
            List<LoaiMon> List = (new BAL_LoaiMon()).Get_LoaiMon();
            lsvLoaiMon.Items.Clear();
            foreach(LoaiMon lm in List)
            {
                ListViewItem item = new ListViewItem(lm.MaLoaiMon);
                item.SubItems.Add(lm.TenLoaiMon);

                lsvLoaiMon.Items.Add(item);
            }
        }
        private void lsvLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvLoaiMon.SelectedItems.Count == 1)
            {
                LoaiMon lm = (new BAL_LoaiMon()).Get_LoaiMon(lsvLoaiMon.SelectedItems[0].SubItems[0].Text);
                if(lm != null)
                {
                    txtMaLoaiMon.Text = lm.MaLoaiMon;
                    txtTenLoaiMon.Text = lm.TenLoaiMon;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnXoa.Enabled = false;

                txtMaLoaiMon.Text = (new BAL_LoaiMon()).GetMaLoaiMonTiepTheo();
                txtTenLoaiMon.ResetText();
                txtTenLoaiMon.Focus();
            }
            else if (btnThem.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;

                txtMaLoaiMon.ResetText();
                txtTenLoaiMon.ResetText();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaLoaiMon.Text))
            {
                MessageBox.Show("Chưa chọn loại món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoaiMon lm = (new BAL_LoaiMon()).Get_LoaiMon(txtMaLoaiMon.Text);
            if (lm != null) //Cập nhật
            {
                lm.TenLoaiMon = txtTenLoaiMon.Text;
                (new BAL_LoaiMon()).CapNhatLoaiMon(lm);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Cập nhật loại món (" + lm.MaLoaiMon + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
            }
            else //Thêm mới
            {
                lm = new LoaiMon();
                lm.MaLoaiMon = txtMaLoaiMon.Text;
                lm.TenLoaiMon = txtTenLoaiMon.Text;
                (new BAL_LoaiMon()).ThemLoaiMon(lm);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Thêm loại món (" + lm.MaLoaiMon + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                btnXoa.Enabled = true;
                btnThem.Text = "Thêm";
            }
            txtMaLoaiMon.ResetText();
            txtTenLoaiMon.ResetText();
            LoadLoaiMon();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoaiMon.Text))
            {
                MessageBox.Show("Chưa chọn loại món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa loại món này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                //Set MaLoaiMon của tất cả các món thuộc loại món này thành null
                LoaiMon lm = (new BAL_LoaiMon()).Get_LoaiMon(txtMaLoaiMon.Text);
                foreach(Mon m in lm.Mons)
                {
                    m.MaLoaiMon = null;
                    (new BAL_Mon()).CapNhatMon(m);
                }
                //Xóa loại món
                (new BAL_LoaiMon()).XoaLoaiMon(txtMaLoaiMon.Text);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Xóa loại món (" + txtMaLoaiMon.Text + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                txtMaLoaiMon.ResetText();
                txtTenLoaiMon.ResetText();
                LoadLoaiMon();
            }
        }

        private void frmDanhMucLoaiMon_KeyDown(object sender, KeyEventArgs e)
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
