using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhaHang_API.Models
{
    public class QuanLiContext: DbContext 
    {
        public QuanLiContext(DbContextOptions<QuanLiContext> options) : base(options) { }
        //mapping model class
        public DbSet<Food> Foods { get; set; }
    }
}
