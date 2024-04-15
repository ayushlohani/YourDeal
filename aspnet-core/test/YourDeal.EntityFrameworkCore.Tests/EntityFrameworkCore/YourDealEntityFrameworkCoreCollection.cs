using Xunit;

namespace YourDeal.EntityFrameworkCore;

[CollectionDefinition(YourDealTestConsts.CollectionDefinitionName)]
public class YourDealEntityFrameworkCoreCollection : ICollectionFixture<YourDealEntityFrameworkCoreFixture>
{

}
