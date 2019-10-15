using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_Ban
    {
        CoffeeEntities db;
        public BAL_Ban()
        {
            db = new CoffeeEntities();
        }

        public List<Ban> Get_Ban()
        {
            List<Ban> List = (from b in db.Ban
                              select b).ToList();
            return List;
        }
        public Ban Get_Ban(string MaBan)
        {
            Ban ban = (from b in db.Ban
                       where b.MaBan == MaBan
                       select b).FirstOrDefault();
            return ban;
        }
        public List<Ban> Get_BanTheoMaKhuVuc(string MaKV)
        {
            List<Ban> List;
            if (MaKV == "ALL")
            {
                List = (from b in db.Ban
                        select b).OrderBy(B => B.MaBan).ToList();
            }
            else
            {
                List = (from b in db.Ban
                        where b.MaKV == MaKV
                        select b).OrderBy(B => B.MaBan).ToList();
            }
            return List;
        }
        public HoaDon Get_HoaDonBanChuaThanhToanTheoMaBan(string MaBan)
        {
            return (from hd in db.HoaDon where hd.MaBan == MaBan && hd.DaThanhToan.Value == false select hd).FirstOrDefault();
        }
        public void CapNhatTinhTrangCuaBan(string MaBan, bool TinhTrang)
        {
            try
            {
                Ban b = db.Ban.Find(MaBan);
                if(b != null)
                {
                    b.TinhTrang = TinhTrang;

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public void Them(Ban b)
        {
            try
            {
                var ban = new Ban()
                {
                    MaBan = b.MaBan,
                    MaKV = b.MaKV,
                    TenBan = b.TenBan,
                    TinhTrang = b.TinhTrang
                };
                db.Ban.Add(ban);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public void Xoa(string MaBan)
        {
            try
            {
                Ban ban = db.Ban.Find(MaBan);
                if (ban != null)
                {
                    db.Ban.Remove(ban);
                    db.SaveChanges();
                };
            }
            catch
            {

            }
        }
        public void CapNhat(Ban b)
        {
            try
            {
                Ban ban = db.Ban.Find(b.MaBan);
                if(ban != null)
                {
                    ban.MaBan = b.MaBan;
                    ban.MaKV = b.MaKV;
                    ban.TenBan = b.TenBan;
                    ban.TinhTrang = b.TinhTrang;

                    db.SaveChanges();
                };
            }
            catch
            {

            }
        }
        public List<Ban> Get_BanTrong()
        {
            return (from b in db.Ban where b.TinhTrang == false select b).OrderBy(B => B.MaBan).ToList();
        }
        public List<Ban> Get_BanCoKhach()
        {
            return (from b in db.Ban where b.TinhTrang == true select b).OrderBy(B => B.MaBan).ToList();
        }
        public string GetMaBanTiepTheo()
        {
            string next = string.Empty;
            next = db.Ban.Max(b => b.MaBan);

            if (next == null) next = "B000000";
            string tmp = next.Replace("B", "");

            next = "B" + (double.Parse(tmp) + 1).ToString("000000");

            return next;
        }
    }
}
