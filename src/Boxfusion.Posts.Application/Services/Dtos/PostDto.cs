using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Boxfusion.Posts.Authorization.Users;
using Boxfusion.Posts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.Posts.Services.Dtos
{
    [AutoMap(typeof(Post))]
    public class PostDto : EntityDto<long>
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string Content { get; set; }
        public long UserId { get; set; }
        public long OriginalId { get; set; }
    }
}
