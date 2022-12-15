using Volo.Abp.Settings;

namespace Shop.Settings;

public class ShopSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ShopSettings.MySetting1));
    }
}
