using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Domain.Entities
{
    [Table("Characters")]
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Life { get; set; }
        public int Strength { get; set; }

        public int WeaponId { get; set; }
        public virtual Weapon? Weapon { get; set; }

        public int PlayerId { get; set; }
        public virtual Player? Player { get; set; }
    }
}
