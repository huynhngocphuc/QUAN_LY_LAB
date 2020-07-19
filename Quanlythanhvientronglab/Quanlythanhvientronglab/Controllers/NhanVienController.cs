using Quanlythanhvientronglab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Controllers
{
    public class NhanVienController
    {
        public static ClassNhanVien GetNV(string MaNhanVien)
        {
            using (var _context = new DBManageContext())
            {
                var nv = (from n in _context.tbNhanVien.Include("ListCVLam").Include("ListCVXong")
                          where MaNhanVien == n.MaNV
                          select n).ToList();
                if (nv.Count == 1)
                    return nv[0];
                else
                    return null;
            }
        }
        public static bool AddNV(ClassNhanVien nv)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    _context.tbNhanVien.Add(nv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<ClassNhanVien> GetLuongNV()
        {
            using(var _context=new DBManageContext())
            {
                var nvien = (from nv in _context.tbNhanVien.AsEnumerable()
                             select new
                             {
                                 MaNV = nv.MaNV,
                                 TenNV = nv.TenNV,
                                 TienDo = nv.TienDo,
                                 Luong = nv.Luong
                             }).Select(x => new ClassNhanVien
                             {
                                 MaNV = x.MaNV,
                                 TenNV = x.TenNV,
                                 TienDo = x.TienDo,
                                 Luong = x.Luong
                             }).ToList();
                return nvien;
                
            }
        }
        public static List<ClassNhanVien> GetListNvien()
        {
            using (var _context = new DBManageContext())
            {
                var nv = (from nvien in _context.tbNhanVien.Include("listCVLam").Include("listCVXong").AsEnumerable()
                          select new
                          {
                              MaNV = nvien.MaNV,
                              MaDA = nvien.MaDA,
                              listCVLam = nvien.listCVLam,
                              listCVXong = nvien.listCVXong,
                              TienDo = nvien.TienDo
                          }).Select(x => new ClassNhanVien
                          {
                              MaNV = x.MaNV,
                              MaDA = x.MaDA,
                              listCVLam = x.listCVLam,
                              listCVXong = x.listCVXong,
                              TienDo = x.TienDo
                          }).ToList();
                return nv;
            }
        }
        public static List<ClassNhanVien> GetListNV()
        {
            using (var _context = new DBManageContext())
            {
                var nv = (from nvien in _context.tbNhanVien.AsEnumerable()
                          select new
                          {
                              MaNV = nvien.MaNV,
                              TenNV = nvien.TenNV,
                              GioiTinh =nvien.GioiTinh,
                              DiaChi=nvien.DiaChi,
                              NgaySinh=nvien.NgaySinh,
                              SDT=nvien.SDT,
                              Email=nvien.Email,
                              MaChucVu=nvien.MaChucVu
                          }).Select(x => new ClassNhanVien
                          {
                              MaNV = x.MaNV,
                              TenNV = x.TenNV,
                              GioiTinh = x.GioiTinh,
                              DiaChi = x.DiaChi,
                              NgaySinh = x.NgaySinh,
                              SDT = x.SDT,
                              Email = x.Email,
                              MaChucVu = x.MaChucVu

                          }).ToList();
                return nv;
            }
        }
        public static bool DeleteNV(string Manv)
        {
            try
            {
                using(var _context=new DBManageContext())
                {
                    var dbnv = (from nv in _context.tbNhanVien
                                where nv.MaNV == Manv
                                select nv).Single();
                    _context.tbNhanVien.Remove(dbnv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateNV(ClassNhanVien nv)
        {
            try
            {
                using (var _context=new DBManageContext())
                {
                    _context.tbNhanVien.AddOrUpdate(nv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateNvien(ClassNhanVien nvien)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    var dbnv = (from nv in _context.tbNhanVien.Include("listCVLam").Include("listCVXong")
                                where nv.MaNV == nvien.MaNV
                                select nv).Single();
                    
                    foreach (var cvgiao in dbnv.listCVLam.ToList())
                        dbnv.listCVLam.Remove(cvgiao);
                    foreach (var cvxong in dbnv.listCVXong.ToList())
                        dbnv.listCVXong.Remove(cvxong);

                    foreach (var permistask in nvien.listCVLam)
                    {
                        var dbcv = (from cv in _context.tbCongViec
                                    where cv.MaCV == permistask.MaCV
                                    select cv).Single();
                        dbnv.listCVLam.Add(dbcv);
                    }

                    foreach (var finistask in nvien.listCVXong)
                    {
                        var dbcv = (from cv in _context.tbCongViec
                                    where cv.MaCV == finistask.MaCV
                                    select cv).Single();
                        dbnv.listCVXong.Add(dbcv);
                    }

                    dbnv.TienDo = dbnv.listCVXong.Count.ToString() + '/' + dbnv.listCVLam.Count.ToString();
                    dbnv.Luong = 1000000 * dbnv.listCVXong.Count;
                    dbnv.MaDA = nvien.MaDA;

                    _context.tbNhanVien.AddOrUpdate(dbnv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
