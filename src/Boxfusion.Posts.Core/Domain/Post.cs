using Abp.Authorization.Users;
using Abp.Domain.Entities;
using Boxfusion.Posts.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.Posts.Domain
{
    //public class Post : Entity<long>
    //{

    //    public DateTime DateCreated { get; set; }

    //    public string Content { get; set; }

    //    /// <summary>
    //    /// If it is null then it is an Original not a reply
    //    /// </summary>
    //    public Post Original { get; set; }

    //    public Post() 
    //    {
    //        DateCreated = DateTime.Now;
    //    }

    //    public long UserId { get; set; }
    //    [ForeignKey("UserId")]
    //    public AbpUser<User> User { get; set; }
    //}
}
