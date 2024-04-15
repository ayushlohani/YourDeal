using Volo.Abp.Settings;

namespace YourDeal.Settings;

public class YourDealSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(YourDealSettings.MySetting1));
    }
}
