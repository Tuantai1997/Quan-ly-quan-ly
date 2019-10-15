using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_PhieuChi
    {
        CoffeeEntities db;
        public BAL_PhieuChi()
        {
            db = new CoffeeEntities();
        }
        public List<PhieuChi> Get()
        {
            return (from pc in db.PhieuChi select pc).ToList();
        }
        public PhieuChi Get(string MaPhieuChi)
        {
            return (from pc in db.PhieuChi where pc.MaPhieuChi == MaPhieuChi select pc).FirstOrDefault();
        }
        public void Xoa(string MaPhieuChi)
        {
            try
            {
                PhieuChi pc = db.PhieuChi.Find(MaPhieuChi);
                if(pc != null)
                {
                    db.PhieuChi.Remove(pc);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public void Them(PhieuChi pc)
        {
            try
            {
                var p = new PhieuChi()
                {
                    MaPhieuChi = pc.MaPhieuChi,
                    MaNV = pc.MaNV,
                    MucDichChi = pc.MucDichChi,
                    NgayChi = pc.NgayChi,
                    TongTien = pc.TongTien
                };
                db.PhieuChi.Add(p);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public void CapNhat(PhieuChi pc)
        {
            try
            {
                PhieuChi p = db.PhieuChi.Find(pc.MaPhieuChi);
                if(p != null)
                {
                    p.MaPhieuChi = pc.MaPhieuChi;
                    p.MaNV = pc.MaNV;
                    p.MucDichChi = pc.MucDichChi;
                    p.NgayChi = pc.NgayChi;
                    p.TongTien = pc.TongTien;

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public string GetMaPhieuChiTiepTheo()
        {
            string next = string.Empty;
            next = db.PhieuChi.Max(pc => pc.MaPhieuChi);

            if (next == null) next = "PC000000";
            string tmp = next.Replace("PC", "");

            next = "PC" + (double.Parse(tmp) + 1).ToString("000000");

            return next;
        }
    }
}
