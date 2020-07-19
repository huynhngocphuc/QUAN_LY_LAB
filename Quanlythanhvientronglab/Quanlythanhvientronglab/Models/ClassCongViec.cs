using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    [Table("CongViec")]
    public class ClassCongViec
    {

        public ClassCongViec()
        {
            listDA = new HashSet<ClassDuAn>();
            listNVLam = new HashSet<ClassNhanVien>();
            listNVXong = new HashSet<ClassNhanVien>();
        }
        [Key]
        public string MaCV { set; get; }
        public string TenCV { set; get; }
        public string ChiTiet { set; get; }
        public virtual ICollection<ClassDuAn> listDA { set; get; }
        public virtual ICollection<ClassNhanVien> listNVLam { set; get; }
        public virtual ICollection<ClassNhanVien> listNVXong { set; get; }
        public override string ToString()
        {
            return this.MaCV;
        }

    }
}
