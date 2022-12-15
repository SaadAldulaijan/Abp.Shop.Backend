using Shop.Localization;
using Volo.Abp.Application.Services;

namespace Shop;

/* Inherit your application services from this class.
 */
public abstract class ShopAppService : ApplicationService
{
    protected ShopAppService()
    {
        LocalizationResource = typeof(ShopResource);
    }
}
