using DungeonMasterToolsModels.SpecialAbility.Entities;

namespace DungeonMasterToolsModels.Monster.Entities
{
    /// <summary>
    /// Database model for mapping *:* relationship between monsters and special abilities
    /// </summary>
    public class MonsterSpecialAbilities
    {
        public int Id { get; set; }
        public int MonsterId { get; set; }
        public MonsterModel Monster { get; set; }

        public int SpecialAbilityId { get; set; }
        public SpecialAbilityModel SpecialAbility { get; set; }

        public MonsterSpecialAbilities(MonsterModel monster, SpecialAbilityModel specialAbility)
        {
            this.MonsterId = monster.Id;
            this.Monster = monster;
            this.SpecialAbilityId = specialAbility.Id;
            this.SpecialAbility = specialAbility;
        }
    }
}
