using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Boxfusion.Posts.Authorization;

namespace Boxfusion.Posts
{
    [DependsOn(
        typeof(PostsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PostsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PostsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PostsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
