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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        private void LoadNhanVien()
        {
            lsvNhanVien.Items.Clear();
            List<NhanVien> List = (new BAL_NhanVien()).Get_NhanVien();
            foreach(NhanVien nv in List)
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.NgaySinh.Value.ToShortDateString());
                item.SubItems.Add(nv.Phai.Value == true ? "Nam" : "Nữ");
                item.SubItems.Add(nv.CMND);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.DiaChi);
                item.SubItems.Add(nv.NgayVaoLam.Value.ToShortDateString());
                item.SubItems.Add(nv.MatKhau);
                item.SubItems.Add(nv.Quyen.Value == true ? "Admin" : "Nhân viên");

                lsvNhanVien.Items.Add(item);
            }
        }
        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvNhanVien.SelectedItems.Count == 1)
            {
                NhanVien nv = (new BAL_NhanVien()).Get_NhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text);
                if(nv != null)
                {
                    txtMaNV.Text = nv.MaNV;
                    txtHoTen.Text = nv.HoTen;
                    dtpNgaySinh.Value = nv.NgaySinh.Value;
                    if (nv.Phai.Value == true) rdbNam.Checked = true;
                    else rdbNu.Checked = true;
                    txtCMND.Text = nv.CMND;
                    txtSDT.Text = nv.SDT;
                    txtDiaChi.Text = nv.DiaChi;
                    dtpNgayVaoLam.Value = nv.NgayVaoLam.Value;
                    txtMatKhau.Text = nv.MatKhau;
                    if (nv.Quyen.Value == true) rdbAdmin.Checked = true;
                    else rdbNhanVien.Checked = true;

                    if (nv.MaNV == "Admin") { grbQuyen.Enabled = false; txtMatKhau.Enabled = false; }
                    else { grbQuyen.Enabled = true; txtMatKhau.Enabled = true;}
                }
            }
        }
        private void ResetDisplay()
        {
            txtMaNV.ResetText();
            txtHoTen.ResetText();
            dtpNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = true;
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            dtpNgayVaoLam.Value = DateTime.Now;
            txtMatKhau.ResetText();
            rdbNhanVien.Checked = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text.Trim() == "Admin")
            {
                MessageBox.Show("Không thể xóa nhân viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No) return;
            NhanVien nv = (new BAL_NhanVien()).Get_NhanVien(txtMaNV.Text.Trim());
            //Cập nhật MaNV ở PhieuChi thành null
            foreach(PhieuChi pc in nv.PhieuChies)
            {
                pc.MaNV = null;
                (new BAL_PhieuChi()).CapNhat(pc);
            }
            //Cập nhật MaNV ở HoaDon thành null
            foreach (HoaDon hd in nv.HoaDons)
            {
                hd.MaNV = null;
                (new BAL_HoaDon()).CapNhatHoaDon(hd);
            }
            //Xóa ChamCong
            List<ChamCong> List = (new BAL_ChamCong()).Get();
            foreach(ChamCong cc in List)
            {
                if(cc.MaNV == nv.MaNV) (new BAL_ChamCong()).Xoa(cc.ID, cc.MaNV, cc.MaCa, cc.MaKV);
            }
            //Xóa PhanCong
            foreach(PhanCong pc in nv.PhanCongs)
            {
                (new BAL_PhanCong()).Xoa(pc.MaNV, pc.MaCa, pc.MaKV);
            }
            //Xóa NhanVien
            (new BAL_NhanVien()).Xoa(nv.MaNV);

            LichSuHoatDong ls = new LichSuHoatDong();
            ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
            ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
            ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
            ls.HoatDong = "Xóa nhân viên (" + nv.MaNV + ")";
            ls.ThoiGian = DateTime.Now;
            ls.TinhTrang = "Thành công";
            (new BAL_LichSuHoatDong()).ThemLichSu(ls);

            ResetDisplay();
            LoadNhanVien();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NhanVien nv = (new BAL_NhanVien()).Get_NhanVien(txtMaNV.Text.Trim());
            if(nv != null)//Cập nhật
            {
                //Cập nhật nhân viên
                nv.HoTen = txtHoTen.Text.Trim();
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.Phai = rdbNam.Checked;
                nv.CMND = txtCMND.Text;
                nv.SDT = txtSDT.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.NgayVaoLam = dtpNgayVaoLam.Value;
                nv.MatKhau = txtMatKhau.Text;
                nv.Quyen = rdbAdmin.Checked;

                (new BAL_NhanVien()).CapNhat(nv);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Cập nhật nhân viên (" + nv.MaNV + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
            }
            else//Thêm mới
            {
                //Thêm NhanVien
                nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.HoTen = txtHoTen.Text.Trim();
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.Phai = rdbNam.Checked;
                nv.CMND = txtCMND.Text;
                nv.SDT = txtSDT.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.NgayVaoLam = dtpNgayVaoLam.Value;
                nv.MatKhau = txtMatKhau.Text;
                nv.Quyen = rdbAdmin.Checked;
                nv.Status = false;

                (new BAL_NhanVien()).Them(nv);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Thêm nhân viên (" + nv.MaNV + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;
            }

            ResetDisplay();
            LoadNhanVien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnXoa.Enabled = false;

                ResetDisplay();
                txtMaNV.Text = (new BAL_NhanVien()).GetMaNVTiepTheo();
                txtHoTen.Focus();
            }
            else if (btnThem.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;

                ResetDisplay();
            }
        }
        private void lsvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            if(lsvNhanVien.SelectedItems.Count == 1)
            {
                (new frmPhanCong(lsvNhanVien.SelectedItems[0].SubItems[0].Text)).ShowDialog();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lsvNhanVien.Items.Clear();
            string str = txtTimKiem.Text.Trim().ToUpper();
            List<NhanVien> List = (new BAL_NhanVien()).Get_NhanVien();
            List<NhanVien> List0 = new List<NhanVien>();
            if(str == "NAM")
            {
                List0 = (from nv in List
                         where nv.Phai.Value == true
                         select nv).ToList();
            }
            else if(str == "NỮ")
            {
                List0 = (from nv in List
                         where nv.Phai.Value == false
                         select nv).ToList();
            }
            else if (str == "ADMIN")
            {
                List0 = (from nv in List
                         where nv.Quyen.Value == true
                         select nv).ToList();
            }
            else if (str == "NHÂN VIÊN")
            {
                List0 = (from nv in List
                         where nv.Quyen.Value == false
                         select nv).ToList();
            }
            else
            {
                List0 = (from nv in List
                             where nv.MaNV.Contains(str) || nv.HoTen.ToUpper().Contains(str) || nv.SDT.Contains(str)
                             || nv.CMND.Contains(str) || nv.DiaChi.ToUpper().Contains(str)
                             || nv.NgaySinh.Value.ToShortDateString().Contains(str)
                             || nv.NgayVaoLam.Value.ToShortDateString().Contains(str)
                             select nv).ToList();
            }

            foreach (NhanVien nv in List0)
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.NgaySinh.Value.ToShortDateString());
                item.SubItems.Add(nv.Phai.Value == true ? "Nam" : "Nữ");
                item.SubItems.Add(nv.CMND);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.DiaChi);
                item.SubItems.Add(nv.NgayVaoLam.Value.ToShortDateString());
                item.SubItems.Add(nv.MatKhau);
                item.SubItems.Add(nv.Quyen.Value == true ? "Admin" : "Nhân viên");

                lsvNhanVien.Items.Add(item);
            }
        }
        private void frmNhanVien_KeyDown(object sender, KeyEventArgs e)
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
