using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_Mon
    {
        CoffeeEntities db;
        public BAL_Mon()
        {
            db = new CoffeeEntities();
        }

        public List<Mon> Get_Mon()
        {
            List<Mon> List = (from m in db.Mon
                              select m).OrderBy(M => M.MaMon).ToList();
            return List;
        }
        public Mon Get_Mon(string MaMon)
        {
            Mon mon = (from m in db.Mon
                       where m.MaMon == MaMon
                       select m).FirstOrDefault();
            return mon;
        }
        public List<Mon> Get_MonTheoMaLoaiMon(string MaLoaiMon)
        {
            List<Mon> List;
            if (MaLoaiMon == "ALL")
            {
                List = (from m in db.Mon
                        select m).OrderBy(M => M.MaMon).ToList();
            }
            else
            {
                List = (from m in db.Mon
                        where m.MaLoaiMon == MaLoaiMon
                        select m).OrderBy(M => M.MaMon).ToList();
            }
            return List;
        }
        public bool ThemMon(Mon mon)
        {
            try
            {
                var m = new Mon()
                {
                    MaMon = mon.MaMon,
                    MaLoaiMon = mon.MaLoaiMon,
                    TenMon = mon.TenMon,
                    SoLuong = mon.SoLuong,
                    DonGia = mon.DonGia,
                    GiaNhap = mon.GiaNhap
                };

                db.Mon.Add(m);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool CapNhatMon(Mon mon)
        {
            try
            {
                Mon m = db.Mon.Find(mon.MaMon);
                if (m != null)
                {
                    m.MaMon = mon.MaMon;
                    m.MaLoaiMon = mon.MaLoaiMon;
                    m.TenMon = mon.TenMon;
                    m.SoLuong = mon.SoLuong;
                    m.DonGia = mon.DonGia;
                    m.GiaNhap = mon.GiaNhap;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void CapNhatSoLuong(string MaMon, int SoLuongThem)
        {
            try
            {
                Mon m = db.Mon.Find(MaMon);
                if(m != null)
                {
                    m.SoLuong += SoLuongThem;

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public void XoaMon(string MaMon)
        {
            try
            {
                Mon m = db.Mon.Find(MaMon);
                if(m != null)
                {
                    db.Mon.Remove(m);

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public string GetMaMonTiepTheo()
        {
            string next = string.Empty;
            next = db.Mon.Max(m => m.MaMon);

            if (next == null) next = "M000000";
            string tmp = next.Replace("M", "");

            next = "M" + (double.Parse(tmp) + 1).ToString("000000");

            return next;
        }
    }
}
