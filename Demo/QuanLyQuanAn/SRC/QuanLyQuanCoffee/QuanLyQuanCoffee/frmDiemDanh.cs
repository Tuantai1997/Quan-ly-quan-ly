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
    public partial class frmDiemDanh : Form
    {
        public frmDiemDanh()
        {
            InitializeComponent();
        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
        {
            dtpID.MaxDate = DateTime.Now.Date;
            dtpID.MinDate = (new BAL_ChamCong()).GetMinID().Date;

            List<CaLamViec> List = (new BAL_CaLamViec()).Get();
            cmbCa.DataSource = List;
            cmbCa.DisplayMember = "TenCa";
            cmbCa.ValueMember = "MaCa";

            List<KhuVuc> ListKV = (new BAL_KhuVuc()).Get_KhuVuc();
            cmbKhuVuc.DataSource = ListKV;
            cmbKhuVuc.DisplayMember = "TenKV";
            cmbKhuVuc.ValueMember = "MaKV";

            TaoPhieuChamCong();

            cmbCa_SelectedIndexChanged(new ComboBox(), new EventArgs());
        }
        private void TaoPhieuChamCong()
        {
            DateTime ID = dtpID.Value;
            int Thang = dtpID.Value.Month, Nam = dtpID.Value.Year;
            //Chưa có phiếu chấm công của ngày ID
            foreach (NhanVien nv in (new BAL_NhanVien()).Get_NhanVien())
            {
                foreach (PhanCong pc in nv.PhanCongs)
                {
                    ChamCong cc = new ChamCong();
                    cc.ID = ID;
                    cc.MaCa = pc.MaCa;
                    cc.MaNV = pc.MaNV;
                    cc.MaKV = pc.MaKV;
                    cc.Thang = Thang;
                    cc.Nam = Nam;
                    cc.TinhTrang = false;
                    (new BAL_ChamCong()).Them(cc);
                }
            }
        }
        private void LoadNhanVien()
        {
            pnlNhanVien.Controls.Clear();
            CaLamViec c = (new BAL_CaLamViec()).Get(cmbCa.SelectedValue.ToString());
            KhuVuc kv = (new BAL_KhuVuc()).Get_KhuVuc(cmbKhuVuc.SelectedValue.ToString());
            if (c != null && kv != null)
            {
                int y = 3;
                foreach(ChamCong cc in (new BAL_ChamCong()).Get(dtpID.Value, c.MaCa, kv.MaKV))
                {
                    CheckBox cb = new CheckBox();
                    cb.AutoSize = true;
                    cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    cb.Location = new System.Drawing.Point(3, y);
                    cb.Name = cc.MaNV;
                    cb.Size = new System.Drawing.Size(77, 17);
                    cb.TabIndex = 0;
                    cb.Text = "[" + cc.PhanCong.NhanVien.MaNV + "] " + cc.PhanCong.NhanVien.HoTen;
                    cb.UseVisualStyleBackColor = true;
                    cb.Checked = cc.TinhTrang.Value;
                    cb.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

                    y += 20;
                    pnlNhanVien.Controls.Add(cb);
                }
            }
        }
        private void cmbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaLamViec c = (new BAL_CaLamViec()).Get(cmbCa.SelectedValue.ToString());
            if (c != null)
            {
                lblThoiGian.Text = c.GioBatDau.Value.ToString() + " -> " + c.GioKetThuc.Value.ToString();

                LoadNhanVien();
            }
        }
        private void cmbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCa_SelectedIndexChanged(new ComboBox(), new EventArgs());
        }
        private void dtpID_ValueChanged(object sender, EventArgs e)
        {
            if(cmbCa.SelectedValue != null)
            {
                TaoPhieuChamCong();
                LoadNhanVien();
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            ChamCong cc = (new BAL_ChamCong()).Get(dtpID.Value, cb.Name, cmbCa.SelectedValue.ToString(), cmbKhuVuc.SelectedValue.ToString());
            if(cc != null)
            {
                if (cb.Checked)
                {
                    cc.TinhTrang = true;
                }
                else
                {
                    cc.TinhTrang = false;
                }
                (new BAL_ChamCong()).CapNhat(cc);
            }
        }
    }
}
