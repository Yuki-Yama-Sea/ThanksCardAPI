using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomoyoseStore.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        // 多対1: Favorite エンティティは1つの Employee エンティティに属する
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        // 多対1: Favorite エンティティは1つの Card エンティティに属する
        public int CardId { get; set; }
        public virtual Card Card { get; set; }
    }
}
