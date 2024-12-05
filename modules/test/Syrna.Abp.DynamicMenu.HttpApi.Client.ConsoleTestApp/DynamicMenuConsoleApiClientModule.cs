using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Syrna.Abp.DynamicMenu
{
    [DependsOn(
        typeof(AbpDynamicMenuHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DynamicMenuConsoleApiClientModule : AbpModule
    {
        
    }
}
