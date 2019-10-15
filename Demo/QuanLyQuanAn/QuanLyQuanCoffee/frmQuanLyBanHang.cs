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
    public partial class frmQuanLyBanHang : Form
    {
        public frmQuanLyBanHang()
        {
            InitializeComponent();
        }
        
        private void frmQuanLyBanHang_Load(object sender, EventArgs e)
        {
            List<KhuVuc> List = (new BAL_KhuVuc()).Get_KhuVuc();
            KhuVuc k = new KhuVuc()
            {
                MaKV = "ALL",
                TenKV = "Tất cả"
            };
            List.Insert(0, k);
            cmbKhuVuc.DataSource = List;
            cmbKhuVuc.DisplayMember = "TenKV";
            cmbKhuVuc.ValueMember = "MaKV";
            cmbKhuVuc.SelectedIndex = 0;
            LoadBan();

            List<LoaiMon> List1 = (new BAL_LoaiMon()).Get_LoaiMon();
            LoaiMon lm = new LoaiMon()
            {
                MaLoaiMon = "ALL",
                TenLoaiMon = "Tất cả"
            };
            List1.Insert(0, lm);
            cmbLoaiMon.DataSource = List1;
            cmbLoaiMon.DisplayMember = "TenLoaiMon";
            cmbLoaiMon.ValueMember = "MaLoaiMon";
            LoadMon();

            this.Text = "Quản lý quán coffee -- " + Program.NhanVienDangDangNhap.MaNV + " -- " + Program.NhanVienDangDangNhap.HoTen + " -- " + "[" + (Program.NhanVienDangDangNhap.Quyen == true ? "Admin" : "Nhân viên") + "]";
        }

        #region Load picturebox bàn
        private void LoadBan0()
        {
            pnlBan.Controls.Clear();
            List<Ban> List = (new BAL_Ban()).Get_BanTheoMaKhuVuc(cmbKhuVuc.SelectedValue.ToString());
            int x = 20, step = 20, y = 10;
            int count = 1;

            for (int i = 1; i <= List.Count; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (count > List.Count) break;

                    PictureBox ptb = new PictureBox();
                    Label lb = new Label();
                    if (List[count - 1].TinhTrang.Value == false)//K có khách
                    {
                        ptb.Image = ((System.Drawing.Image)(QuanLyQuanCoffee.Properties.Resources.KCK));
                    }
                    else//Có khách
                    {
                        ptb.Image = ((System.Drawing.Image)(QuanLyQuanCoffee.Properties.Resources.CK));
                    }

                    // 
                    // label
                    // 
                    lb.Location = new System.Drawing.Point(x, 70 + y);
                    lb.Name = "label" + count.ToString();
                    lb.Size = new System.Drawing.Size(70, 14);
                    lb.Text = List[count - 1].TenBan;
                    lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // pictureBox
                    // 
                    ptb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    ptb.Location = new System.Drawing.Point(x, y);
                    ptb.Name = List[count - 1].MaBan;
                    ptb.Size = new System.Drawing.Size(70, 70);
                    ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    ptb.TabStop = false;
                    ptb.DoubleClick += new EventHandler(PictureBox_DoubleClick);

                    pnlBan.Controls.Add(ptb);
                    pnlBan.Controls.Add(lb);
                    x += 70 + step;
                    count++;
                }
                x = step;
                y += 70 + step;
                if (count > List.Count) break;
            }
        }
        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            ResetDisplay();
            PictureBox ptb = (PictureBox)sender;
            Ban ban = (new BAL_Ban()).Get_Ban(ptb.Name);
            if (ban != null)
            {
                if (ban.TinhTrang.Value == true) //Bàn đang có khách
                {
                    HoaDon hd = (new BAL_Ban()).Get_HoaDonBanChuaThanhToanTheoMaBan(ban.MaBan);
                    if (hd != null)
                    {
                        lblSoHoaDon.Text = hd.MaHD;
                        LoadCTHD();
                        LoadHD();
                    }
                }
                else //Bàn chưa có khách
                {
                    //Thêm hóa đơn mới
                    string err = ""; bool KQ = false; string MaHD = (new BAL_HoaDon()).GetMaHDTiepTheo();
                    KQ = (new BAL_HoaDon()).ThemHoaDon(ref err, MaHD, ban.MaBan, Program.NhanVienDangDangNhap.MaNV, DateTime.Now, 0, 0, false);
                    if (!KQ)
                    {
                        MessageBox.Show("Không thể thêm hóa đơn cho " + ban.TenBan + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //Cập nhật lại trạng thái của bàn
                    (new BAL_Ban()).CapNhatTinhTrangCuaBan(ban.MaBan, true);
                    //Cập nhật lại ảnh nền của bàn
                    ptb.Image = ((System.Drawing.Image)(QuanLyQuanCoffee.Properties.Resources.CK));

                    lblSoHoaDon.Text = (new BAL_HoaDon()).Get_HoaDon(MaHD).MaHD;
                    LoadCTHD();
                    LoadHD();
                }
            }
        }
        #endregion

        #region Load button bàn
        private void LoadBan()
        {
            pnlBan.Controls.Clear();
            List<Ban> List = (new BAL_Ban()).Get_BanTheoMaKhuVuc(cmbKhuVuc.SelectedValue.ToString());
            int x = 20, step = 20, y = 10;
            int count = 1;

            for (int i = 1; i <= List.Count; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (count > List.Count) break;

                    Button btn = new Button();
                    if (List[count - 1].TinhTrang.Value == false)
                    {
                        btn.BackgroundImage = ((System.Drawing.Image)(QuanLyQuanCoffee.Properties.Resources.KCK));
                    }
                    else
                    {
                        btn.BackgroundImage = ((System.Drawing.Image)(QuanLyQuanCoffee.Properties.Resources.CK));
                    }
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btn.Location = new System.Drawing.Point(x, y);
                    btn.Name = List[count - 1].MaBan;
                    btn.Size = new System.Drawing.Size(70, 70);
                    btn.TabIndex = 1;
                    btn.Text = List[count - 1].TenBan;
                    btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new EventHandler(this.ButtonBan_Click);

                    pnlBan.Controls.Add(btn);
                    x += 70 + step;
                    count++;
                }
                x = step;
                y += 70 + step;
                if (count > List.Count) break;
            }
        }
        //Hiển thị hóa đơn của bàn khi click vào bàn
        private void ButtonBan_Click(object sender, EventArgs e)
        {
            ResetDisplay();
            Button bt = (Button)sender;
            Ban ban = (new BAL_Ban()).Get_Ban(bt.Name);
            if (ban != null)
            {
                if (ban.TinhTrang.Value == true) //Bàn đang có khách
                {
                    HoaDon hd = (new BAL_Ban()).Get_HoaDonBanChuaThanhToanTheoMaBan(ban.MaBan);
                    if (hd != null)
                    {
                        lblSoHoaDon.Text = hd.MaHD;
                        LoadCTHD();
                        LoadHD();
                    }
                }
                else //Bàn chưa có khách
                {
                    DialogResult dl = MessageBox.Show("Bạn có muốn thêm một hóa đơn cho " + ban.TenBan + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        //Thêm hóa đơn mới
                        string err = ""; bool KQ = false; string MaHD = (new BAL_HoaDon()).GetMaHDTiepTheo();
                        KQ = (new BAL_HoaDon()).ThemHoaDon(ref err, MaHD, ban.MaBan, Program.NhanVienDangDangNhap.MaNV, DateTime.Now, 0, 0, false);
                        if (!KQ)
                        {
                            MessageBox.Show("Không thể thêm hóa đơn cho " + ban.TenBan + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        //Cập nhật lại trạng thái của bàn
                        (new BAL_Ban()).CapNhatTinhTrangCuaBan(ban.MaBan, true);
                        //Cập nhật lại ảnh nền của bàn
                        bt.BackgroundImage = ((System.Drawing.Image)(QuanLyQuanCoffee.Properties.Resources.CK));

                        lblSoHoaDon.Text = (new BAL_HoaDon()).Get_HoaDon(MaHD).MaHD;
                        LoadCTHD();
                        LoadHD();

                        LichSuHoatDong ls = new LichSuHoatDong();
                        ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                        ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                        ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                        ls.HoatDong = "Thêm hóa đơn (" + MaHD + ")";
                        ls.ThoiGian = DateTime.Now;
                        ls.TinhTrang = "Thành công";
                        (new BAL_LichSuHoatDong()).ThemLichSu(ls);
                    }
                }
            }
        }
        #endregion

        /*
        //Load thông tin hóa đơn
        private void CapNhatVaLoadHoaDon()
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);

            if (hd != null)
            {
                //Cập nhật hóa đơn
                double TongTien = 0; string err = "";
                foreach (ChiTietHoaDon ct in (new BAL_ChiTietHoaDon()).Get_ChiTietHoaDon(hd.MaHD))
                {
                    TongTien += (ct.SoLuong.Value * ct.DonGia.Value);
                }
                TongTien = (TongTien + Convert.ToDouble(txtPhuThu.Text) * (1 + Convert.ToDouble(txtVAT.Text) / 100));
                (new BAL_HoaDon()).CapNhatHoaDon(ref err, hd.MaHD, hd.MaBan, hd.MaNV, hd.NgayLapHD.Value, Convert.ToDouble(txtPhuThu.Text), Convert.ToDouble(txtVAT.Text), TongTien, hd.DaThanhToan.Value);

                //Load lại hóa đơn
                hd = (new BAL_HoaDon()).Get_HoaDon(hd.MaHD);
                lblSoHoaDon.Text = hd.MaHD;
                lblThongTinBan.Text = "Thông tin " + hd.Ban.TenBan;
                dtpNgayLapHD.Value = hd.NgayLapHD.Value;
                txtPhuThu.Text = hd.PhuThu.Value.ToString();
                txtVAT.Text = hd.VAT.Value.ToString();
                txtTongTien.Text = hd.TongTien.Value.ToString();

                //Load chi tiết hóa đơn
                lsvChiTietHoaDon.Items.Clear();
                foreach (ChiTietHoaDon ct in hd.ChiTietHoaDons)
                {
                    ListViewItem item = new ListViewItem(ct.MaMon);
                    item.SubItems.Add(ct.Mon.TenMon);
                    item.SubItems.Add(ct.Mon.DonGia.Value.ToString());
                    item.SubItems.Add(ct.SoLuong.Value.ToString());
                    item.SubItems.Add((ct.SoLuong * ct.Mon.DonGia).Value.ToString());
                    item.SubItems.Add(ct.GhiChu);

                    lsvChiTietHoaDon.Items.Add(item);
                }
            }
            else
            {

            }
        }
        //Cập nhật hóa đơn
        private void CapNhatHoaDonKhiCoThayDoiCTHD()
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);

            if (hd != null)
            {
                //Cập nhật hóa đơn
                double TongTien = 0; string err = "";
                foreach (ChiTietHoaDon ct in (new BAL_ChiTietHoaDon()).Get_ChiTietHoaDon(hd.MaHD))
                {
                    TongTien += (ct.SoLuong.Value * ct.DonGia.Value);
                }
                TongTien = (TongTien + Convert.ToDouble(txtPhuThu.Text) * (1 + Convert.ToDouble(txtVAT.Text) / 100));
                (new BAL_HoaDon()).CapNhatHoaDon(ref err, hd.MaHD, hd.MaBan, hd.MaNV, hd.NgayLapHD.Value, Convert.ToDouble(txtPhuThu.Text),
                    Convert.ToDouble(txtVAT.Text), TongTien, hd.DaThanhToan.Value);

            }
        }
        //Cập nhật lại hóa đơn khi có thay đổi ở txtPhuThu (i = 0) và ở txtVAT (i = 1)
        private void CapNhatHoaDonKhiCoThayDoiTextBox(int i)
        {
            double PhuThu = 0, VAT = 0;
            try
            {
                PhuThu = Convert.ToDouble(txtPhuThu.Text);
            }
            catch (FormatException)
            {
                PhuThu = 0;
            }
            try
            {
                VAT = Convert.ToDouble(txtVAT.Text);
            }
            catch (FormatException)
            {
                VAT = 0;
            }
            double TongTien = 0; string err = "";
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            if (hd != null)
            {
                foreach (ChiTietHoaDon ct in (new BAL_ChiTietHoaDon()).Get_ChiTietHoaDon(hd.MaHD))
                {
                    TongTien += (ct.SoLuong.Value * ct.DonGia.Value);
                }
                TongTien = (TongTien + PhuThu * (1 + VAT / 100));
                (new BAL_HoaDon()).CapNhatHoaDon(ref err, hd.MaHD, hd.MaBan, hd.MaNV, hd.NgayLapHD.Value, PhuThu, VAT, TongTien, hd.DaThanhToan.Value);

                //Load lại hóa đơn
                hd = (new BAL_HoaDon()).Get_HoaDon(hd.MaHD);
                lblSoHoaDon.Text = hd.MaHD;
                lblThongTinBan.Text = "Thông tin " + hd.Ban.TenBan;
                dtpNgayLapHD.Value = hd.NgayLapHD.Value;
                txtTongTien.Text = hd.TongTien.Value.ToString();
            }
            if (i == 0)
            {
                txtPhuThu.Text = hd.PhuThu.Value.ToString();
            }
            else
            {
                txtVAT.Text = hd.VAT.Value.ToString();
            }
        }
        //Load hóa đơn và chi tiết hóa đơn
        private void LoadHoaDonVaChitietHoaDon()
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            if (hd != null)
            {
                //Load lại hóa đơn
                hd = (new BAL_HoaDon()).Get_HoaDon(hd.MaHD);
                lblSoHoaDon.Text = hd.MaHD;
                lblThongTinBan.Text = "Thông tin " + hd.Ban.TenBan;
                lblBan.Text = hd.Ban.TenBan;
                dtpNgayLapHD.Value = hd.NgayLapHD.Value;
                txtPhuThu.Text = hd.PhuThu.Value.ToString();
                txtVAT.Text = hd.VAT.Value.ToString();
                txtTongTien.Text = hd.TongTien.Value.ToString();

                //Load chi tiết hóa đơn
                lsvChiTietHoaDon.Items.Clear();
                foreach (ChiTietHoaDon ct in hd.ChiTietHoaDons)
                {
                    ListViewItem item = new ListViewItem(ct.MaMon);
                    item.SubItems.Add(ct.Mon.TenMon);
                    item.SubItems.Add(ct.Mon.DonGia.Value.ToString());
                    item.SubItems.Add(ct.SoLuong.Value.ToString());
                    item.SubItems.Add((ct.SoLuong * ct.Mon.DonGia).Value.ToString());
                    item.SubItems.Add(ct.GhiChu);

                    lsvChiTietHoaDon.Items.Add(item);
                }
            }
        }
        */
        private void LoadMon()
        {
            lsvMon.Items.Clear();
            List<Mon> List = (new BAL_Mon()).Get_MonTheoMaLoaiMon(cmbLoaiMon.SelectedValue.ToString());
            if (List.Count <= 0) return;
            foreach (Mon m in List)
            {
                ListViewItem item = new ListViewItem(m.MaMon);
                item.SubItems.Add(m.TenMon);
                item.SubItems.Add(m.DonGia.Value.ToString());
                item.SubItems.Add(m.SoLuong.Value.ToString());
                item.SubItems.Add(m.GiaNhap.Value.ToString());

                lsvMon.Items.Add(item);
            }
        }
        //Load chi tiết hóa đơn
        private void LoadCTHD()
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);

            if (hd != null)
            {
                //Load chi tiết hóa đơn
                lsvChiTietHoaDon.Items.Clear();
                foreach (ChiTietHoaDon ct in hd.ChiTietHoaDons)
                {
                    ListViewItem item = new ListViewItem(ct.MaMon);
                    item.SubItems.Add(ct.Mon.TenMon);
                    item.SubItems.Add(ct.Mon.DonGia.Value.ToString());
                    item.SubItems.Add(ct.SoLuong.Value.ToString());
                    item.SubItems.Add((ct.SoLuong * ct.Mon.DonGia).Value.ToString());
                    item.SubItems.Add(ct.GhiChu);

                    lsvChiTietHoaDon.Items.Add(item);
                }
            }
        }
        //Load hóa đơn
        private void LoadHD()
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);

            if (hd != null)
            {
                double TongTien = 0;
                foreach (ChiTietHoaDon ct in hd.ChiTietHoaDons)
                {
                    TongTien += (ct.SoLuong.Value * ct.DonGia.Value);
                }
                TongTien = (TongTien + hd.PhuThu.Value)* (1 + hd.VAT.Value / 100);

                //Load lại hóa đơn
                lblSoHoaDon.Text = hd.MaHD;
                lblThongTinBan.Text = "Thông tin " + hd.Ban.TenBan;
                lblBan.Text = hd.Ban.TenBan;
                txtNgayLapHD.Text = hd.NgayLapHD.Value.ToString();
                txtPhuThu.Text = hd.PhuThu.Value.ToString();
                txtVAT.Text = hd.VAT.Value.ToString();
                txtTongTien.Text = TongTien.ToString();
            }
        }
        //
        private void ResetDisplay()
        {
            lblThongTinBan.Text = "Thông tin bàn số ...";
            lblSoHoaDon.Text = "--Số hóa đơn--";
            lblBan.Text = "Bàn ...";
            lsvChiTietHoaDon.Items.Clear();
            txtNgayLapHD.Text = DateTime.Now.ToString();
            txtPhuThu.Text = "0";
            txtVAT.Text = "0";
            txtTongTien.Text = "0";
            txtKhachDua.Text = "0";
            txtTraLai.Text = "0";

            btnHuyHoaDon.Enabled = true;
            btnDoiBan.Enabled = true;
            btnGopBan.Enabled = true;
            btnThanhToan.Text = "Thanh toán";
        }
        
        private void cmbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBan();
        }
        private void cmbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMon();
        }

        //Thêm món
        private void lsvMon_DoubleClick(object sender, EventArgs e)
        {
            if (lsvMon.SelectedItems.Count == 1)
            {
                HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
                if (hd != null)
                {
                    bool KQ = false;
                    Mon m = (new BAL_Mon()).Get_Mon(lsvMon.SelectedItems[0].SubItems[0].Text);
                    if (m.SoLuong.Value <= 0)
                    {
                        MessageBox.Show("Đã hết " + m.TenMon + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    ChiTietHoaDon ct = (new BAL_ChiTietHoaDon()).Get_ChiTietHoaDon(hd.MaHD, m.MaMon);
                    if (ct != null) //Món đã có rồi nên chỉ cập nhật số lượng tăng lên 1 đơn vị
                    {
                        KQ = (new BAL_ChiTietHoaDon()).CapNhatChiTietHoaDon(ct.MaHD, ct.MaMon, ct.DonGia.Value, ct.SoLuong.Value + 1, ct.GhiChu);
                    }
                    else //Món chưa có nên thêm mới chi tiết hóa đơn
                    {
                        KQ = (new BAL_ChiTietHoaDon()).ThemChiTietHoaDon(hd.MaHD, m.MaMon, m.DonGia.Value, 1, "");
                    }
                    if (!KQ)
                    {
                        MessageBox.Show("Không thể thêm món!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Cập nhật số lượng còn lại của món vừa thêm giảm đi 1
                        (new BAL_Mon()).CapNhatSoLuong(m.MaMon, -1);
                        LoadMon();

                        LoadCTHD();
                        LoadHD();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng mở bàn trước khi thêm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if ((new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text) == null)
            {
                MessageBox.Show("Chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr0 = MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr0 == DialogResult.No) return;

            try
            {
                double PhuThu = Convert.ToDouble(txtPhuThu.Text);
                try
                {
                    double VAT = Convert.ToDouble(txtVAT.Text);
                    try
                    {
                        double KhachDua = Convert.ToDouble(txtKhachDua.Text);

                        //Cập nhật lại hóa đơn
                        HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
                        hd.PhuThu = Convert.ToDouble(txtPhuThu.Text);
                        hd.VAT = Convert.ToDouble(txtVAT.Text);
                        hd.DaThanhToan = true;
                        (new BAL_HoaDon()).CapNhatHoaDon(hd);
                        //Load lại hóa đơn
                        LoadHD();

                        //Cập nhật lại trạng thái của bàn
                        (new BAL_Ban()).CapNhatTinhTrangCuaBan(hd.MaBan, false);
                        //Load lại bàn
                        LoadBan();

                        DialogResult dr = MessageBox.Show("Bạn có muốn in hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            //Hiện form in hóa đơn
                            (new frmInHoaDon((new BAL_HoaDon()).Get_HoaDon(hd.MaHD))).ShowDialog();
                        }

                        ResetDisplay();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Định dạng tiền khách đưa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtKhachDua.ResetText();
                        txtKhachDua.Focus();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Định dạng VAT không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVAT.ResetText();
                    txtVAT.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng phụ thu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhuThu.ResetText();
                txtPhuThu.Focus();
            }
        }

        private void lsvChiTietHoaDon_DoubleClick(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count == 1)
            {
                ChiTietHoaDon ct = (new BAL_ChiTietHoaDon()).Get_ChiTietHoaDon(lblSoHoaDon.Text, lsvChiTietHoaDon.SelectedItems[0].SubItems[0].Text);
                if (ct != null)
                {
                    (new frmEditChiTietHoaDon(ct)).ShowDialog();
                    //Load lại thông tin hóa đơn
                    LoadHD();

                    //Load chi tiết hóa đơn
                    LoadCTHD();

                    //Load món
                    LoadMon();
                }
            }
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            if (hd != null)
            {
                DialogResult KQ = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (KQ == DialogResult.Yes)
                {
                    //Cập nhật lại số lượng món
                    foreach (ChiTietHoaDon ct in hd.ChiTietHoaDons)
                    {
                        (new BAL_Mon()).CapNhatSoLuong(ct.MaMon, ct.SoLuong.Value);
                    }
                    //Xóa chi tiết hóa đơn
                    foreach (ChiTietHoaDon ct in hd.ChiTietHoaDons)
                    {
                        (new BAL_ChiTietHoaDon()).XoaChiTietHoaDon(ct.MaHD, ct.MaMon);
                    }
                    //Xóa hóa đơn
                    (new BAL_HoaDon()).XoaHoaDon(hd.MaHD);
                    //Reset tình trạng bàn
                    (new BAL_Ban()).CapNhatTinhTrangCuaBan(hd.MaBan, false);

                    LichSuHoatDong ls = new LichSuHoatDong();
                    ls.MaLichSu = (new BAL_LichSuHoatDong()).GetMaLichSuTiepTheo();
                    ls.MaNV = Program.NhanVienDangDangNhap.MaNV;
                    ls.HoTen = Program.NhanVienDangDangNhap.HoTen;
                    ls.HoatDong = "Hủy hóa đơn (" + hd.MaHD + ") trị giá " + txtTongTien.Text + " VNĐ!";
                    ls.ThoiGian = DateTime.Now;
                    ls.TinhTrang = "Thành công";
                    (new BAL_LichSuHoatDong()).ThemLichSu(ls);

                    LoadBan();
                    LoadMon();
                    ResetDisplay();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDoiBan_Click(object sender, EventArgs e)
        {
            if ((new BAL_Ban()).Get_BanTrong().Count > 0)
            {
                HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
                if (hd != null)
                {
                    (new frmDoiBan(hd)).ShowDialog();
                    if(!frmDoiBan.Huy)
                    {
                        LoadBan();
                        ResetDisplay();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bàn đang mở trước khi đổi bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Đã hết bàn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            if (hd != null)
            {

                if ((new BAL_Ban()).Get_BanCoKhach().Count > 1)
                {
                    (new frmGopBan(hd)).ShowDialog();
                    if (!frmGopBan.Huy)
                    {
                        LoadBan();
                        ResetDisplay();
                    }
                }
                else
                {
                    MessageBox.Show("Không có bàn nào để gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn đang mở trước khi gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInHoaDonXuongBep_Click(object sender, EventArgs e)
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            if(hd == null)
            {
                MessageBox.Show("Chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            (new frmInHoaDonXuongBep(hd)).ShowDialog();
        }

        private void txtPhuThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            //Kiểm tra dữ liệu nhập
            if(hd == null || ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtPhuThu_TextChanged(object sender, EventArgs e)
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            if (hd == null) return;

            double PhuThu = hd.PhuThu.Value;
            try
            {
                PhuThu = Convert.ToDouble(txtPhuThu.Text);
            }
            catch
            {
                if (txtPhuThu.Text.Length == 0) PhuThu = 0;
            }
            //Cập nhật hóa đơn
            hd.PhuThu = PhuThu;
            (new BAL_HoaDon()).CapNhatHoaDon(hd);

            LoadHD();

            if (txtPhuThu.Text.Length != 0)
            {
                txtPhuThu.Select(txtPhuThu.Text.Length, 1);
            }
        }
        
        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            //Kiểm tra dữ liệu nhập
            if (hd == null || ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            if (hd == null) return;

            double VAT = hd.VAT.Value;
            try
            {
                VAT = Convert.ToDouble(txtVAT.Text);
            }
            catch
            {
                if (txtVAT.Text.Length == 0) VAT = 0;
            }

            //Cập nhật hóa đơn
            hd.VAT = VAT;
            (new BAL_HoaDon()).CapNhatHoaDon(hd);

            LoadHD();

            if (txtVAT.Text.Length != 0)
            {
                txtVAT.Select(txtVAT.Text.Length, 1);
            }
        }
        
        private void txtKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            HoaDon hd = (new BAL_HoaDon()).Get_HoaDon(lblSoHoaDon.Text);
            //Kiểm tra dữ liệu nhập
            if (hd == null || ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 13 && (int)e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (txtKhachDua.Text.Length == 0) txtKhachDua.Text = "0";
            try
            {
                txtTraLai.Text = (Convert.ToDouble(txtKhachDua.Text) - Convert.ToDouble(txtTongTien.Text)).ToString();
            }
            catch
            {
                
            }
        }
        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            txtKhachDua_TextChanged(new TextBox(), new EventArgs());
        }

        private void frmQuanLyBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.T))
                {
                    btnThanhToan_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.D))
                {
                    btnDoiBan_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.G))
                {
                    btnGopBan_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.I))
                {
                    btnInHoaDonXuongBep_Click(sender, e);
                }
                if (e.KeyCode.Equals(Keys.H))
                {
                    btnHuyHoaDon_Click(sender, e);
                }
            }
        }
    }
}
