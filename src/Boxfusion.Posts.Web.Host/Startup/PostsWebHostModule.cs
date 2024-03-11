using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Boxfusion.Posts.Configuration;

namespace Boxfusion.Posts.Web.Host.Startup
{
    [DependsOn(
       typeof(PostsWebCoreModule))]
    public class PostsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PostsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PostsWebHostModule).GetAssembly());
        }
    }
}
