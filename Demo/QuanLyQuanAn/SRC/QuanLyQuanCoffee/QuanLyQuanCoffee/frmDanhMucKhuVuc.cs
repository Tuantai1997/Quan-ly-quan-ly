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
    public partial class frmDanhMucKhuVuc : Form
    {
        public frmDanhMucKhuVuc()
        {
            InitializeComponent();
        }

        private void frmDanhMucKhuVuc_Load(object sender, EventArgs e)
        {
            LoadKhuVuc();
        }
        private void LoadKhuVuc()
        {
            List<KhuVuc> List = (new BAL_KhuVuc()).Get_KhuVuc();
            lsvKhuVuc.Items.Clear();
            foreach(KhuVuc kv in List)
            {
                ListViewItem item = new ListViewItem(kv.MaKV);
                item.SubItems.Add(kv.TenKV);

                lsvKhuVuc.Items.Add(item);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhuVuc.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn khu vực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            KhuVuc kv = (new BAL_KhuVuc()).Get_KhuVuc(txtMaKhuVuc.Text);
            if(kv != null)
            {
                //Nếu có bàn đang có khách thì không cho xóa
                foreach(Ban b in kv.Bans)
                {
                    if((new BAL_Ban()).Get_HoaDonBanChuaThanhToanTheoMaBan(b.MaBan) != null)
                    {
                        MessageBox.Show("Khu vực này có " + b.TenBan + " chưa thanh toán!", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa khu vực này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;
                //Cập nhật mã bàn trong các hóa đơn liên quan thành null
                foreach(Ban b in kv.Bans)
                {
                    foreach(HoaDon hd in b.HoaDons)
                    {
                        hd.MaBan = null;
                        (new BAL_HoaDon()).CapNhatHoaDon(hd);
                    }
                }
                //Xóa bàn
                foreach(Ban b in kv.Bans)
                {
                    (new BAL_Ban()).Xoa(b.MaBan);
                }
                //Xóa chấm công
                foreach(PhanCong pc in kv.PhanCongs)
                {
                    foreach(ChamCong cc in pc.ChamCongs)
                    {
                        (new BAL_ChamCong()).Xoa(cc.ID, cc.MaNV, cc.MaCa, cc.MaKV);
                    }
                }
                //Xóa phân công
                foreach (PhanCong pc in kv.PhanCongs)
                {
                    (new BAL_PhanCong()).Xoa(pc.MaNV, pc.MaCa, pc.MaKV);
                }
                //Xóa khu vực
                (new BAL_KhuVuc()).Xoa(kv.MaKV);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Xóa khu vực (" + kv.MaKV + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                txtMaKhuVuc.ResetText();
                txtTenKhuVuc.ResetText();
                LoadKhuVuc();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaKhuVuc.Text.Trim()))
            {
                MessageBox.Show("Chưa chọn khu vực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            KhuVuc kv = (new BAL_KhuVuc()).Get_KhuVuc(txtMaKhuVuc.Text);
            if(kv != null) //Cập nhật
            {
                kv.TenKV = txtTenKhuVuc.Text;
                (new BAL_KhuVuc()).CapNhat(kv);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Cập nhật khu vực (" + kv.MaKV + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);
            }
            else //Thêm mới
            {
                kv = new KhuVuc();
                kv.MaKV = txtMaKhuVuc.Text;
                kv.TenKV = txtTenKhuVuc.Text;
                (new BAL_KhuVuc()).Them(kv);

                LichSuHoatDong ls = new LichSuHoatDong();
                ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                ls.HoatDong = "Thêm khu vực (" + kv.MaKV + ")";
                ls.ThoiGian = DateTime.Now;
                ls.TinhTrang = "Thành công";
                (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                btnXoa.Enabled = true;
                btnThem.Text = "Thêm";
            }
            txtMaKhuVuc.ResetText();
            txtTenKhuVuc.ResetText();
            LoadKhuVuc();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnXoa.Enabled = false;

                txtMaKhuVuc.Text = (new BAL_KhuVuc()).GetMaKhuVucTiepTheo();
                txtTenKhuVuc.ResetText();
                txtTenKhuVuc.Focus();
            }
            else if (btnThem.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;

                txtMaKhuVuc.ResetText();
                txtTenKhuVuc.ResetText();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvKhuVuc.SelectedItems.Count == 1)
            {
                KhuVuc kv = (new BAL_KhuVuc()).Get_KhuVuc(lsvKhuVuc.SelectedItems[0].SubItems[0].Text);
                if(kv != null)
                {
                    txtMaKhuVuc.Text = kv.MaKV;
                    txtTenKhuVuc.Text = kv.TenKV;
                }
            }
        }

        private void frmDanhMucKhuVuc_KeyDown(object sender, KeyEventArgs e)
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
