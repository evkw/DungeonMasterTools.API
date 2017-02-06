using System.Collections.Generic;

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
