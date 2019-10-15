using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAcessLayer
{
    public class BAL_NhanVien
    {
        CoffeeEntities db;
        public BAL_NhanVien()
        {
            db = new CoffeeEntities();
        }
        
        public List<NhanVien> Get_NhanVien()
        {
            return (from nv in db.NhanVien select nv).OrderBy(NV => NV.MaNV).ToList();
        }
        public NhanVien Get_NhanVien(string MaNV)
        {
            return (from nv in db.NhanVien where nv.MaNV.ToUpper() == MaNV.ToUpper() select nv).FirstOrDefault();
        }
        public void CapNhat(NhanVien nv0)
        {
            try
            {
                NhanVien nv = db.NhanVien.Find(nv0.MaNV);
                if(nv != null)
                {
                    nv.MaNV = nv0.MaNV;
                    nv.HoTen = nv0.HoTen;
                    nv.NgaySinh = nv0.NgaySinh;
                    nv.Phai = nv0.Phai;
                    nv.CMND = nv0.CMND;
                    nv.SDT = nv0.SDT;
                    nv.DiaChi = nv0.DiaChi;
                    nv.NgayVaoLam = nv0.NgayVaoLam;
                    nv.Luong = nv0.Luong;
                    nv.MatKhau = nv0.MatKhau;
                    nv.Quyen = nv0.Quyen;
                    nv.HinhAnh = nv0.HinhAnh;
                    nv.Status = nv0.Status;

                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }
        public void Them(NhanVien nv0)
        {
            try
            {
                var nv = new NhanVien()
                {
                    MaNV = nv0.MaNV,
                    HoTen = nv0.HoTen,
                    NgaySinh = nv0.NgaySinh,
                    Phai = nv0.Phai,
                    CMND = nv0.CMND,
                    SDT = nv0.SDT,
                    DiaChi = nv0.DiaChi,
                    NgayVaoLam = nv0.NgayVaoLam,
                    Luong = nv0.Luong,
                    MatKhau = nv0.MatKhau,
                    Quyen = nv0.Quyen,
                    HinhAnh = nv0.HinhAnh,
                    Status = nv0.Status
                };

                db.NhanVien.Add(nv);
                db.SaveChanges();
            }
            catch
            {
            }
        }
        public void Xoa(string MaNV)
        {
            try
            {
                NhanVien nv = db.NhanVien.Find(MaNV);
                if(nv != null)
                {
                    db.NhanVien.Remove(nv);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
        public bool SetStatus(string MaNV, bool Status)
        {
            try
            {
                NhanVien nv = db.NhanVien.Find(MaNV);
                if(nv != null)
                {
                    nv.Status = Status;

                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public string GetMaNVTiepTheo()
        {
            string next = string.Empty;
            next = db.NhanVien.Max(nv => nv.MaNV);

            if (next == null) next = "NV000000";
            string tmp = next.Replace("NV", "");

            next = "NV" + (double.Parse(tmp) + 1).ToString("000000");

            return next;
        }
    }
}
