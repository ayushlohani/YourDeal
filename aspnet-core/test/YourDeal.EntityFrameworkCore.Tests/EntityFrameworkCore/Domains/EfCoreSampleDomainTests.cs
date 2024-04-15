using YourDeal.Samples;
using Xunit;

namespace YourDeal.EntityFrameworkCore.Domains;

[Collection(YourDealTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<YourDealEntityFrameworkCoreTestModule>
{

}
