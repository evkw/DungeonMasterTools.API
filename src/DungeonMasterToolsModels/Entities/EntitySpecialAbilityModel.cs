using System.Collections.Generic;

namespace DungeonMasterTools.Models.Entities
{
    public class EntitySpecialAbilityModel: EntityActionBase
    {
        public List<MonsterSpecialAbilities> MonsterSpecialAbilities { get; set; }
        public List<MonsterActions> MonsterActions { get; set; }
    }
}
