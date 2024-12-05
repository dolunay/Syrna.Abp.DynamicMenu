using System;
using System.Threading.Tasks;
using Syrna.Abp.DynamicMenu.MenuItems.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using static Syrna.Abp.DynamicMenu.Permissions.DynamicMenuPermissions;

namespace Syrna.Abp.DynamicMenu.MenuItems
{
    public interface IMenuItemAppService :
        ICrudAppService<
            MenuItemDto,
            MenuItemDto,
            string,
            GetMenuItemListInput,
            CreateMenuItemDto,
            UpdateMenuItemDto>
    {
    }
}