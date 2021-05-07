using Abp.Authorization;
using ABPV5.Authorization.Roles;
using ABPV5.Authorization.Users;

namespace ABPV5.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
