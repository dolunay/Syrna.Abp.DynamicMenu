using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Syrna.Abp.DynamicMenu.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(AbpDynamicMenuBlazorModule)
        )]
    public class AbpDynamicMenuBlazorServerModule : AbpModule
    {
        
    }
}