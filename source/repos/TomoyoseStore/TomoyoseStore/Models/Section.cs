using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomoyoseStore.Models
{
    public class Section
    {
        public int Id { get; set; }
        public int CD { get; set; }
        public string Name { get; set; }

        // 多対1: Section エンティティは1つの Department エンティティに属する
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
