using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPV5.Authorization.Roles;
using ABPV5.Authorization.Users;
using ABPV5.MultiTenancy;

namespace ABPV5.EntityFrameworkCore
{
    public class ABPV5DbContext : AbpZeroDbContext<Tenant, Role, User, ABPV5DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPV5DbContext(DbContextOptions<ABPV5DbContext> options)
            : base(options)
        {
        }
    }
}
