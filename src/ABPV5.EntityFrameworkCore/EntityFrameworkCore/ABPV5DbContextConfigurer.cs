using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPV5.EntityFrameworkCore
{
    public static class ABPV5DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPV5DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPV5DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
