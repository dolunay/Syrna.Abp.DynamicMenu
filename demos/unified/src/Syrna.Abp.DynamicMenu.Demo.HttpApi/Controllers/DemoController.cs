using Syrna.Abp.DynamicMenu.Demo.Localization;
using Syrna.Abp.DynamicMenu.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.Abp.DynamicMenu.Demo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DemoController : AbpControllerBase
{
    protected DemoController()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
