using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StarChart.Data;

namespace StarChart.Controllers
{
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly ApplicationDbContext _context { get; set; }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
