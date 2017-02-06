using System.Collections.Generic;
using System.Linq;
using DungeonMasterToolsModels.Items;
using DungeonMasterToolsRepository;
using Microsoft.AspNetCore.Mvc;

namespace DungeonMasterTools.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        private readonly DungeonMasterToolsDbContext context;

        public ItemsController(DungeonMasterToolsDbContext context)
        {
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<ItemModel> Get()
        {
            return context.Items;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ItemModel Get(int id)
        {
            return context.Items.FirstOrDefault(item => item.Id == id);
        }
    }
}
