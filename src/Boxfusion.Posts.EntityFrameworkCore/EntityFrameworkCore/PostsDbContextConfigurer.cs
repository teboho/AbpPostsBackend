using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Boxfusion.Posts.EntityFrameworkCore
{
    public static class PostsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PostsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PostsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
