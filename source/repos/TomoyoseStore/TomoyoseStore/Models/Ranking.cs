using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomoyoseStore.Models
{
    public class Ranking
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

    }
}
