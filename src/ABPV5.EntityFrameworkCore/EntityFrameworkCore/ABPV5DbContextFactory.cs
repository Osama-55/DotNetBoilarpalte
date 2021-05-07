using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPV5.Configuration;
using ABPV5.Web;

namespace ABPV5.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPV5DbContextFactory : IDesignTimeDbContextFactory<ABPV5DbContext>
    {
        public ABPV5DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPV5DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPV5DbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPV5Consts.ConnectionStringName));

            return new ABPV5DbContext(builder.Options);
        }
    }
}
