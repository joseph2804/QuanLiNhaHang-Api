using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhaHang_API.Models
{
    [Table("Types")]
    public class Type
    {
        public int Id { get; set; }
        [Key]
        public string Ty_Id { get; set; }
        public string Ty_Name { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
