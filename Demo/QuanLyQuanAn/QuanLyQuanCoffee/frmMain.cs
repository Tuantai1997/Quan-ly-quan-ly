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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Program.NhanVienDangDangNhap.Quyen.Value == false)
            {
                TSMI_NhanSu.Visible = false;
                TSB_DiemDanh.Visible = false;
                //TSMI_DMPhieuChi.Visible = false;
                //TSB_PhieuChi.Visible = false;
            }
            TSL_Welcome_Click(new ToolStripLabel(), new EventArgs());

            this.Text = "Quản lý quán ăn -- " + Program.NhanVienDangDangNhap.MaNV + " -- " + Program.NhanVienDangDangNhap.HoTen + " -- " + "[" + (Program.NhanVienDangDangNhap.Quyen == true ? "Admin" : "Nhân viên") + "]";
        }

        #region ToolStripLable Welcome
        private void TSL_Welcome_MouseMove(object sender, MouseEventArgs e)
        {
            TSL_Welcome.ForeColor = Color.Blue;
        }
        private void TSL_Welcome_MouseLeave(object sender, EventArgs e)
        {
            TSL_Welcome.ForeColor = Color.Black;
        }
        private void TSL_Welcome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Load form welcome
            frmWelcome frm = new frmWelcome();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Parent = panel1;
            frm.Show();
            panel1.Controls.Add(frm);
        }
        #endregion
        #region Hệ thống
        private void TSMI_DoiMatKhau_Click(object sender, EventArgs e)
        {
            (new frmDoiMatKhau()).ShowDialog();
        }
        private void TSMI_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region ToolStripButton
        private void TSB_PhieuChi_Click(object sender, EventArgs e)
        {
            TSMI_DMPhieuChi_Click(new ToolStripMenuItem(), new EventArgs());
        }
        private void TSB_QuanLyBanHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Load form quản lý
            frmQuanLyBanHang frm = new frmQuanLyBanHang();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Parent = panel1;
            frm.Show();
            panel1.Controls.Add(frm);
        }
        private void TSB_HoaDon_Click(object sender, EventArgs e)
        {
            TSMI_DMHoaDon_Click(new ToolStripMenuItem(), new EventArgs());
        }
        private void TSB_NhapHangVaoKho_Click(object sender, EventArgs e)
        {
            TSMI_NhapHangVaoKho_Click(new ToolStripMenuItem(), new EventArgs());
        }
        private void TSB_DiemDanh_Click(object sender, EventArgs e)
        {
            TSMI_DiemDanh_Click(new ToolStripMenuItem(), new EventArgs());
        }
        #endregion
        #region Khác
        private void TSMI_ThongTinQuan_Click(object sender, EventArgs e)
        {
            (new frmEditThongTinQuan()).ShowDialog();
            if (panel1.Controls[0].Name == "frmWelcome")
            {
                TSL_Welcome_Click(new ToolStripLabel(), new EventArgs());
            }
        }
        private void TSMI_ThongTinPhanMem_Click(object sender, EventArgs e)
        {
            (new frmInfo()).ShowDialog();
        }
        #endregion
        #region Danh mục
        private void TSMI_DMMon_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Load form
            frmDanhMucMon frm = new frmDanhMucMon();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Parent = panel1;
            frm.Show();
            panel1.Controls.Add(frm);
        }
        private void TSMI_DMLoaiMon_Click(object sender, EventArgs e)
        {
            (new frmDanhMucLoaiMon()).ShowDialog();

            if(panel1.Controls[0].Name == "frmDanhMucMon")
            {
                TSMI_DMMon_Click(new ToolStripMenuItem(), new EventArgs());
            }
            else if (panel1.Controls[0].Name == "frmQuanLyBanHang")
            {
                TSMI_QuanLyBanHang_Click(new ToolStripMenuItem(), new EventArgs());
            }
        }
        private void TSMI_DMBan_Click(object sender, EventArgs e)
        {
            (new frmDanhMucBan()).ShowDialog();
            if (panel1.Controls[0].Name == "frmQuanLyBanHang")
            {
                TSMI_QuanLyBanHang_Click(new ToolStripMenuItem(), new EventArgs());
            }
        }
        private void TSMI_DMKhuVuc_Click(object sender, EventArgs e)
        {
            (new frmDanhMucKhuVuc()).ShowDialog();
            if (panel1.Controls[0].Name == "frmQuanLyBanHang")
            {
                TSMI_QuanLyBanHang_Click(new ToolStripMenuItem(), new EventArgs());
            }
        }
        private void TSMI_DMPhieuChi_Click(object sender, EventArgs e)
        {
            (new frmDanhMucPhieuChi()).ShowDialog();
        }
        private void TSMI_DMHoaDon_Click(object sender, EventArgs e)
        {
            (new frmDanhMucHoaDon()).ShowDialog();
            if (panel1.Controls[0].Name == "frmQuanLyBanHang")
            {
                TSMI_QuanLyBanHang_Click(new ToolStripMenuItem(), new EventArgs());
            }
        }
        #endregion
        #region Hoạt động
        private void TSMI_QuanLyBanHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Load form quản lý
            frmQuanLyBanHang frm = new frmQuanLyBanHang();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Parent = panel1;
            frm.Show();
            panel1.Controls.Add(frm);
        }
        private void TSMI_NhapHangVaoKho_Click(object sender, EventArgs e)
        {
            (new frmNhapHang()).ShowDialog();
            if (panel1.Controls[0].Name == "frmQuanLyBanHang")
            {
                TSMI_QuanLyBanHang_Click(new ToolStripMenuItem(), new EventArgs());
            }
            if (panel1.Controls[0].Name == "frmDanhMucMon")
            {
                TSMI_DMMon_Click(new ToolStripMenuItem(), new EventArgs());
            }
        }
        private void TSMI_ThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            (new frmThongKeDoanhThuThang()).ShowDialog();
        }
        private void TSMI_ThongKeDoanhThuNgay_Click(object sender, EventArgs e)
        {
            (new frmThongKeDoanhThuNgay()).ShowDialog();
        }
        private void TSMI_ThongKeMon_Click(object sender, EventArgs e)
        {
            (new frmThongKeMon()).ShowDialog();
        }
        private void TSMI_LichSuHoatDong_Click(object sender, EventArgs e)
        {
            (new frmLichSuHoatDong()).ShowDialog();
        }
        #endregion
        #region NhanSu
        private void TSMI_DanhMucNhanVien_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Load form
            frmNhanVien frm = new frmNhanVien();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Parent = panel1;
            frm.Show();
            panel1.Controls.Add(frm);
        }
        private void TSMI_CaLamViec_Click(object sender, EventArgs e)
        {
            (new frmCaLamViec()).ShowDialog();
        }
        private void TSMI_DiemDanh_Click(object sender, EventArgs e)
        {
            (new frmDiemDanh()).ShowDialog();
        }
        private void TSMI_TinhLuong_Click(object sender, EventArgs e)
        {
            (new frmTinhLuong()).ShowDialog();
        }
        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            LichSuHoatDong ls = new LichSuHoatDong();
            ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
            ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
            ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
            ls.HoatDong = "Đăng xuất!";
            ls.ThoiGian = DateTime.Now;
            ls.TinhTrang = "Thành công";
            (new BAL_LichSuHoatDong()).ThemLichSu(ls);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
