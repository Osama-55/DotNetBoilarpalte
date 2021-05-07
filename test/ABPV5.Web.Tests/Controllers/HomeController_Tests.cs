using System.Threading.Tasks;
using ABPV5.Models.TokenAuth;
using ABPV5.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABPV5.Web.Tests.Controllers
{
    public class HomeController_Tests: ABPV5WebTestBase
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