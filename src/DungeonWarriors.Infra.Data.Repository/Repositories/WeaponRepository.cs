﻿using DungeonWarriors.Domain.Entities;
using DungeonWarriors.Domain.Interfaces.IRepositories;
using DungeonWarriors.Infra.Data.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Infra.Data.Repository.Repositories
{
    public class WeaponRepository : BaseRepository<Weapon>, IWeaponRepository
    {
        public WeaponRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
