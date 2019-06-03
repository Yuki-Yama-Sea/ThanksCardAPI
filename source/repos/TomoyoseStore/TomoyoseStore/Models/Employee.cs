using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomoyoseStore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int CD { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mailaddress { get; set; }

        // 多対1: Employee エンティティは1つの Section エンティティに属する
        public int SectionId { get; set; }
        public virtual Section Section { get; set; }
    }
}
