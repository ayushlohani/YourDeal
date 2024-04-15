using Volo.Abp.Modularity;

namespace YourDeal;

/* Inherit from this class for your domain layer tests. */
public abstract class YourDealDomainTestBase<TStartupModule> : YourDealTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
