using Quanlythanhvientronglab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Controllers
{
    public class ChucVuController    {
        public static ClassChucVu GetCVu(string MaChucVu)
        {
            using (var _context = new DBManageContext())
            {
                var cv = (from d in _context.tbChucVu
                          where MaChucVu==d.MaChucVu
                          select d).ToList();
                if (cv.Count == 1)
                    return cv[0];
                else
                    return null;
            }
        }
        public static bool AddCVu(ClassChucVu cvu)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    _context.tbChucVu.Add(cvu);
                    _context.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static List<ClassChucVu> GetListCVu()
        {
            using (var _context = new DBManageContext())
            {
                var cvu = (from c in _context.tbChucVu
                          select c).ToList();
                return cvu;
            }
        }
        public static bool DeleteCVu(string machucvu)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    var cv = (from c in _context.tbChucVu
                                where c.MaChucVu==machucvu
                                select c).Single();
                    _context.tbChucVu.Remove(cv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        public static bool UpdateChucVu(ClassChucVu cvu)
        {
            try
            {
                using(var _context=new DBManageContext())
                {
                    _context.tbChucVu.AddOrUpdate(cvu);
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
