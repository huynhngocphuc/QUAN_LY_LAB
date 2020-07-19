using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    [Table("HoSoNV")]
    public class ClassNhanVien
    {
        public ClassNhanVien()
        {
            this.listCVLam = new HashSet<ClassCongViec>();
            this.listCVXong = new HashSet<ClassCongViec>();
            this.Luong = 0;
        }
        [Key]
        [Column(Order =10)]
        public string MaNV { set; get; }        
        public string TenNV { set; get; }
        public DateTime NgaySinh { set; get; }
        public string GioiTinh { set; get; }
        public string SDT { set; get; }
        public string Email { set; get; }   
        public string DiaChi { set; get; }       
        public string MaChucVu { set; get; }       
        public int Luong { set; get; }
        public string TienDo { set; get; }
        public string MaDA { set; get; }
        public virtual ICollection<ClassCongViec> listCVLam { set; get; }
        public virtual ICollection<ClassCongViec> listCVXong { set; get; }
        public override string ToString()
        {
            return MaNV;
        }
    }
}
