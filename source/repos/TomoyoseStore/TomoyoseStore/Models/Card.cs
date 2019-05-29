using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomoyoseStore.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int CD { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public virtual Employee From { get; set; }
        public virtual Employee To { get; set; }
        public string Title { get; set; }
        public int Reply { get; set; }
        public int Favorite { get; set; }
        public int PickUp { get; set; }


        // 多対1: User エンティティは1つの Department エンティティに属する
        //public virtual Department Department { get; set; }
    }
}
