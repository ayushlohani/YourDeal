using YourDeal.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace YourDeal.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(YourDealEntityFrameworkCoreModule),
    typeof(YourDealApplicationContractsModule)
    )]
public class YourDealDbMigratorModule : AbpModule
{
}
