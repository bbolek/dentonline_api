using Volo.Abp.Settings;

namespace Bolek.Dentonline.Settings;

public class DentonlineSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DentonlineSettings.MySetting1));
    }
}
