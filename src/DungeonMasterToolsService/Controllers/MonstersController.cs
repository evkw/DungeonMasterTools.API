using System.Collections.Generic;
using DungeonMasterToolsModels.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DungeonMasterTools.Controllers
{
    [Route("api/[controller]")]
    public class MonstersController : Controller
    {
        [HttpPost]
        public string Post([FromBody] List<MonsterModel> monsters)
        {
            var blah = monsters;
            return "good job";
        }
    }
}
