using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_ThongTinQuan
    {
        CoffeeEntities db;
        public BAL_ThongTinQuan()
        {
            db = new CoffeeEntities();
        }

        public ThongTinQuan Get()
        {
            return (from tt in db.ThongTinQuan where tt.ID == "0" select tt).FirstOrDefault();
        }
        public void CapNhat(string TenQuan, string DiaChi, string SDT, string Email, byte[] HinhAnh)
        {
            try
            {
                ThongTinQuan tt = db.ThongTinQuan.Find("0");
                if(tt != null)
                {
                    tt.TenQuan = TenQuan;
                    tt.DiaChi = DiaChi;
                    tt.SDT = SDT;
                    tt.Email = Email;
                    tt.HinhAnh = HinhAnh;

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public void CapNhat(ThongTinQuan tt0)
        {
            try
            {
                ThongTinQuan tt = db.ThongTinQuan.Find("0");
                if (tt != null)
                {
                    tt.TenQuan = tt0.TenQuan;
                    tt.DiaChi = tt0.DiaChi;
                    tt.SDT = tt0.SDT;
                    tt.Email = tt0.Email;
                    tt.HinhAnh = tt0.HinhAnh;

                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
    }
}
