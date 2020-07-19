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
    public class CongViecController
    {
        public static bool AddCV(ClassCongViec cv)
        {
            try
            {
                using (var _context = new DBManageContext())
                {

                    ClassCongViec congviec = new ClassCongViec { MaCV = cv.MaCV, TenCV = cv.TenCV, ChiTiet = cv.ChiTiet };

                    _context.tbCongViec.Add(congviec);
                    _context.SaveChanges();

                    var dbcv = (from c in _context.tbCongViec
                                where c.MaCV == cv.MaCV
                                select c).Single();

                    foreach (var i in cv.listDA)
                    {
                        var dbda = (from d in _context.tbDuAn
                                    where d.MaDA == i.MaDA
                                    select d).Single();
                        dbcv.listDA.Add(dbda);
                    }
                    _context.tbCongViec.AddOrUpdate(dbcv);
                    _context.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static List<ClassCongViec> GetListCV()
        {
            using (var _context = new DBManageContext())
            {
                var cv = (from c in _context.tbCongViec.Include("listDA")
                          select c).ToList();
                return cv;
            }
        }
        public static List<ClassCongViec> GetListCV(string macv)
        {
            using (var _context = new DBManageContext())
            {
                
                var cv = (from c in _context.tbCongViec.Include("listDA")
                          where c.MaCV.Contains(macv)
                          select c).ToList();
                return cv;
            }
        }
        public static ClassCongViec GetCV(string MaCV)
        {
            using (var _context = new DBManageContext())
            {
                var cv = (from d in _context.tbCongViec.Include("listDA").Include("listNVLam").Include("listNVXong")
                          where MaCV == d.MaCV
                          select d).ToList();
                if (cv.Count == 1)
                    return cv[0];
                else
                    return null;
            }
        }
        public static bool DeleteCV(ClassCongViec cv)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    var task = (from t in _context.tbCongViec
                                where t.MaCV == cv.MaCV
                                select t).Single();
                    _context.tbCongViec.Remove(task);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            
        }
        public static bool UpdateCV(ClassCongViec cv)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    ClassCongViec congviec = new ClassCongViec { MaCV = cv.MaCV, TenCV = cv.TenCV, ChiTiet = cv.ChiTiet };
                    foreach(var d in cv.listDA)
                    {
                        var dbda = (from da in _context.tbDuAn
                                    where da.MaDA == d.MaDA
                                    select da).Single();
                        congviec.listDA.Add(dbda);
                    }
                    _context.tbCongViec.AddOrUpdate(congviec);
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
