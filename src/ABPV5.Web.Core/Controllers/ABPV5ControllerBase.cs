using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPV5.Controllers
{
    public abstract class ABPV5ControllerBase: AbpController
    {
        protected ABPV5ControllerBase()
        {
            LocalizationSourceName = ABPV5Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
