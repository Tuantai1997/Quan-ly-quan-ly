using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_CaLamViec
    {
        QuanAnEntities db;
        public BAL_CaLamViec()
        {
            db = new QuanAnEntities();
        }
        public List<CaLamViec> Get()
        {
            return (from c in db.CaLamViec select c).ToList();
        }
        public CaLamViec Get(string MaCa)
        {
            return (from c in db.CaLamViec where c.MaCa == MaCa select c).FirstOrDefault();
        }
        public void Them(CaLamViec ca)
        {
            try
            {
                var c = new CaLamViec()
                {
                    MaCa = ca.MaCa,
                    TenCa = ca.TenCa,
                    GioBatDau = ca.GioBatDau,
                    GioKetThuc = ca.GioKetThuc,
                    MucLuong = ca.MucLuong
                };
                db.CaLamViec.Add(c);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public void CapNhat(CaLamViec ca)
        {
            try
            {
                CaLamViec c = db.CaLamViec.Find(ca.MaCa);
                if(c != null)
                {
                    c.MaCa = ca.MaCa;
                    c.TenCa = ca.TenCa;
                    c.GioBatDau = ca.GioBatDau;
                    c.GioKetThuc = ca.GioKetThuc;
                    c.MucLuong = ca.MucLuong;

                    db.SaveChanges();
                };
            }
            catch
            {

            }
        }
        public void Xoa(string MaCa)
        {
            try
            {
                CaLamViec ca = db.CaLamViec.Find(MaCa);
                if(ca != null)
                {
                    db.CaLamViec.Remove(ca);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public string GetMaCaTiepTheo()
        {
            string next = string.Empty;
            next = db.CaLamViec.Max(ca => ca.MaCa);

            if (next == null) next = "C000000";
            string tmp = next.Replace("C", "");

            next = "C" + (double.Parse(tmp) + 1).ToString("000000");

            return next;
        }
    }
}
