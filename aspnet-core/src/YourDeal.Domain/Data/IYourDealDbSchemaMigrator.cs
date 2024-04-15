using System.Threading.Tasks;

namespace YourDeal.Data;

public interface IYourDealDbSchemaMigrator
{
    Task MigrateAsync();
}
