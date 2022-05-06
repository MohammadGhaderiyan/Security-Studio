using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.TextEditor.ViewModel
{
    public class SsTextEditorViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Text Editor";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}