using System.Collections.Generic;

namespace DungeonMasterToolsModels.Entities.Monster
{
    public class MonsterModel: MonsterBase
    {
        public List<MonsterSpecialAbilities> MonsterSpecialAbilities { get; set; }
        public List<MonsterActions> MonsterActions { get; set; }
    }
}
