using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_LoaiMon
    {
        CoffeeEntities db;
        public BAL_LoaiMon()
        {
            db = new CoffeeEntities();
        }

        public List<LoaiMon> Get_LoaiMon()
        {
            List<LoaiMon> List = (from lm in db.LoaiMon
                                  select lm).OrderBy(LM => LM.MaLoaiMon).ToList();
            return List;
        }
        public LoaiMon Get_LoaiMon(string MaLoaiMon)
        {
            LoaiMon loaimon = (from lm in db.LoaiMon
                               where lm.MaLoaiMon == MaLoaiMon
                               select lm).FirstOrDefault();
            return loaimon;
        }
        public string GetMaLoaiMonTiepTheo()
        {
            string next = string.Empty;
            next = db.LoaiMon.Max(lm => lm.MaLoaiMon);

            if (next == null) next = "LM000000";
            string tmp = next.Replace("LM", "");

            next = "LM" + (double.Parse(tmp) + 1).ToString("000000");

            return next;
        }
        public void ThemLoaiMon(LoaiMon lm)
        {
            try
            {
                var l = new LoaiMon()
                {
                    MaLoaiMon = lm.MaLoaiMon,
                    TenLoaiMon = lm.TenLoaiMon
                };
                db.LoaiMon.Add(l);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public void CapNhatLoaiMon(LoaiMon lm)
        {
            try
            {
                LoaiMon l = db.LoaiMon.Find(lm.MaLoaiMon);
                if(l != null)
                {
                    l.MaLoaiMon = lm.MaLoaiMon;
                    l.TenLoaiMon = lm.TenLoaiMon;

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public void XoaLoaiMon(string MaLoaiMon)
        {
            try
            {
                LoaiMon lm = db.LoaiMon.Find(MaLoaiMon);
                if(lm != null)
                {
                    db.LoaiMon.Remove(lm);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
    }
}
