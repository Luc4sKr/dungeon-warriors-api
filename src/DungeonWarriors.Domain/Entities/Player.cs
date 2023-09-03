using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Domain.Entities
{
    [Table("Players")]
    public class Player
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }

        [Required]
        public DateOnly CreatedOn { get; set; }

        public int Score { get; set; }
        public int Coins { get; set; }

        public virtual ICollection<Character>? Characters { get; set; }
    }
}
