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
    public partial class frmDanhMucPhieuChi : Form
    {
        public frmDanhMucPhieuChi()
        {
            InitializeComponent();
        }

        private void frmDanhMucPhieuChi_Load(object sender, EventArgs e)
        {
            LoadPhieuChi();
        }
        private void LoadPhieuChi()
        {
            List<PhieuChi> List = (new BAL_PhieuChi()).Get();
            lsvPhieuChi.Items.Clear();
            foreach(PhieuChi pc in List)
            {
                ListViewItem item = new ListViewItem(pc.MaPhieuChi);
                if(pc.MaNV != null)
                {
                    item.SubItems.Add(pc.MaNV);
                    item.SubItems.Add(pc.NhanVien.HoTen);
                }
                else
                {
                    item.SubItems.Add("null");
                    item.SubItems.Add("null");
                }
                item.SubItems.Add(pc.MucDichChi);
                item.SubItems.Add(pc.TongTien.Value.ToString());
                item.SubItems.Add(pc.NgayChi.Value.ToShortDateString());

                lsvPhieuChi.Items.Add(item);
            }
        }
        private void lsvPhieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvPhieuChi.SelectedItems.Count == 1)
            {
                PhieuChi pc = (new BAL_PhieuChi()).Get(lsvPhieuChi.SelectedItems[0].SubItems[0].Text);
                if(pc != null)
                {
                    txtMaPhieu.Text = pc.MaPhieuChi;
                    txtMucDich.Text = pc.MucDichChi;
                    nmTongTien.Value = (Decimal)pc.TongTien.Value;
                    dtpNgayChi.Value = pc.NgayChi.Value;
                }
            }
        }
        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ResetDisplay()
        {
            txtMaPhieu.ResetText();
            txtMucDich.ResetText();
            nmTongTien.Value = 0;
            dtpNgayChi.Value = DateTime.Now;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaPhieu.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn phiếu chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu chi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No) return;
            (new BAL_PhieuChi()).Xoa(txtMaPhieu.Text);

            LichSuHoatDong ls = new LichSuHoatDong();
            ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
            ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
            ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
            ls.HoatDong = "Xóa phiếu chi (" + txtMaPhieu.Text + ")";
            ls.ThoiGian = DateTime.Now;
            ls.TinhTrang = "Thành công";
            (new BAL_LichSuHoatDong()).ThemLichSu(ls);

            ResetDisplay();
            LoadPhieuChi();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn phiếu chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PhieuChi pc = (new BAL_PhieuChi()).Get(txtMaPhieu.Text);
            if(pc != null)//Cập nhật
            {
                pc.MucDichChi = txtMucDich.Text;
                pc.TongTien = Convert.ToDouble(nmTongTien.Value);
                pc.NgayChi = dtpNgayChi.Value;
                pc.MaNV = Program.NhanVienDangDangNhap.MaNV;

                (new BAL_PhieuChi()).CapNhat(pc);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Cập nhật phiếu chi (" + pc.MaPhieuChi + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
            }
            else//Thêm mới
            {
                pc = new PhieuChi();
                pc.MaPhieuChi = txtMaPhieu.Text;
                pc.MucDichChi = txtMucDich.Text;
                pc.TongTien = Convert.ToDouble(nmTongTien.Value);
                pc.NgayChi = dtpNgayChi.Value;
                pc.MaNV = Program.NhanVienDangDangNhap.MaNV;

                (new BAL_PhieuChi()).Them(pc);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Thêm phiếu chi (" + pc.MaPhieuChi + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;
            }
            ResetDisplay();
            LoadPhieuChi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnXoa.Enabled = false;

                ResetDisplay();
                txtMaPhieu.Text = (new BAL_PhieuChi()).GetMaPhieuChiTiepTheo();
                txtMucDich.Focus();                
            }
            else if (btnThem.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;

                ResetDisplay();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lsvPhieuChi.Items.Clear();
            string str = txtTimKiem.Text.Trim().ToUpper();
            List<PhieuChi> List = (new BAL_PhieuChi()).Get();
            var List0 = (from pc in List
                         where pc.MaPhieuChi.Contains(str) || pc.MucDichChi.ToUpper().Contains(str) || pc.NgayChi.Value.ToShortDateString().Contains(str)
                         || (pc.MaNV != null && pc.MaNV.Contains(str)) || (pc.MaNV != null && pc.NhanVien.HoTen.ToUpper().Contains(str))
                         select pc);
            foreach (PhieuChi pc in List0)
            {
                ListViewItem item = new ListViewItem(pc.MaPhieuChi);
                if (pc.MaNV != null)
                {
                    item.SubItems.Add(pc.MaNV);
                    item.SubItems.Add(pc.NhanVien.HoTen);
                }
                else
                {
                    item.SubItems.Add("null");
                    item.SubItems.Add("null");
                }
                item.SubItems.Add(pc.MucDichChi);
                item.SubItems.Add(pc.TongTien.Value.ToString());
                item.SubItems.Add(pc.NgayChi.Value.ToShortDateString());

                lsvPhieuChi.Items.Add(item);
            }
        }
        private void frmDanhMucPhieuChi_KeyDown(object sender, KeyEventArgs e)
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
