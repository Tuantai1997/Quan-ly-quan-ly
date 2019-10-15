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
    public partial class frmCaLamViec : Form
    {
        public frmCaLamViec()
        {
            InitializeComponent();
        }

        private void frmCaLamViec_Load(object sender, EventArgs e)
        {
            LoadCa();
        }
        private void LoadCa()
        {
            List<CaLamViec> List = (new BAL_CaLamViec()).Get();
            lsvCa.Items.Clear();
            foreach(CaLamViec c in List)
            {
                ListViewItem item = new ListViewItem(c.MaCa);
                item.SubItems.Add(c.TenCa);
                item.SubItems.Add(c.GioBatDau.Value.ToString());
                item.SubItems.Add(c.GioKetThuc.Value.ToString());
                item.SubItems.Add(c.MucLuong.ToString());

                lsvCa.Items.Add(item);
            }
        }
        private void lsvCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvCa.SelectedItems.Count == 1)
            {
                CaLamViec ca = (new BAL_CaLamViec()).Get(lsvCa.SelectedItems[0].SubItems[0].Text);
                if(ca != null)
                {
                    txtMaCa.Text = ca.MaCa;
                    txtTenCa.Text = ca.TenCa;
                    dtpGioBatDau.Value = DateTime.Parse(ca.GioBatDau.ToString());
                    dtpGioKetThuc.Value = DateTime.Parse(ca.GioKetThuc.ToString());
                    nmMucLuong.Value = (Decimal)ca.MucLuong;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaCa.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn ca!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa ca làm việc này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return; 
            CaLamViec ca = (new BAL_CaLamViec()).Get(txtMaCa.Text.Trim());
            //Xóa chấm công
            foreach(PhanCong pc in ca.PhanCongs)
            {
                foreach(ChamCong cc in pc.ChamCongs)
                {
                    (new BAL_ChamCong()).Xoa(cc.ID, cc.MaNV, cc.MaCa, cc.MaKV);
                }
            }
            //Xóa phân công
            foreach (PhanCong pc in ca.PhanCongs)
            {
                (new BAL_PhanCong()).Xoa(pc.MaNV, pc.MaCa, pc.MaKV);
            }
            //Xóa ca
            (new BAL_CaLamViec()).Xoa(txtMaCa.Text.Trim());

            LichSuHoatDong ls = new LichSuHoatDong();
            ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
            ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
            ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
            ls.HoatDong = "Xóa ca làm việc (" + txtMaCa.Text + ")";
            ls.ThoiGian = DateTime.Now;
            ls.TinhTrang = "Thành công";
            (new BAL_LichSuHoatDong()).ThemLichSu(ls);

            txtMaCa.ResetText();
            txtTenCa.ResetText();
            dtpGioBatDau.Value = DateTime.Now.Date;
            dtpGioKetThuc.Value = DateTime.Now.Date;
            nmMucLuong.Value = 0;
            LoadCa();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCa.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn ca!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            CaLamViec ca = (new BAL_CaLamViec()).Get(txtMaCa.Text.Trim());
            if(ca != null)//Cập nhật
            {
                ca.TenCa = txtTenCa.Text.Trim();
                ca.GioBatDau = dtpGioBatDau.Value.TimeOfDay;
                ca.GioKetThuc = dtpGioKetThuc.Value.TimeOfDay;
                ca.MucLuong = (float)nmMucLuong.Value;

                (new BAL_CaLamViec()).CapNhat(ca);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Cập nhật ca làm việc (" + ca.MaCa + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
            }
            else//Thêm mới
            {
                ca = new CaLamViec();
                ca.MaCa = txtMaCa.Text.Trim();
                ca.TenCa = txtTenCa.Text.Trim();
                ca.GioBatDau = dtpGioBatDau.Value.TimeOfDay;
                ca.GioKetThuc = dtpGioKetThuc.Value.TimeOfDay;
                ca.MucLuong = (float)nmMucLuong.Value;

                (new BAL_CaLamViec()).Them(ca);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Thêm ca làm việc (" + ca.MaCa + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                btnXoa.Enabled = true;
                btnThem.Text = "Thêm";
            }

            txtMaCa.ResetText();
            txtTenCa.ResetText();
            dtpGioBatDau.Value = DateTime.Now.Date;
            dtpGioKetThuc.Value = DateTime.Now.Date;
            nmMucLuong.Value = 0;
            LoadCa();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnXoa.Enabled = false;

                txtMaCa.Text = (new BAL_CaLamViec()).GetMaCaTiepTheo();
                txtTenCa.ResetText();
                dtpGioBatDau.Value = DateTime.Now.Date;
                dtpGioKetThuc.Value = DateTime.Now.Date;
                nmMucLuong.Value = 0;

                txtTenCa.Focus();
            }
            else if (btnThem.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;

                txtMaCa.ResetText();
                txtTenCa.ResetText();
                dtpGioBatDau.Value = DateTime.Now.Date;
                dtpGioKetThuc.Value = DateTime.Now.Date;
                nmMucLuong.Value = 0;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmCaLamViec_KeyDown(object sender, KeyEventArgs e)
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
