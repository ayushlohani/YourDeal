using Volo.Abp.Modularity;

namespace YourDeal;

[DependsOn(
    typeof(YourDealDomainModule),
    typeof(YourDealTestBaseModule)
)]
public class YourDealDomainTestModule : AbpModule
{

}
