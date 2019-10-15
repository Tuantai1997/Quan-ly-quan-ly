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
    public partial class frmLichSuHoatDong : Form
    {
        public frmLichSuHoatDong()
        {
            InitializeComponent();
        }

        private void frmLichSuHoatDong_Load(object sender, EventArgs e)
        {
            if(Program.NhanVienDangDangNhap.Quyen == false)
            {
                TSB_Xoa.Visible = false;
                TSB_XoaTatCa.Visible = false;
                TSCMB_HienThi.Visible = false;
                LoadLichSuCaNhan();
            }
            else
            {
                TSCMB_HienThi.SelectedIndex = 0;
            }
        }
        private void LoadLichSuCaNhan()
        {
            lsvLichSuHoatDong.Items.Clear();
            List<LichSuHoatDong> List = (new BAL_LichSuHoatDong()).Get_TheoMaNV(Program.NhanVienDangDangNhap.MaNV);
            foreach(LichSuHoatDong ls in List)
            {
                ListViewItem item = new ListViewItem(ls.MaLichSu);
                item.SubItems.Add(ls.MaNV);
                item.SubItems.Add(ls.HoTen);
                item.SubItems.Add(ls.HoatDong);
                item.SubItems.Add(ls.ThoiGian.Value.ToString());
                item.SubItems.Add(ls.TinhTrang);
                item.SubItems.Add(ls.MaNV);

                lsvLichSuHoatDong.Items.Add(item);
            }
        }
        private void LoadTatCaLichSu()
        {
            lsvLichSuHoatDong.Items.Clear();
            List<LichSuHoatDong> List = (new BAL_LichSuHoatDong()).Get();
            foreach (LichSuHoatDong ls in List)
            {
                ListViewItem item = new ListViewItem(ls.MaLichSu);
                item.SubItems.Add(ls.MaNV);
                item.SubItems.Add(ls.HoTen);
                item.SubItems.Add(ls.HoatDong);
                item.SubItems.Add(ls.ThoiGian.Value.ToString());
                item.SubItems.Add(ls.TinhTrang);
                item.SubItems.Add(ls.MaNV);

                lsvLichSuHoatDong.Items.Add(item);
            }
        }
        private void TSB_Xoa_Click(object sender, EventArgs e)
        {
            if (lsvLichSuHoatDong.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lịch sử muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (ListViewItem item in lsvLichSuHoatDong.SelectedItems)
            {
                (new BAL_LichSuHoatDong()).XoaLichSu(item.SubItems[0].Text);
            }
            TSCMB_HienThi_SelectedIndexChanged(new ToolStripComboBox(), new EventArgs());
        }
        private void TSB_XoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ lịch sử (kể cả lịch sử của những nhân viên khác)?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            List<LichSuHoatDong> List = (new BAL_LichSuHoatDong()).Get();
            foreach(LichSuHoatDong ls in List)
            {
                (new BAL_LichSuHoatDong()).XoaLichSu(ls.MaLichSu);
            }
            TSCMB_HienThi_SelectedIndexChanged(new ToolStripComboBox(), new EventArgs());
        }
        private void TSCMB_HienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TSCMB_HienThi.SelectedIndex == 0)
            {
                LoadLichSuCaNhan();
            }
            else
            {
                LoadTatCaLichSu();
            }
        }
        private void TSB_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
