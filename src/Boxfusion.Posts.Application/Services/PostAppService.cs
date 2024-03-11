using Abp.Application.Services;
using Abp.Domain.Repositories;
using Boxfusion.Posts.Domain;
using Boxfusion.Posts.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.Posts.Services
{
    public class PostAppService : AsyncCrudAppService<Post, PostDto, long>, IPostAppService
    {
        //private readonly IRepository<Post, long> _repository;
        public PostAppService(IRepository<Post, long> repository) : base(repository)
        {
            //_repository = repository;
        }
    }
}
