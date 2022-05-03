using SecurityStudio.Base.Main.Ioc;
using SecurityStudio.Database.Model.Validation.Mitre;

namespace SecurityStudio.Database.Model.Validation
{
    public class SsModelValidationModule : SsModule
    {
        public override void Load()
        {
            Bind<SsSubTechniqueAbstractValidator>().ToSelf();
            Bind<SsTacticAbstractValidator>().ToSelf();
            Bind<SsTechniqueAbstractValidator>().ToSelf();
        }
    }
}