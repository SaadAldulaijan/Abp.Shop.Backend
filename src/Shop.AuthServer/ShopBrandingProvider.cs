using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Shop;

[Dependency(ReplaceServices = true)]
public class ShopBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Shop";
}
