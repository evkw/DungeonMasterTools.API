using Microsoft.EntityFrameworkCore;
using DungeonMasterTools.Models;

namespace DungonMasterToolsRepository
{
    public class DungonMasterToolsDbContext: DbContext
    {
        public DungonMasterToolsDbContext(DbContextOptions<DungonMasterToolsDbContext> options)
            : base(options)
        {

        }
        public DbSet<ItemModel> Items { get; set; }
    }
}
