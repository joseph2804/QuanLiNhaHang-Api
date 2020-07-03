using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhaHang_API.Models
{   
    [Table("Tables")]
    public class Table
    {
        public int Id { get; set; }
        [Key]
        public string Tab_Id { get; set; }
        public string Epl_Id { get; set; }
        [ForeignKey("Epl_Id")]
        public virtual Employee Employee { get; set; }
        public virtual ICollection<ExportOrder> ExportOrders { get; set; }
    }
}
