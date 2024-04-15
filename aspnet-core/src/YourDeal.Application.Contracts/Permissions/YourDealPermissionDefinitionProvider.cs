using YourDeal.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace YourDeal.Permissions;

public class YourDealPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(YourDealPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(YourDealPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<YourDealResource>(name);
    }
}
