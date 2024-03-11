using Abp.Application.Services;
using Boxfusion.Posts.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.Posts.Services
{
    public interface IPostAppService : IAsyncCrudAppService<PostDto, long>
    {
    }
}
