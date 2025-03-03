using Volo.Abp.Settings;

namespace TestSeedProject.Settings;

public class TestSeedProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TestSeedProjectSettings.MySetting1));
    }
}
