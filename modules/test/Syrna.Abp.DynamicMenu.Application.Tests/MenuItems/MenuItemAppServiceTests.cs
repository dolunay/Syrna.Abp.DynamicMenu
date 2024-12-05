using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Syrna.Abp.DynamicMenu.MenuItems
{
    public class MenuItemAppServiceTests : DynamicMenuApplicationTestBase
    {
        private readonly IMenuItemAppService _menuItemAppService;

        public MenuItemAppServiceTests()
        {
            _menuItemAppService = GetRequiredService<IMenuItemAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
