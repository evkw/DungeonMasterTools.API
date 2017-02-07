﻿using System.Collections.Generic;
using DungeonMasterToolsModels.Entities.Monster;

namespace DungeonMasterToolsModels.Entities
{
    public class EntitySpecialAbilityModel: EntityActionBase
    {
        public List<MonsterSpecialAbilities> MonsterSpecialAbilities { get; set; }
        public List<MonsterActions> MonsterActions { get; set; }
    }
}
