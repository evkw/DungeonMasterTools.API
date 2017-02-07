using System.Collections.Generic;
using DungeonMasterToolsInfrastructure.Model;
using DungeonMasterToolsModels.Monster.Entities;

namespace DungeonMasterToolsModels.SpecialAbility.Entities
{
    /// <summary>
    /// Database model for a special ability
    /// </summary>
    public class SpecialAbilityModel: EntityBase
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int AttackBonus { get; set; }
        public List<MonsterSpecialAbilities> MonsterSpecialAbilities { get; set; }
        public List<MonsterActions> MonsterActions { get; set; }
    }
}
