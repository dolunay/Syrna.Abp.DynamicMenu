using Volo.Abp.Modularity;

namespace Syrna.Abp.DynamicMenu
{
    [DependsOn(
        typeof(AbpDynamicMenuApplicationModule),
        typeof(DynamicMenuDomainTestModule)
        )]
    public class DynamicMenuApplicationTestModule : AbpModule
    {

    }
}
