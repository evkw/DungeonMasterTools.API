using System.Collections.Generic;

namespace DungeonMasterToolsModels.Entities.Monster
{
    public class AddMonsterDto: MonsterBase
    {
        public List<EntityActionModel> Actions { get; set; }
        public List<EntitySpecialAbilityModel> SpecialAbilities { get; set; }
    }
}
