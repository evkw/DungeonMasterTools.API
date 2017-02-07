using System.Collections.Generic;
using DungeonMasterToolsInfrastructure.Model;
using DungeonMasterToolsModels.Monster.Entities;

namespace DungeonMasterToolsModels.Actions.Entities
{
    public class ActionModel: EntityBase 
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int AttackBonus { get; set; }
        public string DamageDice { get; set; }
        public string DamageBonus { get; set; }
        public List<MonsterSpecialAbilities> MonsterSpecialAbilities { get; set; }
        public List<MonsterActions> MonsterActions { get; set; }
    }
}
