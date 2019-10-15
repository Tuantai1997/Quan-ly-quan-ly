using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_HoaDon
    {
        QuanAnEntities db = new QuanAnEntities();
        public BAL_HoaDon()
        {
            db = new QuanAnEntities();
        }
        public List<HoaDon> Get_HoaDon()
        {
            return (from hd in db.HoaDon select hd).OrderByDescending(hd => hd.NgayLapHD.Value).OrderBy(hd => hd.DaThanhToan.Value).ToList();
        }
        public HoaDon Get_HoaDon(string MaHD)
        {
            return (from hd in db.HoaDon where hd.MaHD == MaHD select hd).FirstOrDefault();
        }
        public List<HoaDon> Get_HoaDonTheoTinhTrang(bool DaThanhToan)
        {
            return (from hd in db.HoaDon where hd.DaThanhToan == DaThanhToan select hd).ToList();
        }

        public bool ThemHoaDon(ref string err, string MaHD, string MaBan, string MaNV, DateTime NgayLapHD, double PhuThu, double VAT, bool DaThanhToan)
        {
            try
            {
                var hd = new HoaDon()
                {
                    MaHD = MaHD,
                    MaBan = MaBan,
                    MaNV = MaNV,
                    NgayLapHD = NgayLapHD,
                    PhuThu = PhuThu,
                    VAT = VAT,
                    DaThanhToan = DaThanhToan
                };

                db.HoaDon.Add(hd);
                db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatHoaDon(HoaDon hd0)
        {
            try
            {
                HoaDon hd = db.HoaDon.Find(hd0.MaHD);
                if (hd != null)
                {
                    hd.MaHD = hd0.MaHD;
                    hd.MaBan = hd0.MaBan;
                    hd.MaNV = hd0.MaNV;
                    hd.NgayLapHD = hd0.NgayLapHD;
                    hd.PhuThu = hd0.PhuThu;
                    hd.VAT = hd0.VAT;
                    hd.DaThanhToan = hd0.DaThanhToan;
                    db.SaveChanges();
                };
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void XoaHoaDon(string MaHD)
        {
            try
            {
                HoaDon hd = db.HoaDon.Find(MaHD);
                if (hd != null)
                {
                    db.HoaDon.Remove(hd);
                    db.SaveChanges();
                };
            }
            catch (Exception)
            {
                
            }
        }
        public string GetMaHDTiepTheo()
        {
            string next = string.Empty;
            next = db.HoaDon.Max(hd => hd.MaHD);

            if (next == null) next = "HD000000";
            string tmp = next.Replace("HD", "");

            next = "HD" + (double.Parse(tmp) + 1).ToString("000000");

            return next;
        }
    }
}
