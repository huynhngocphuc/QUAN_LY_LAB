using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    [Table("DuAn")]
    public class ClassDuAn
    {
        public ClassDuAn()
        {
            this.listCV = new HashSet<ClassCongViec>();
        }
        [Key]
        public string MaDA { set; get; }
        public string TenDA { set; get; }
        public string ChiTiet { set; get; }
        public DateTime fromDate { set; get; }
        public DateTime toDate { set; get; }        
        public virtual ICollection<ClassCongViec> listCV { set; get; }
        public override string ToString()
        {
            return MaDA;
        }
    }
}
