using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TomoyoseStore.Models;

namespace TomoyoseStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public RankingController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ranking>>> GetRanking()
        {

            return await _context.Cards

                             .GroupBy(t => t.To)
                             .Select(t => new Ranking { Name = t.Select(y => y.To.Name).ToList()[0], Count = t.Count() })
                             .OrderByDescending(t => t.Count)
                             .ToListAsync();                       
        }

    }
}