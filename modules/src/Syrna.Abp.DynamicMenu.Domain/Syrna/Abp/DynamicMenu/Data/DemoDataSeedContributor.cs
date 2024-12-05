using System.Collections.Generic;
using System.Threading.Tasks;
using Syrna.Abp.DynamicMenu.MenuItems;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Uow;

namespace Syrna.Abp.DynamicMenu.Data
{
    public class DemoDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public DemoDataSeedContributor(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        [UnitOfWork]
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _menuItemRepository.FindAsync(x => x.Id == "ShortcutMenu") != null)
            {
                return;
            }

            var demoMenu = new MenuItem(null, false, "ShortcutMenu", "Shortcut menu", null, null, null, null, null,
                200, "fas fa-compass", null, false, false, DynamicMenuConsts.DefaultLResourceTypeName,
                DynamicMenuConsts.DefaultLResourceTypeAssemblyName, new List<MenuItem>
                {
                    new( "ShortcutMenu", false, "ChangePassword", "Change password", "~/Account/Manage", null, null, null,
                        null, null, "fas fa-compass", null,false, false, DynamicMenuConsts.DefaultLResourceTypeName,
                        DynamicMenuConsts.DefaultLResourceTypeAssemblyName, null)
                });

            await _menuItemRepository.InsertAsync(demoMenu, true);

            var demoMenu2 = new MenuItem(null, true, "ShortcutMenu2", "Shortcut menu 2", null, null, null, null, null,
                100000, null, null, false, false, DynamicMenuConsts.DefaultLResourceTypeName,
                DynamicMenuConsts.DefaultLResourceTypeAssemblyName, new List<MenuItem>
                {
                    new("ShortcutMenu2", false, "Syrna", "Syrna", "https://syrna.net", null, null, null, null,
                        null, null, "_blank",true, false, DynamicMenuConsts.DefaultLResourceTypeName,
                        DynamicMenuConsts.DefaultLResourceTypeAssemblyName, null),
                    new("ShortcutMenu2", true, "Google", "Google", "https://google.com", null, null, null, null,
                        null, null, "_blank",false, false, DynamicMenuConsts.DefaultLResourceTypeName,
                        DynamicMenuConsts.DefaultLResourceTypeAssemblyName, null),
                    new( "ShortcutMenu2", false, "Github", "Github", "https://github.com", null, null, null, null,
                        null, null, null,false, true, DynamicMenuConsts.DefaultLResourceTypeName,
                        DynamicMenuConsts.DefaultLResourceTypeAssemblyName, null),
                });

            await _menuItemRepository.InsertAsync(demoMenu2, true);
        }
    }
}