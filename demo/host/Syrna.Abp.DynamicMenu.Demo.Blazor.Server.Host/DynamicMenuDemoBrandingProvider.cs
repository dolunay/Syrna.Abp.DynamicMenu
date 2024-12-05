using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Syrna.Abp.DynamicMenu.Demo.Blazor.Server.Host
{
    [Dependency(ReplaceServices = true)]
    public class DynamicMenuDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DynamicMenu";
    }
}
