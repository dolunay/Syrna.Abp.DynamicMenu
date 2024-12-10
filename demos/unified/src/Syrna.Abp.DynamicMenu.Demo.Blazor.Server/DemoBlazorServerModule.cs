using Volo.Abp.Modularity;

namespace Syrna.Abp.DynamicMenu.Demo.Blazor.Server;

[DependsOn(
    typeof(DemoBlazorModule)
)]
public class DemoBlazorServerModule : AbpModule
{

}
