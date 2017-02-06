using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DungonMasterToolsRepository;

namespace DungonMasterToolsRepository.Migrations
{
    [DbContext(typeof(DungonMasterToolsDbContext))]
    [Migration("20170206053945_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DungeonMasterTools.Models.Entities.EntityActionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttackBonus");

                    b.Property<string>("DamageBonus");

                    b.Property<string>("DamageDice");

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("DungeonMasterTools.Models.Entities.EntitySpecialAbilityModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttackBonus");

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SpecialAbilities");
                });

            modelBuilder.Entity("DungeonMasterTools.Models.Entities.MonsterActions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActionId");

                    b.Property<int?>("EntitySpecialAbilityModelId");

                    b.Property<int>("MonsterId");

                    b.HasKey("Id");

                    b.HasAlternateKey("MonsterId", "ActionId");

                    b.HasIndex("ActionId");

                    b.HasIndex("EntitySpecialAbilityModelId");

                    b.ToTable("MonsterActions");
                });

            modelBuilder.Entity("DungeonMasterTools.Models.Entities.MonsterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alignment");

                    b.Property<int>("ArmorClass");

                    b.Property<string>("ChallengeRating");

                    b.Property<int>("Charisma");

                    b.Property<string>("ConditionImmunities");

                    b.Property<int>("Constitution");

                    b.Property<string>("DamageImmunities");

                    b.Property<string>("DamageResistences");

                    b.Property<string>("DamageVulnerabilities");

                    b.Property<int>("Dexterity");

                    b.Property<string>("HitDice");

                    b.Property<int>("HitPoints");

                    b.Property<int>("Intelligence");

                    b.Property<string>("Languages");

                    b.Property<string>("Name");

                    b.Property<int>("Perception");

                    b.Property<string>("Senses");

                    b.Property<string>("Size");

                    b.Property<string>("Speed");

                    b.Property<int>("Strength");

                    b.Property<string>("SubType");

                    b.Property<string>("Type");

                    b.Property<int>("Wisdom");

                    b.HasKey("Id");

                    b.ToTable("Monsters");
                });

            modelBuilder.Entity("DungeonMasterTools.Models.Entities.MonsterSpecialAbilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EntityActionModelId");

                    b.Property<int>("MonsterId");

                    b.Property<int>("SpecialAbilityId");

                    b.HasKey("Id");

                    b.HasIndex("EntityActionModelId");

                    b.HasIndex("MonsterId");

                    b.HasIndex("SpecialAbilityId");

                    b.ToTable("MonsterSpecialAbilities");
                });

            modelBuilder.Entity("DungeonMasterTools.Models.Items.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Rarity");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DungeonMasterTools.Models.Entities.MonsterActions", b =>
                {
                    b.HasOne("DungeonMasterTools.Models.Entities.EntityActionModel", "Action")
                        .WithMany("MonsterActions")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DungeonMasterTools.Models.Entities.EntitySpecialAbilityModel")
                        .WithMany("MonsterActions")
                        .HasForeignKey("EntitySpecialAbilityModelId");

                    b.HasOne("DungeonMasterTools.Models.Entities.MonsterModel", "Monster")
                        .WithMany("MonsterActions")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DungeonMasterTools.Models.Entities.MonsterSpecialAbilities", b =>
                {
                    b.HasOne("DungeonMasterTools.Models.Entities.EntityActionModel")
                        .WithMany("MonsterSpecialAbilities")
                        .HasForeignKey("EntityActionModelId");

                    b.HasOne("DungeonMasterTools.Models.Entities.MonsterModel", "Monster")
                        .WithMany("MonsterSpecialAbilities")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DungeonMasterTools.Models.Entities.EntitySpecialAbilityModel", "SpecialAbility")
                        .WithMany("MonsterSpecialAbilities")
                        .HasForeignKey("SpecialAbilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
