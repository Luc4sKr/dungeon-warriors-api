using DungeonWarriors.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Domain.DTO
{
    public class PlayerDTO
    {
        public int id { get; set; }
        public string username { get; set; }
        public int score { get; set; }
        public int coins { get; set; }
        public List<CharacterDTO> characters { get; set; }
    }
}
