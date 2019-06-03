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

        // POST api/logonAdmin
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            var authorizedUser = _context.Employees.SingleOrDefault(x => x.Mailaddress == employee.Mailaddress && x.Password == employee.Password && x.Id == 1);
            if (authorizedUser == null)
            {
                return NotFound();
            }
            return authorizedUser;
        }

    }
}