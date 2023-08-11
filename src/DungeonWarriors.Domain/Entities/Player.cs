using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Domain.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateOnly createdOn { get; set; }
        public int MaxScore { get; set; }
        public int Coins { get; set; }

        public virtual Weapon Weapon { get; set; }
    }
}
