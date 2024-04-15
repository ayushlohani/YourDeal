using Volo.Abp.Modularity;

namespace YourDeal;

public abstract class YourDealApplicationTestBase<TStartupModule> : YourDealTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
