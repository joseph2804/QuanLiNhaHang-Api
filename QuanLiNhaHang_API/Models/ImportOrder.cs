using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhaHang_API.Models
{
    [Table("ImportOrders")]
    public class ImportOrder
    {
        public int Id { get; set; }
        [Key]
        public string Imp_Id { get; set; }
        public string Epl_Id { get; set; }
        public string Sup_Id { get; set; }
        public DateTime Imp_Date { get; set; }
        [ForeignKey("Sup_Id")]
        public virtual Supplier Supplier { get; set; }
        [ForeignKey("Epl_Id")]
        public virtual Employee Employee { get; set; }
        public virtual ICollection<DetailExportOrder> DetailExportOrders { get; set; }
    }
}
