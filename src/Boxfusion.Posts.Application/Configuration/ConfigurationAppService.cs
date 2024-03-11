using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Boxfusion.Posts.Configuration.Dto;

namespace Boxfusion.Posts.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PostsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
