using Abp.Authorization;
using Boxfusion.Posts.Authorization.Roles;
using Boxfusion.Posts.Authorization.Users;

namespace Boxfusion.Posts.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
