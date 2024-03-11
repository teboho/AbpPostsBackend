using System.Threading.Tasks;
using Abp.Application.Services;
using Boxfusion.Posts.Sessions.Dto;

namespace Boxfusion.Posts.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
