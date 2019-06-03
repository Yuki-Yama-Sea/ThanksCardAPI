using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomoyoseStore.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Card Card { get; set; }
    }
}
