using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Domain.DTO
{
    public class CharacterDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int life { get; set; }
        public int strength { get; set; }
        public int weaponId { get; set; }
        public WeaponDTO? weapon { get; set; }
    }
}
