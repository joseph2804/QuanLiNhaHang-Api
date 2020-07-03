using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhaHang_API.Models
{
    [Table("Suppliers")]
    public class Supplier
    {
        public int Id { get; set; }
        [Key]
        public string Sup_Id { get; set; }
        [Column("Sup_NameSupplier")]
        public string Name { get; set; }
        [Column("Sup_Address")]
        public string Address { get; set; }
    }
}
