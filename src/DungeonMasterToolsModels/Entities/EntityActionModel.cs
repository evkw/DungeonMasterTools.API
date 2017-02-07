using System.Collections.Generic;
using DungeonMasterToolsModels.Entities.Monster;

namespace DungeonMasterToolsModels.Entities
{
    public class EntityActionModel: EntityActionBase
    {
        public string DamageDice { get; set; }
        public string DamageBonus { get; set; }
        public List<MonsterSpecialAbilities> MonsterSpecialAbilities { get; set; }
        public List<MonsterActions> MonsterActions { get; set; }
    }
}
