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
    public partial class frmPhanCong : Form
    {
        public string MaNV = "";
        public frmPhanCong()
        {
            InitializeComponent();
        }
        public frmPhanCong(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }
        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            cmbCa.DataSource = (new BAL_CaLamViec()).Get();
            cmbCa.DisplayMember = "TenCa";
            cmbCa.ValueMember = "MaCa";

            cmbKhuVuc.DataSource = (new BAL_KhuVuc()).Get_KhuVuc();
            cmbKhuVuc.DisplayMember = "TenKV";
            cmbKhuVuc.ValueMember = "MaKV";

            this.cmbKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cmbKhuVuc_SelectedIndexChanged);
            this.cmbCa.SelectedIndexChanged += new System.EventHandler(this.cmbCa_SelectedIndexChanged);
            cmbCa_SelectedIndexChanged(new ComboBox(), new EventArgs());

            LoadData();
        }
        private void LoadData()
        {
            NhanVien nv = (new BAL_NhanVien()).Get_NhanVien(MaNV);
            if(nv != null)
            {
                lblNhanVien.Text = nv.MaNV + " / " + nv.HoTen;
                lsvPhanCong.Items.Clear();
                foreach(PhanCong pc in nv.PhanCongs)
                {
                    ListViewItem item = new ListViewItem(pc.KhuVuc.MaKV + "/" + pc.KhuVuc.TenKV);
                    item.SubItems.Add(pc.CaLamViec.MaCa + "/" + pc.CaLamViec.TenCa);
                    item.SubItems.Add(pc.CaLamViec.GioBatDau.Value.ToString());
                    item.SubItems.Add(pc.CaLamViec.GioKetThuc.Value.ToString());

                    lsvPhanCong.Items.Add(item);
                }
            }
        }
        private void cmbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaLamViec ca = (new BAL_CaLamViec()).Get(cmbCa.SelectedValue.ToString());
            KhuVuc kv = (new BAL_KhuVuc()).Get_KhuVuc(cmbKhuVuc.SelectedValue.ToString());
            if (ca != null)
            {
                btnAdd.Text = kv.TenKV + " / " + ca.TenCa + " (" + ca.GioBatDau.Value + " -> " + ca.GioKetThuc.Value + ")";
            }
        }
        private void cmbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCa_SelectedIndexChanged(new ComboBox(), new EventArgs());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhanCong pc = (new BAL_PhanCong()).Get(MaNV, cmbCa.SelectedValue.ToString(), cmbKhuVuc.SelectedValue.ToString());
            if(pc == null)
            {
                pc = new PhanCong();
                pc.MaNV = MaNV;
                pc.MaCa = cmbCa.SelectedValue.ToString();
                pc.MaKV = cmbKhuVuc.SelectedValue.ToString();

                (new BAL_PhanCong()).Them(pc);
                LoadData();
                MessageBox.Show("Đã thêm thành công!");
            }
            else
            {
                MessageBox.Show("Đã tồn tại phân công này!");
            }
        }
        private void lsvPhanCong_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa phân công này không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            if(lsvPhanCong.SelectedItems.Count == 1)
            {
                PhanCong pc = (new BAL_PhanCong()).Get(MaNV, lsvPhanCong.SelectedItems[0].SubItems[1].Text.Split('/')[0], lsvPhanCong.SelectedItems[0].SubItems[0].Text.Split('/')[0]);
                if(pc != null)
                {
                    try
                    {//Xóa chấm công
                        foreach (ChamCong cc in pc.ChamCongs)
                        {
                            (new BAL_ChamCong()).Xoa(cc.ID, cc.MaNV, cc.MaCa, cc.MaKV);
                        }
                        //Xóa phân công
                        (new BAL_PhanCong()).Xoa(pc.MaNV, pc.MaCa, pc.MaKV);
                        LoadData();
                    }
                    catch(Exception)
                    {

                    }
                }
            }
        }
    }
}
