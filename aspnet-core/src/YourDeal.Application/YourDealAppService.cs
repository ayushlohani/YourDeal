using System;
using System.Collections.Generic;
using System.Text;
using YourDeal.Localization;
using Volo.Abp.Application.Services;
namespace YourDeal;

/* Inherit your application services from this class.
 */
public abstract class YourDealAppService : ApplicationService
{
    protected YourDealAppService()
    {
        
        LocalizationResource = typeof(YourDealResource);
    }
}
