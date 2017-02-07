using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DungeonMasterToolsRepository
{
    public class RepoStartup
    {
        public static void Main(string[] args)
        {

        }
    }

    public class RepoStartupFactory: IDbContextFactory<DungeonMasterToolsDbContext>
    {
        public DungeonMasterToolsDbContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DungeonMasterToolsDbContext>();
            optionsBuilder.UseSqlServer("Server =.; Database = DungeonMasterTools; Trusted_Connection = True; ");
            return new DungeonMasterToolsDbContext(optionsBuilder.Options);

        }
    }
}
