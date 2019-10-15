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
    public partial class frmDanhMucMon : Form
    {
        public frmDanhMucMon()
        {
            InitializeComponent();
        }

        private void frmDanhMucMon_Load(object sender, EventArgs e)
        {
            cmbLoaiMon.DataSource = (new BAL_LoaiMon()).Get_LoaiMon();
            cmbLoaiMon.DisplayMember = "TenLoaiMon";
            cmbLoaiMon.ValueMember = "MaLoaiMon";

            List<LoaiMon> List1 = (new BAL_LoaiMon()).Get_LoaiMon();
            LoaiMon lm = new LoaiMon()
            {
                MaLoaiMon = "ALL",
                TenLoaiMon = "Tất cả"
            };
            List1.Insert(0, lm);
            cmbLoaiMon0.DataSource = List1;
            cmbLoaiMon0.DisplayMember = "TenLoaiMon";
            cmbLoaiMon0.ValueMember = "MaLoaiMon";
            
            LoadMon();
        }
        private void LoadMon()
        {
            lsvMon.Items.Clear();
            List<Mon> List = (new BAL_Mon()).Get_MonTheoMaLoaiMon(cmbLoaiMon0.SelectedValue.ToString());
            if (List.Count <= 0) return;
            foreach (Mon m in List)
            {
                ListViewItem item = new ListViewItem(m.MaMon);
                if(m.MaLoaiMon != null)
                {
                    item.SubItems.Add(m.LoaiMon.TenLoaiMon);
                }
                else
                {
                    item.SubItems.Add("null");
                }
                item.SubItems.Add(m.TenMon);
                item.SubItems.Add(m.SoLuong.Value.ToString());
                item.SubItems.Add(m.DonGia.Value.ToString());
                item.SubItems.Add(m.GiaNhap.Value.ToString());

                lsvMon.Items.Add(item);
            }
        }
        private void cmbLoaiMon0_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMon();
        }
        private void lsvMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvMon.SelectedItems.Count == 1)
            {
                Mon m = (new BAL_Mon()).Get_Mon(lsvMon.SelectedItems[0].SubItems[0].Text);
                if(m != null)
                {
                    txtMaMon.Text = m.MaMon;
                    if(m.MaLoaiMon != null)
                    {
                        cmbLoaiMon.SelectedValue = m.MaLoaiMon;
                    }
                    else
                    {
                        cmbLoaiMon.SelectedValue = "";
                    }
                    txtTenMon.Text = m.TenMon;
                    nmSoLuong.Value = m.SoLuong.Value;
                    txtDonGia.Text = m.DonGia.Value.ToString();
                    txtGiaNhap.Text = m.GiaNhap.Value.ToString();
                }
            }
        }
        private int Get_SLHD(string MaMon)
        {
            List<ChiTietHoaDon> List = (new BAL_ChiTietHoaDon()).Get_ChiTietHoaDon();
            int dem = 0;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].MaMon == MaMon) dem++;
            }
            return dem;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                MessageBox.Show("Chưa chọn món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(Get_SLHD(txtMaMon.Text) > 0)
            {
                DialogResult dr = MessageBox.Show("Hiện tại có " + Get_SLHD(txtMaMon.Text) + " hóa đơn chứa món này. Nếu xóa món này thì tất cả các chi tiết hóa đơn có liên quan cũng sẽ bị xóa. Bạn có chắc muốn xóa món này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;
            }
            //Xóa chi tiết hóa đơn
            Mon m = (new BAL_Mon()).Get_Mon(txtMaMon.Text);
            foreach(ChiTietHoaDon ct in m.ChiTietHoaDons)
            {
                (new BAL_ChiTietHoaDon()).XoaChiTietHoaDon(ct.MaHD, ct.MaMon);
            }
            //Xóa món
            (new BAL_Mon()).XoaMon(txtMaMon.Text);

            LichSuHoatDong ls = new LichSuHoatDong();
            ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
            ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
            ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
            ls.HoatDong = "Xóa món (" + txtMaMon.Text + ")";
            ls.ThoiGian = DateTime.Now;
            ls.TinhTrang = "Thành công";
            (new BAL_LichSuHoatDong()).ThemLichSu(ls);

            txtMaMon.ResetText();
            cmbLoaiMon.SelectedIndex = 0;
            txtTenMon.ResetText();
            nmSoLuong.Value = 0;
            txtDonGia.Text = "0";
            txtGiaNhap.Text = "0";
            LoadMon();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                MessageBox.Show("Chưa chọn món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Mon m = (new BAL_Mon()).Get_Mon(txtMaMon.Text);
            if(m != null) //Cập nhật
            {
                m.TenMon = txtTenMon.Text.Trim();
                if(cmbLoaiMon.SelectedValue != null)
                {
                   m.MaLoaiMon = cmbLoaiMon.SelectedValue.ToString();
                }
                else
                {
                    m.MaLoaiMon = null;
                }

                m.SoLuong = (int)nmSoLuong.Value;
                m.DonGia = Convert.ToDouble(txtDonGia.Text);
                m.GiaNhap = Convert.ToDouble(txtGiaNhap.Text);
                if (string.IsNullOrEmpty(txtTenMon.Text))
                {
                    MessageBox.Show("Chưa nhập tên món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(m.SoLuong.ToString()))
                {
                    MessageBox.Show("Yêu cầu nhập số lượng món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (m.SoLuong == 0)
                {
                    MessageBox.Show("Số lượng món không thể bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                (new BAL_Mon()).CapNhatMon(m);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Cập nhật món (" + m.MaMon + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
            }
            else //Thêm mới
            {
                m = new Mon();
                m.MaMon = txtMaMon.Text;
                m.TenMon = txtTenMon.Text.Trim();
                if (cmbLoaiMon.SelectedValue != null)
                {
                    m.MaLoaiMon = cmbLoaiMon.SelectedValue.ToString();
                }
                else
                {
                    m.MaLoaiMon = null;
                }
                m.SoLuong = (int)nmSoLuong.Value;
                m.DonGia = Convert.ToDouble(txtDonGia.Text);
                m.GiaNhap = Convert.ToDouble(txtGiaNhap.Text);
                if (string.IsNullOrEmpty(txtTenMon.Text) )
                {
                    MessageBox.Show("Chưa nhập tên món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(m.SoLuong.ToString()))
                {
                    MessageBox.Show("Yêu cầu nhập số lượng món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (m.SoLuong == 0)
                {
                    MessageBox.Show("Số lượng món không thể bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                (new BAL_Mon()).ThemMon(m);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Thêm món (" + m.MaMon + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
            }
            btnThem.Text = "Thêm";
            btnXoa.Enabled = true;

            txtMaMon.ResetText();
            cmbLoaiMon.SelectedIndex = 0;
            txtTenMon.ResetText();
            nmSoLuong.Value = 0;
            txtDonGia.Text = "0";
            txtGiaNhap.Text = "0";
            LoadMon();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnXoa.Enabled = false;

                txtMaMon.Text = (new BAL_Mon()).GetMaMonTiepTheo();
                cmbLoaiMon.SelectedIndex = 0;
                txtTenMon.ResetText();
                nmSoLuong.Value = 0;
                txtDonGia.Text = "0";
                txtGiaNhap.Text = "0";

                txtTenMon.Focus();
            }
            else if (btnThem.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;

                txtMaMon.ResetText();
                cmbLoaiMon.SelectedIndex = 0;
                txtTenMon.ResetText();
                nmSoLuong.Value = 0;
                txtDonGia.Text = "0";
                txtGiaNhap.Text = "0";
            }
        }

        private void nmSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lsvMon.Items.Clear();
            string str = txtTimKiem.Text.Trim().ToUpper();
            List<Mon> List = (new BAL_Mon()).Get_MonTheoMaLoaiMon(cmbLoaiMon0.SelectedValue.ToString());
            var List0 = (from m in List
                         where m.MaMon.Contains(str) || m.TenMon.ToUpper().Contains(str)
                         select m).ToList();
            if (List0.Count <= 0) return;
            foreach (Mon m in List0)
            {
                ListViewItem item = new ListViewItem(m.MaMon);
                if (m.MaLoaiMon != null)
                {
                    item.SubItems.Add(m.LoaiMon.TenLoaiMon);
                }
                else
                {
                    item.SubItems.Add("null");
                }
                item.SubItems.Add(m.TenMon);
                item.SubItems.Add(m.SoLuong.Value.ToString());
                item.SubItems.Add(m.DonGia.Value.ToString());
                item.SubItems.Add(m.GiaNhap.Value.ToString());

                lsvMon.Items.Add(item);
            }
        }
        private void frmDanhMucMon_KeyDown(object sender, KeyEventArgs e)
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
        }
    }
}
