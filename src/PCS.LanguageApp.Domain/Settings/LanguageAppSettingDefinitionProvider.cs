using Volo.Abp.Settings;

namespace PCS.LanguageApp.Settings;

public class LanguageAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LanguageAppSettings.MySetting1));
    }
}
