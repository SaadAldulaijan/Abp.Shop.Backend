using Volo.Abp.Modularity;

namespace Shop;

[DependsOn(
    typeof(ShopApplicationModule),
    typeof(ShopDomainTestModule)
    )]
public class ShopApplicationTestModule : AbpModule
{

}
