using YourDeal.Samples;
using Xunit;

namespace YourDeal.EntityFrameworkCore.Applications;

[Collection(YourDealTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<YourDealEntityFrameworkCoreTestModule>
{

}
