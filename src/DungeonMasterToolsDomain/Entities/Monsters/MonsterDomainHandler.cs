using System;
using System.Collections.Generic;
using AutoMapper;
using DungeonMasterToolsModels.Entities.Monster;
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

        public string BulkAddMonsters(List<AddMonsterDto> addMonsterDtos)
        {

            foreach(var addMonsterDto in addMonsterDtos)
            {
                var monster = Mapper.Map<MonsterModel>(addMonsterDto);
            }

            context.SaveChanges();
            context.SaveChanges();
            Console.WriteLine("this works");
            return "woop";
        }
    }
}
