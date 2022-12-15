using Shop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Shop.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ShopController : AbpControllerBase
{
    protected ShopController()
    {
        LocalizationResource = typeof(ShopResource);
    }
}
