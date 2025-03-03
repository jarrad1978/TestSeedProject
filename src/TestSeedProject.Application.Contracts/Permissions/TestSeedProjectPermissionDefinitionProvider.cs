using TestSeedProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace TestSeedProject.Permissions;

public class TestSeedProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestSeedProjectPermissions.GroupName);

        myGroup.AddPermission(TestSeedProjectPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(TestSeedProjectPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        var booksPermission = myGroup.AddPermission(TestSeedProjectPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(TestSeedProjectPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(TestSeedProjectPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(TestSeedProjectPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestSeedProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestSeedProjectResource>(name);
    }
}
