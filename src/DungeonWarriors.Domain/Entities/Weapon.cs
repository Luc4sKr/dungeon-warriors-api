using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Domain.Entities
{
    [Table("Weapons")]
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Damage { get; set; }

        public virtual Character? Character { get; set; }
    }
}
