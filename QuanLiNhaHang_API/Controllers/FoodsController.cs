using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLiNhaHang_API.Models;

namespace QuanLiNhaHang_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly QuanLiContext _db;
        public FoodsController(QuanLiContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Food>>> Get()
        {
            return await _db.Foods  
                         .Include(f => f.Type) 
                         .ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> Get(long id)
        {
            var food = await _db.Foods.Where(f => f.Id == id)
                                      .FirstOrDefaultAsync();

            if (food == null)
            {
                return NoContent();
            }

            return food;
        }
    }
}
