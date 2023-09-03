using DungeonWarriors.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonWarriors.Infra.Data.Repository.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Character>()
            //    .HasOne(character => character.Player)
            //    .WithMany(player => player.Characters)
            //    .HasForeignKey(character => character.PlayerId);

            //modelBuilder.Entity<Character>()
            //    .HasOne(character => character.Weapon)
            //    .WithOne(weapon => weapon.Character)
            //    .HasForeignKey<Character>(character => character.WeaponId);
        }

        #region DbSets
        public DbSet<Player> Players { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        #endregion
    }
}
