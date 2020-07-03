using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhaHang_API.Models
{
    [Table("DetailExportOrders")]
    public class DetailExportOrder
    {
        public int Id { get; set; }
        [Key]
        public string DeExp_Id { get; set; }
        public string  Exp_Id { get; set; }
        public string Foo_Id { get; set; }
        [Column("DeExp_Quantity")]
        public int Quantity { get; set; }
        public int DeExp_Status { get; set; }
        [ForeignKey("Foo_Id")]
        public virtual Food Food { get; set; }
        [ForeignKey("Exp_Id")]
        public virtual ExportOrder ExportOrder { get; set; }

    }
}
