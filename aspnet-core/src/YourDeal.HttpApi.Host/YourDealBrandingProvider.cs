using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace YourDeal;

[Dependency(ReplaceServices = true)]
public class YourDealBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "YourDeal";
}
