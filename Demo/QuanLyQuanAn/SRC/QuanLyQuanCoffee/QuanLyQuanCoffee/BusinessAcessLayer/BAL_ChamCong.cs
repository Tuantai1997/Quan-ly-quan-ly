using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_ChamCong
    {
        CoffeeEntities db;
        public BAL_ChamCong()
        {
            db = new CoffeeEntities();
        }
        public DateTime GetMinID()
        {
            DateTime min = DateTime.Now;
            if (db.ChamCong.Count() == 0) return min;
            min = (db.ChamCong.Min(cc0 => cc0.ID));
            return min;
        }
        //Get danh sách chấm công
        public List<ChamCong> Get()
        {
            return (from cc in db.ChamCong select cc).ToList();
        }
        //Get danh sách chấm công theo ngày
        public List<ChamCong> Get(DateTime ID)
        {
            return (from cc in db.ChamCong where cc.ID == ID.Date select cc).ToList();
        }
        //Get danh sách chấm công theo ngày và ca
        public List<ChamCong> Get(DateTime ID, string MaCa)
        {
            return (from cc in db.ChamCong where cc.ID == ID.Date && cc.MaCa == MaCa select cc).ToList();
        }
        //Get ChamCong theo primary key
        public ChamCong Get(DateTime ID, string MaNV, string MaCa)
        {
            return (from cc in db.ChamCong where cc.ID == ID.Date && cc.MaNV == MaNV && cc.MaCa == MaCa select cc).FirstOrDefault();
        }
        //Get ChamCong theo tháng, năm
        public List<ChamCong> Get(int Thang, int Nam)
        {
            return (from cc in db.ChamCong where cc.Thang == Thang && cc.Nam == Nam select cc).ToList();
        }
        //Cập nhật
        public void CapNhat(ChamCong cc)
        {
            try
            {
                ChamCong c = db.ChamCong.Find(cc.ID, cc.MaNV, cc.MaCa);
                if(c != null)
                {
                    c.ID = cc.ID;
                    c.MaNV = cc.MaNV;
                    c.MaCa = cc.MaCa;
                    c.Thang = cc.Thang;
                    c.Nam = cc.Nam;
                    c.TinhTrang = cc.TinhTrang;

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public void Them(ChamCong cc)
        {
            try
            {
                var c = new ChamCong()
                {
                    ID = cc.ID,
                    MaNV = cc.MaNV,
                    MaCa = cc.MaCa,
                    Thang = cc.Thang,
                    Nam = cc.Nam,
                    TinhTrang = cc.TinhTrang
                };
                db.ChamCong.Add(c);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public void Xoa(DateTime ID, string MaNV, string MaCa)
        {
            try
            {
                ChamCong cc = db.ChamCong.Find(ID, MaNV, MaCa);
                if(cc != null)
                {
                    db.ChamCong.Remove(cc);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
    }
}
