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
    public partial class frmTinhLuong : Form
    {
        public frmTinhLuong()
        {
            InitializeComponent();
        }
        private void frmBangChamCong_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                TSC_Thang.Items.Add(i);
            }
            for (int i = 2012; i <= DateTime.Now.Year; i++)
            {
                TSC_Nam.Items.Add(i);
            }
            TSC_Thang.SelectedItem = DateTime.Now.Month;
            TSC_Nam.SelectedItem = DateTime.Now.Year;
        }
        private void TSC_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TSC_Thang.SelectedItem != null && TSC_Nam.SelectedItem != null)
            {
                LoadBangChamCong();
            }
        }
        private void TSC_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TSC_Thang.SelectedItem != null && TSC_Nam.SelectedItem != null)
            {
                LoadBangChamCong();
            }
        }
        private void LoadBangChamCong()
        {
            lsvChamCong.Items.Clear();
            foreach(VW_ChamCong cc in (new CoffeeEntities()).VW_ChamCong)
            {
                if(cc.Thang == (int)TSC_Thang.SelectedItem && cc.Nam == (int)TSC_Nam.SelectedItem)
                {
                    ListViewItem item = new ListViewItem(cc.MaNV);
                    item.SubItems.Add(cc.HoTen);
                    item.SubItems.Add(cc.TenCa);
                    item.SubItems.Add(cc.TenKV);
                    item.SubItems.Add(cc.SoCaLam.Value.ToString());
                    item.SubItems.Add(cc.Luong.Value.ToString());

                    lsvChamCong.Items.Add(item);
                }
            }  
        }
        private void TSB_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa bảng chấm công tháng " + (int)TSC_Thang.SelectedItem + "/" + (int)TSC_Nam.SelectedItem + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            List<ChamCong> List = (new BAL_ChamCong()).Get();
            foreach(ChamCong cc in List)
            {
                if(cc.Thang == (int)TSC_Thang.SelectedItem && cc.Nam == (int)TSC_Nam.SelectedItem)
                {
                    (new BAL_ChamCong()).Xoa(cc.ID, cc.MaNV, cc.MaCa, cc.MaKV);
                }
            }
            LoadBangChamCong();
        }
        private void TSB_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
