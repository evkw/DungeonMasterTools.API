using DungeonMasterTools.Models.Entities;
using Microsoft.EntityFrameworkCore;
using DungeonMasterTools.Models.Items;

namespace DungonMasterToolsRepository
{
    public class DungonMasterToolsDbContext: DbContext
    {
        public DungonMasterToolsDbContext(DbContextOptions<DungonMasterToolsDbContext> options)
            : base(options)
        {

        }
        public DbSet<ItemModel> Items { get; set; }

        public DbSet<MonsterModel> Monsters { get; set; }
        
        public DbSet<EntityActionModel> Actions { get; set; }

        public DbSet<EntitySpecialAbilityModel> SpecialAbilities { get; set; }

        public DbSet<MonsterActions> MonsterActions { get; set; }
        public DbSet<MonsterSpecialAbilities> MonsterSpecialAbilities { get; set; } 

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ItemModel>()
                        .HasKey(i => i.Id);

            modelBuilder.Entity<MonsterModel>()
                        .HasKey(m => m.Id);

            modelBuilder.Entity<EntityActionModel>()
                        .HasKey(a => a.Id);

            modelBuilder.Entity<EntitySpecialAbilityModel>()
                        .HasKey(sa => sa.Id);

            modelBuilder.Entity<MonsterActions>()
                        .HasKey(ma => new { ma.MonsterId, ma.ActionId });

            modelBuilder.Entity<MonsterActions>()
                        .HasKey(ma => ma.Id);

            modelBuilder.Entity<MonsterActions>()
                        .HasOne(ma => ma.Monster)
                        .WithMany(m => m.MonsterActions)
                        .HasForeignKey(ma => ma.MonsterId);

            modelBuilder.Entity<MonsterActions>()
                        .HasOne(ma => ma.Action)
                        .WithMany(a => a.MonsterActions)
                        .HasForeignKey(ma => ma.ActionId);

            modelBuilder.Entity<MonsterSpecialAbilities>()
                        .HasKey(msa => msa.Id);

            modelBuilder.Entity<MonsterSpecialAbilities>()
                        .HasOne(ma => ma.Monster)
                        .WithMany(m => m.MonsterSpecialAbilities)
                        .HasForeignKey(ma => ma.MonsterId);

            modelBuilder.Entity<MonsterSpecialAbilities>()
                        .HasOne(ma => ma.SpecialAbility)
                        .WithMany(a => a.MonsterSpecialAbilities)
                        .HasForeignKey(ma => ma.SpecialAbilityId);
        }
    }
}
