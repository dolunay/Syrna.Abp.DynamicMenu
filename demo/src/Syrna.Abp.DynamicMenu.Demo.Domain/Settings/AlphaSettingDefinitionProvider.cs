using Syrna.Abp.DynamicMenu.Demo.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace Syrna.Abp.DynamicMenu.Demo.Settings;

public class AlphaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AlphaSettings.MySetting1));

        //Gridin son filtre ayarlarını anımsa
        context.Add(new SettingDefinition(AlphaSettings.RememberGridFilterState, "false", L("DisplayName:Syrna.Abp.DynamicMenu.RememberGridFilterState"), L("Description:Syrna.Abp.DynamicMenu.RememberGridFilterState")));
    }
    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DemoResource>(name);
    }
}
