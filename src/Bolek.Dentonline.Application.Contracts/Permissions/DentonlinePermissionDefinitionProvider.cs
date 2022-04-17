using Bolek.Dentonline.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Bolek.Dentonline.Permissions;

public class DentonlinePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DentonlinePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(EmployeePermissions.Employees.Default, L("Permission:Employees"));
        booksPermission.AddChild(EmployeePermissions.Employees.Create, L("Permission:Employees.Create"));
        booksPermission.AddChild(EmployeePermissions.Employees.Edit, L("Permission:Employees.Edit"));
        booksPermission.AddChild(EmployeePermissions.Employees.Delete, L("Permission:Employees.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DentonlineResource>(name);
    }
}
