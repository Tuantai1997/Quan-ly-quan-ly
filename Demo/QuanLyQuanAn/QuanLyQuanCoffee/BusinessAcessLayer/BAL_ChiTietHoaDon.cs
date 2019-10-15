using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_ChiTietHoaDon
    {
        CoffeeEntities db;
        public BAL_ChiTietHoaDon()
        {
            db = new CoffeeEntities();
        }
        //Get tất cả chi tiết hóa đơn bán
        public List<ChiTietHoaDon> Get_ChiTietHoaDon()
        {
            return (from ct in db.ChiTietHoaDon select ct).ToList();
        }
        //Get hóa đơn bán theo mã hóa đơn
        public List<ChiTietHoaDon> Get_ChiTietHoaDon(string MaHD)
        {
            return (from ct in db.ChiTietHoaDon where ct.MaHD == MaHD select ct).ToList();
        }
        //Get hóa đơn bán theo mã hóa đơn và mã món
        public ChiTietHoaDon Get_ChiTietHoaDon(string MaHD, string MaMon)
        {
            return (from ct in db.ChiTietHoaDon where ct.MaHD == MaHD && ct.MaMon == MaMon select ct).FirstOrDefault();
        }
        public bool ThemChiTietHoaDon(string MaHD, string MaMon, double DonGia, int SoLuong, string GhiChu)
        {
            try
            {
                var ct = new ChiTietHoaDon()
                {
                    MaHD = MaHD,
                    MaMon = MaMon,
                    DonGia = DonGia,
                    SoLuong = SoLuong,
                    GhiChu = GhiChu
                };

                db.ChiTietHoaDon.Add(ct);
                db.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool CapNhatChiTietHoaDon(string MaHD, string MaMon, double DonGia, int SoLuong, string GhiChu)
        {
            try
            {
                ChiTietHoaDon ct = db.ChiTietHoaDon.Find(MaHD, MaMon);
                if(ct != null)
                {
                    ct.MaHD = MaHD;
                    ct.MaMon = MaMon;
                    ct.DonGia = DonGia;
                    ct.SoLuong = SoLuong;
                    ct.GhiChu = GhiChu;
                    db.SaveChanges();
                };
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaChiTietHoaDon(string MaHD, string MaMon)
        {
            try
            {
                ChiTietHoaDon ct = db.ChiTietHoaDon.Find(MaHD, MaMon);
                if(ct != null)
                {
                    db.ChiTietHoaDon.Remove(ct);
                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
