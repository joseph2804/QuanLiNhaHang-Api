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
    public class BillsController : ControllerBase
    {
        private readonly QuanLiContext _db;
        public BillsController(QuanLiContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExportOrder>>> Get()
        {
            return await _db.ExportOrders
                         .ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ExportOrder>> Get(int id)
        {
            var exportOrder = await _db.ExportOrders
                                .Where(r => r.Id == id)
                                .FirstOrDefaultAsync();


            if (exportOrder == null)
            {
                return NoContent();
            }

            return exportOrder;
        }
        [HttpPost]
        public async Task<ActionResult<ExportOrder>> Add(ExportOrder exportOrder)
        {
            exportOrder.Exp_Date = DateTime.Now;
            _db.Add(exportOrder);
            await _db.SaveChangesAsync();
            return CreatedAtAction("get", new { id = exportOrder.Id }, exportOrder);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ExportOrder>> Edit(int id)
        {
            var exportOrder = await _db.ExportOrders.FindAsync(id);
            if (exportOrder == null)
            {
                return NotFound();
            }
            exportOrder.Exp_Status = 1;

            //_db.TodoItems.Update(todo);
            await _db.SaveChangesAsync();

            return Ok(exportOrder);
        }

    }
}
