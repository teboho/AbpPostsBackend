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
    public class Post : Entity<long>
    {
        public Post()
        {
            DateCreated = DateTime.Now;
        }

        public string Content { get; set; }
        public DateTime DateCreated { get; set; }


        /// <summary>
        /// If it is null then it is an Original not a reply
        /// Self-referential foreign key, for when a post is actually a reply an not original
        /// </summary>
        public long OriginalId { get; set; }
        //[ForeignKey(nameof(OriginalId))]
        //public Post PostModel { get; set; }

        /// <summary>
        /// UserId is a foreign key to the users table...
        /// </summary>
        public long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User UserModel { get; set; }
    }
}
