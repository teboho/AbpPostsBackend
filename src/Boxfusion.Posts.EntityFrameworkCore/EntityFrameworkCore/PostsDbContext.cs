using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Boxfusion.Posts.Authorization.Roles;
using Boxfusion.Posts.Authorization.Users;
using Boxfusion.Posts.MultiTenancy;
using Boxfusion.Posts.Domain;

namespace Boxfusion.Posts.EntityFrameworkCore
{
    public class PostsDbContext : AbpZeroDbContext<Tenant, Role, User, PostsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Like> Likes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public PostsDbContext(DbContextOptions<PostsDbContext> options)
            : base(options)
        {
            //options.
        }
    }
}
