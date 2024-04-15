using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace YourDeal.Data;

/* This is used if database provider does't define
 * IYourDealDbSchemaMigrator implementation.
 */
public class NullYourDealDbSchemaMigrator : IYourDealDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
