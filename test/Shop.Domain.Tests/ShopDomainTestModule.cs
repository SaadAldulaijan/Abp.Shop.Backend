using Shop.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Shop;

[DependsOn(
    typeof(ShopEntityFrameworkCoreTestModule)
    )]
public class ShopDomainTestModule : AbpModule
{

}
