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
        public string Title { get; set; }
        public bool Reply { get; set; }
        public bool Favorite { get; set; }
        public bool PickUp { get; set; }


        // 多対1: Card エンティティは1つの Employee エンティティに属する
        public int FromId { get; set; }
        public virtual Employee From { get; set; }
        // 多対1: Card エンティティは1つの Employee エンティティに属する
        public int ToId { get; set; }
        public virtual Employee To { get; set; }
    }
}