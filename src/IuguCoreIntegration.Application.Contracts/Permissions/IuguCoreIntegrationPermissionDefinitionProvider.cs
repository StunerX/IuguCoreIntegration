using IuguCoreIntegration.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IuguCoreIntegration.Permissions
{
    public class IuguCoreIntegrationPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(IuguCoreIntegrationPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(IuguCoreIntegrationPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<IuguCoreIntegrationResource>(name);
        }
    }
}
