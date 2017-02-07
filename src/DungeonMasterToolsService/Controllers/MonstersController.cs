using System.Collections.Generic;
using DungeonMasterToolsDomain.Entities.Monsters;
using DungeonMasterToolsModels.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DungeonMasterTools.Controllers
{
    [Route("api/[controller]")]
    public class MonstersController : Controller
    {
        private readonly IMonsterDomainHandler monsterDomainHandler;

        public MonstersController(IMonsterDomainHandler monsterDomainHandler)
        {
            this.monsterDomainHandler = monsterDomainHandler;
        }

        
        [HttpPost]
        public string Post([FromBody] List<MonsterModel> monsters)
        {
            return this.monsterDomainHandler.BulkAddMonsters(monsters);
        }
    }
}
