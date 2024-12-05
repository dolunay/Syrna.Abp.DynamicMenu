using Syrna.Abp.DynamicMenu.Demo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.Abp.DynamicMenu.Demo.SettingManagement;

public abstract class SettingManagementAppServiceBase : ApplicationService
{
    protected SettingManagementAppServiceBase()
    {
        ObjectMapperContext = typeof(DemoApplicationModule);
        LocalizationResource = typeof(DemoResource);
    }
}
