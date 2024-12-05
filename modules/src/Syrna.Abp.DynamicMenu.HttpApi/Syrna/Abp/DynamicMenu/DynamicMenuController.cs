using Syrna.Abp.DynamicMenu.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.Abp.DynamicMenu
{
    [Area(AbpDynamicMenuRemoteServiceConsts.ModuleName)]
    public abstract class DynamicMenuController : AbpControllerBase
    {
        protected DynamicMenuController()
        {
            LocalizationResource = typeof(DynamicMenuResource);
        }
    }
}
