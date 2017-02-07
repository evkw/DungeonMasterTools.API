using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonMasterToolsRepository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttackBonus = table.Column<int>(nullable: false),
                    DamageBonus = table.Column<string>(nullable: true),
                    DamageDice = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttackBonus = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialAbilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alignment = table.Column<string>(nullable: true),
                    ArmorClass = table.Column<int>(nullable: false),
                    ChallengeRating = table.Column<string>(nullable: true),
                    Charisma = table.Column<int>(nullable: false),
                    ConditionImmunities = table.Column<string>(nullable: true),
                    Constitution = table.Column<int>(nullable: false),
                    DamageImmunities = table.Column<string>(nullable: true),
                    DamageResistences = table.Column<string>(nullable: true),
                    DamageVulnerabilities = table.Column<string>(nullable: true),
                    Dexterity = table.Column<int>(nullable: false),
                    HitDice = table.Column<string>(nullable: true),
                    HitPoints = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Languages = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Perception = table.Column<int>(nullable: false),
                    Senses = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Speed = table.Column<string>(nullable: true),
                    Strength = table.Column<int>(nullable: false),
                    SubType = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Wisdom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rarity = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonsterActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionId = table.Column<int>(nullable: false),
                    SpecialAbilityModelId = table.Column<int>(nullable: true),
                    MonsterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterActions", x => x.Id);
                    table.UniqueConstraint("AK_MonsterActions_MonsterId_ActionId", x => new { x.MonsterId, x.ActionId });
                    table.ForeignKey(
                        name: "FK_MonsterActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterActions_SpecialAbilities_SpecialAbilityModelId",
                        column: x => x.SpecialAbilityModelId,
                        principalTable: "SpecialAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterActions_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterSpecialAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionModelId = table.Column<int>(nullable: true),
                    MonsterId = table.Column<int>(nullable: false),
                    SpecialAbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterSpecialAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonsterSpecialAbilities_Actions_ActionModelId",
                        column: x => x.ActionModelId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterSpecialAbilities_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterSpecialAbilities_SpecialAbilities_SpecialAbilityId",
                        column: x => x.SpecialAbilityId,
                        principalTable: "SpecialAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterActions_ActionId",
                table: "MonsterActions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterActions_SpecialAbilityModelId",
                table: "MonsterActions",
                column: "SpecialAbilityModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSpecialAbilities_ActionModelId",
                table: "MonsterSpecialAbilities",
                column: "ActionModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSpecialAbilities_MonsterId",
                table: "MonsterSpecialAbilities",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSpecialAbilities_SpecialAbilityId",
                table: "MonsterSpecialAbilities",
                column: "SpecialAbilityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterActions");

            migrationBuilder.DropTable(
                name: "MonsterSpecialAbilities");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "SpecialAbilities");
        }
    }
}
