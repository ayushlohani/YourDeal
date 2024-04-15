using Volo.Abp.Modularity;

namespace YourDeal;

[DependsOn(
    typeof(YourDealApplicationModule),
    typeof(YourDealDomainTestModule)
)]
public class YourDealApplicationTestModule : AbpModule
{

}
