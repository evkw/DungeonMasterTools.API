using System.Collections.Generic;

namespace DungeonMasterToolsModels.Entities
{
    public class EntitySpecialAbilityModel: EntityActionBase
    {
        public List<MonsterSpecialAbilities> MonsterSpecialAbilities { get; set; }
        public List<MonsterActions> MonsterActions { get; set; }
    }
}
