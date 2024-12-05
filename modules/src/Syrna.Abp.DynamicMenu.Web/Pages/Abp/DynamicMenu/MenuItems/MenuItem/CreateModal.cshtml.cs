using System.Threading.Tasks;
using Syrna.Abp.DynamicMenu.MenuItems;
using Syrna.Abp.DynamicMenu.MenuItems.Dtos;
using Syrna.Abp.DynamicMenu.Web.Pages.Abp.DynamicMenu.MenuItems.MenuItem.ViewModels;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;

namespace Syrna.Abp.DynamicMenu.Web.Pages.Abp.DynamicMenu.MenuItems.MenuItem
{
    public class CreateModalModel : DynamicMenuPageModel
    {
        [BindProperty]
        public CreateMenuItemViewModel ViewModel { get; set; } = new();

        private readonly IMenuItemAppService _service;

        public CreateModalModel(IMenuItemAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync([CanBeNull] string parentId)
        {
            ViewModel.ParentId = parentId;
            ViewModel.LResourceTypeName = DynamicMenuConsts.DefaultLResourceTypeName;
            ViewModel.LResourceTypeAssemblyName = DynamicMenuConsts.DefaultLResourceTypeAssemblyName;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateMenuItemViewModel, CreateMenuItemDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}