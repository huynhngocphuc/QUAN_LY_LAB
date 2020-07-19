using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    public class DBManageContext:DbContext
    {
        public DBManageContext() : base("name=DBManageMembers") { }
        public DbSet<ClassChucVu> tbChucVu { set; get; }
        public DbSet<ClassNhanVien> tbNhanVien { set; get; }
        public DbSet<ClassDuAn> tbDuAn { set; get; }
        public DbSet<ClassCongViec> tbCongViec { set; get; }        
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ClassTask>()
            //    .HasMany<ClassUser>(s => s.listUser)
            //    .WithMany(c => c.listTasks)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("TaskRefId");
            //        cs.MapRightKey("UserRefId");
            //        cs.ToTable("TaskUser");
            //    });

            modelBuilder.Entity<ClassDuAn>()
                .HasMany<ClassCongViec>(s => s.listCV)
                .WithMany(c => c.listDA)
                .Map(cs =>
                {
                    cs.MapLeftKey("DuAnRefId");
                    cs.MapRightKey("CongViecRefId");
                    cs.ToTable("DuAnCongViec");
                });
            modelBuilder.Entity<ClassNhanVien>()
                .HasMany<ClassCongViec>(s => s.listCVLam)
                .WithMany(c => c.listNVLam)
                .Map(cs =>
                {
                    cs.MapLeftKey("NhanVienRefId");
                    cs.MapRightKey("CongViecLamRefId");
                    cs.ToTable("NhanVienCongViecLam");
                });

            modelBuilder.Entity<ClassNhanVien>()
                .HasMany<ClassCongViec>(s => s.listCVXong)
                .WithMany(c => c.listNVXong)
                .Map(cs =>
                {
                    cs.MapLeftKey("NhanVienRefId");
                    cs.MapRightKey("CongViecGiaoRefId");
                    cs.ToTable("NhanVienCongViecGiao");
                });
        }
    }
}
