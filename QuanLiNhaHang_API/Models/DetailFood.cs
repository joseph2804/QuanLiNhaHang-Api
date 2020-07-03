using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhaHang_API.Models
{
    [Table("DETAILFOODS")]
    public class DetailFood
    {
        public int Id { get; set; }
        [Key]
        public string DeFood_Id { get; set; }
        public string Pro_Id { get; set; }
        public string Foo_Id { get; set; }
        [Column("DEFOO_QUANTITY")]
        public int Quantity { get; set; }
        [ForeignKey("Foo_Id")]
        public virtual Food Food { get; set; }
        [ForeignKey("Pro_Id")]
        public virtual Product Product { get; set; }
    }
}
