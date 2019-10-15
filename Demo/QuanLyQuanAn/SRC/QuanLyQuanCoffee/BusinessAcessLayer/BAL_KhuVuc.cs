using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_KhuVuc
    {
        CoffeeEntities db;
        public BAL_KhuVuc()
        {
            db = new CoffeeEntities();
        }

        public List<KhuVuc> Get_KhuVuc()
        {
            return (from kv in db.KhuVuc select kv).OrderBy(KV => KV.MaKV).ToList();
        }
        public KhuVuc Get_KhuVuc(string MaKV)
        {
            KhuVuc khuvuc = (from kv in db.KhuVuc
                             where kv.MaKV == MaKV
                             select kv).FirstOrDefault();
            return khuvuc;
        }
        public string GetMaKhuVucTiepTheo()
        {
            string next = string.Empty;
            next = db.KhuVuc.Max(kv => kv.MaKV);

            if (next == null) next = "KV000000";
            string tmp = next.Replace("KV", "");

            next = "KV" + (double.Parse(tmp) + 1).ToString("000000");

            return next;
        }
        public void Them(KhuVuc kv)
        {
            try
            {
                var k = new KhuVuc()
                {
                    MaKV = kv.MaKV,
                    TenKV = kv.TenKV
                };
                db.KhuVuc.Add(k);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public void Xoa(string MaKV)
        {
            try
            {
                KhuVuc k = db.KhuVuc.Find(MaKV);
                if (k != null)
                {
                    db.KhuVuc.Remove(k);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public void CapNhat(KhuVuc kv)
        {
            try
            {
                KhuVuc k = db.KhuVuc.Find(kv.MaKV);
                if(k != null)
                {
                    k.MaKV = kv.MaKV;
                    k.TenKV = kv.TenKV;

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
    }
}
