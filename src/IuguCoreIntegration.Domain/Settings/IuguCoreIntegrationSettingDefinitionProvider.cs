using Volo.Abp.Settings;

namespace IuguCoreIntegration.Settings
{
    public class IuguCoreIntegrationSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(IuguCoreIntegrationSettings.MySetting1));
        }
    }
}
