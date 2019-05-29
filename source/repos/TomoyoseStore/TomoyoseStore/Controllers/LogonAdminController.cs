using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TomoyoseStore.Models;

namespace TomoyoseStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogonAdminController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public LogonAdminController(ApplicationContext context)
        {
            _context = context;
        }



    }
}