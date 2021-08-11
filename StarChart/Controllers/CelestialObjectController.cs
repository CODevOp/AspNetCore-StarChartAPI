using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StarChart.Data;
using StarChart.Models;

namespace StarChart.Controllers
{
    [ApiController]
    [Route("")]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}", Name = "GetById")]
        public IActionResult GetById(int id) {
            var value = _context.CelestialObjects.FirstOrDefault(e => e.Id == id);

            if(value == null)
            {

                return NotFound();
            }
            return NotFound();

            
        }
        //[HttpGet("{name}")]
        //public IActionResult GetByName(string name) { }

        //public IActionResult GetAll() { 
        //    _context<CelestialObject>.
        //}
    }
}
