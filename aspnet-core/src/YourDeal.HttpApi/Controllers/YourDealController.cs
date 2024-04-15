using YourDeal.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace YourDeal.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class YourDealController : AbpControllerBase
{
    protected YourDealController()
    {
        LocalizationResource = typeof(YourDealResource);
    }
}
