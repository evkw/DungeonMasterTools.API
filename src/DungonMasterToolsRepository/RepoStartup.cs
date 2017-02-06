using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace DungonMasterToolsRepository
{
    public class RepoStartup
    {
        public static void Main(string[] args)
        {

        }
    }

    public class RepoStartupFactory: IDbContextFactory<DungonMasterToolsDbContext>
    {
        private IConfigurationRoot Configuration { get; }

        public RepoStartupFactory()
        {
        }

        public DungonMasterToolsDbContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DungonMasterToolsDbContext>();
            optionsBuilder.UseSqlServer("Server =.; Database = DungonMasterTools; Trusted_Connection = True; ");
            return new DungonMasterToolsDbContext(optionsBuilder.Options);

        }
    }
}
