using DungeonWarriors.Domain.DTO;
using DungeonWarriors.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Domain.Interfaces.IServices
{
    public interface IPlayerService
    {
        List<PlayerDTO> FindAll();
        Task<PlayerDTO> FindById(int id);
        Task<int> Save(Player entity);
        Task<int> Update(PlayerDTO entity);
        Task<int> Delete(PlayerDTO entity);
    }
}
