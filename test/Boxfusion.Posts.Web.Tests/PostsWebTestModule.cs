using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Boxfusion.Posts.EntityFrameworkCore;
using Boxfusion.Posts.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Boxfusion.Posts.Web.Tests
{
    [DependsOn(
        typeof(PostsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PostsWebTestModule : AbpModule
    {
        public PostsWebTestModule(PostsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PostsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PostsWebMvcModule).Assembly);
        }
    }
}