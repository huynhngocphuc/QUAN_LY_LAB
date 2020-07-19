using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    [Table("ChucVu")]
    public class ClassChucVu
    {        
        [Key]        
        public string MaChucVu { set; get; }        
        public string TenChucVu { set; get; }
        public override string ToString()
        {
            return MaChucVu;
        }
    }
}
