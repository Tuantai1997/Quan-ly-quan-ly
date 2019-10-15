using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_PhanCong
    {
        CoffeeEntities db;
        public BAL_PhanCong()
        {
            db = new CoffeeEntities();
        }

        public PhanCong Get(string MaNV, string MaCa, string MaKV)
        {
            return (from pc in db.PhanCong where pc.MaNV == MaNV && pc.MaCa == MaCa && pc.MaKV == MaKV select pc).FirstOrDefault();
        }
        public void Xoa(string MaNV, string MaCa, string MaKV)
        {
            try
            {
                PhanCong pc = db.PhanCong.Find(MaNV, MaCa, MaKV);
                if(pc != null)
                {
                    db.PhanCong.Remove(pc);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public void Them(PhanCong pc)
        {
            try
            {
                var pc0 = new PhanCong()
                {
                    MaNV = pc.MaNV,
                    MaCa = pc.MaCa,
                    MaKV = pc.MaKV
                };

                db.PhanCong.Add(pc0);
                db.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
