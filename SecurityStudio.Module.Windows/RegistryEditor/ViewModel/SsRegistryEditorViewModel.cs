using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Windows.RegistryEditor.ViewModel
{
    public class SsRegistryEditorViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Registry Editor";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}