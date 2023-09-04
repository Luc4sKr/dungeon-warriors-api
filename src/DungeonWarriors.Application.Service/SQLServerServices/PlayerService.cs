using DungeonWarriors.Domain.DTO;
using DungeonWarriors.Domain.Entities;
using DungeonWarriors.Domain.Interfaces.IRepositories;
using DungeonWarriors.Domain.Interfaces.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Application.Service.SQLServerServices
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            this._playerRepository = playerRepository;
        }

        public List<PlayerDTO> FindAll()
        {
            return this._playerRepository
                .FindAll()
                .Select(player => new PlayerDTO()
                {
                    id = player.Id,
                    username = player.Username,
                    score = player.Score,
                    coins = player.Coins,
                    characters = player.Characters
                        .Select(characer => new CharacterDTO()
                        {
                            id = characer.Id,
                            name = characer.Name,
                        })
                        .ToList()
                })
                .AsNoTracking()
                .ToList();
        }

        public Task<PlayerDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(Player entity)
        {
            return _playerRepository.Save(entity);
        }

        public Task<int> Update(PlayerDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(PlayerDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
