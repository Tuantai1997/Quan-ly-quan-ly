using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_LichSuHoatDong
    {
        QuanAnEntities db;
        public BAL_LichSuHoatDong()
        {
            db = new QuanAnEntities();
        }

        public LichSuHoatDong Get(string MaLichSu)
        {
            return (from ls in db.LichSuHoatDong where ls.MaLichSu == MaLichSu select ls).FirstOrDefault();
        }
        public List<LichSuHoatDong> Get()
        {
            return (from ls in db.LichSuHoatDong select ls).OrderByDescending(ls => ls.ThoiGian.Value).ToList();
        }
        public List<LichSuHoatDong> Get_TheoMaNV(string MaNV)
        {
            return (from ls in db.LichSuHoatDong where ls.MaNV == MaNV select ls).OrderByDescending(ls => ls.ThoiGian.Value).ToList();
        }
        public void ThemLichSu(LichSuHoatDong ls)
        {
            try
            {
                var l = new LichSuHoatDong()
                {
                    MaLichSu = ls.MaLichSu,
                    MaNV = ls.MaNV,
                    HoTen = ls.HoTen,
                    HoatDong = ls.HoatDong,
                    ThoiGian = ls.ThoiGian,
                    TinhTrang = ls.TinhTrang
                };
                db.LichSuHoatDong.Add(l);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public void XoaLichSu(string MaLichSu)
        {
            try
            {
                LichSuHoatDong ls = db.LichSuHoatDong.Find(MaLichSu);
                if(ls != null)
                {
                    db.LichSuHoatDong.Remove(ls);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public string GetMaLichSuTiepTheo()
        {
            string next = string.Empty;
            next = db.LichSuHoatDong.Max(ls => ls.MaLichSu);

            if (next == null) next = "LS0000000000";
            string tmp = next.Replace("LS", "");

            next = "LS" + (double.Parse(tmp) + 1).ToString("0000000000");

            return next;
        }
    }
}
