﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhaHang_API.Models
{
    [Table("Foods")]
    public class Food
    {
        
        public int Id { get; set; }
        [Key]
        public string Foo_Id { get; set; }
        public string EPL_Id { get; set; }
        public string Ty_Id { get; set; }
        public string Foo_Name { get; set; }
        public int Foo_Price { get; set; }
        [ForeignKey("Epl_Id")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("Ty_Id")]
        public virtual Type Type { get; set; }
        public virtual ICollection<DetailExportOrder> DetailExportOrders { get; set; }
        public virtual ICollection<DetailFood> DetailFoods { get; set; }
    }
}
