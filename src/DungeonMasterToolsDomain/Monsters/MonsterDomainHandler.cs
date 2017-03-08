using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DungeonMasterToolsDomain.SpecialAbility;
using DungeonMasterToolsModels.Actions.Entities;
using DungeonMasterToolsModels.Monster.DTOs;
using DungeonMasterToolsModels.Monster.Entities;
using DungeonMasterToolsModels.SpecialAbility.Entities;
using DungeonMasterToolsRepository;

namespace DungeonMasterToolsDomain.Monsters
{
    public class MonsterDomainHandler: IMonsterDomainHandler
    {
        private readonly DungeonMasterToolsDbContext context;
        private readonly SpecialAbilityDomainHandler specialAbilityHandler;

        public MonsterDomainHandler(DungeonMasterToolsDbContext context, SpecialAbilityDomainHandler specialAbilityHandler)
        {
            this.context = context;
            this.specialAbilityHandler = specialAbilityHandler;
        }

        public string BulkAddMonsters(List<AddMonsterDto> addMonsterDtos)
        {
            var monsterCount = context.Monsters.Count();
            foreach(var addMonsterDto in addMonsterDtos)
            {
                var monster = Mapper.Map<MonsterModel>(addMonsterDto);
                monster.Id = monsterCount + 1;
                this.AddActionsForMonster(monster, addMonsterDto.Actions);
                this.AddSpecialAbilitiesForMonster(monster, addMonsterDto.SpecialAbilities);
                monsterCount++;
            }

            context.SaveChanges();
            return "woop";
        }

        private void AddSpecialAbilitiesForMonster(MonsterModel monster, List<SpecialAbilityModel> specialAbilities)
        {
            foreach(var sa in specialAbilities)
            {
                var spcAbl = specialAbilityHandler.AddSpecialAbility(sa);
                context.MonsterSpecialAbilities.Add(new MonsterSpecialAbilities(monster, spcAbl));
            }
        }

        public void AddActionsForMonster(MonsterModel monster, List<ActionModel> actions)
        {
            foreach(var a in actions)
            {
               // var lookup = 
            }
        }
    }
}
