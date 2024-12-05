using Syrna.Abp.DynamicMenu.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.Abp.DynamicMenu
{
    public abstract class DynamicMenuAppService : ApplicationService
    {
        protected DynamicMenuAppService()
        {
            LocalizationResource = typeof(DynamicMenuResource);
            ObjectMapperContext = typeof(AbpDynamicMenuApplicationModule);
        }
    }
}
