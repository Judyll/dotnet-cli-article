using System;
using Xunit;
using Alba;
using System.Threading.Tasks;

namespace HeyWorld.Tests
{
    public class verify_the_endpoints
    {
        [Fact]
        public async Task check_it_out()
        {
            using (var system = SystemUnderTest.ForStartup<Startup>())
            {
                await system.Scenario(s => {
                    s.Get.Url("/");
                    s.ContentShouldBe("Hey, World.");
                    s.ContentTypeShouldBe("text/plain; charset=utf-8");
                });
            }
        }
    }
}
