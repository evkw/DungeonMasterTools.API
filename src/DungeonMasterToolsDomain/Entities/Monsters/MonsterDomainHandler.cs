using System;
using System.Collections.Generic;
using DungeonMasterToolsModels.Entities;
using DungeonMasterToolsRepository;

namespace DungeonMasterToolsDomain.Entities.Monsters
{
    public class MonsterDomainHandler: IMonsterDomainHandler
    {
        private readonly DungeonMasterToolsDbContext context;

        public MonsterDomainHandler(DungeonMasterToolsDbContext context)
        {
            this.context = context;
        }

        public string BulkAddMonsters(List<MonsterModel> monsters)
        {
            Console.WriteLine("this works");
            return "woop";
        }
    }
}
