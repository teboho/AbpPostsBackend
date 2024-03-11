using System.Threading.Tasks;
using Boxfusion.Posts.Configuration.Dto;

namespace Boxfusion.Posts.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
