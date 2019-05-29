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
    public class LogonController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public LogonController(ApplicationContext context)
        {
            _context = context;
        }


        // POST api/logon
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            var authorizedUser = _context.Employees.SingleOrDefault(x => x.Name == employee.Mailaddress && x.Password == employee.Password);
            if (authorizedUser == null)
            {
                return NotFound();
            }
            return authorizedUser;
        }

    }
}