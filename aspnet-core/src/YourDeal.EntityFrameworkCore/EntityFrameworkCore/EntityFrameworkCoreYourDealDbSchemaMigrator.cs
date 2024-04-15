using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YourDeal.Data;
using Volo.Abp.DependencyInjection;

namespace YourDeal.EntityFrameworkCore;

public class EntityFrameworkCoreYourDealDbSchemaMigrator
    : IYourDealDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreYourDealDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the YourDealDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<YourDealDbContext>()
            .Database
            .MigrateAsync();
    }
}
