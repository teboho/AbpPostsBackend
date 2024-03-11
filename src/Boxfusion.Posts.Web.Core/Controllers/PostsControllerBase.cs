using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Boxfusion.Posts.Controllers
{
    public abstract class PostsControllerBase: AbpController
    {
        protected PostsControllerBase()
        {
            LocalizationSourceName = PostsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
