using Volo.Abp.Modularity;

namespace Syrna.Abp.DynamicMenu.Demo.Blazor.WebAssembly;

[DependsOn(
    typeof(DemoBlazorModule)
)]
public class DemoBlazorWebAssemblyModule : AbpModule
{
}
