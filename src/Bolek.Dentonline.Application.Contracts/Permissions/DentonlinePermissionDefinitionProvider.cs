using Bolek.Dentonline.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Bolek.Dentonline.Permissions;

public class DentonlinePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DentonlinePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DentonlinePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DentonlineResource>(name);
    }
}
