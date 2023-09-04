using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Domain.DTO
{
    public class WeaponDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int damage { get; set; }
    }
}
