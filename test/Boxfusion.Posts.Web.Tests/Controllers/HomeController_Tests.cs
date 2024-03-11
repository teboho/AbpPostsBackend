using System.Threading.Tasks;
using Boxfusion.Posts.Models.TokenAuth;
using Boxfusion.Posts.Web.Controllers;
using Shouldly;
using Xunit;

namespace Boxfusion.Posts.Web.Tests.Controllers
{
    public class HomeController_Tests: PostsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}