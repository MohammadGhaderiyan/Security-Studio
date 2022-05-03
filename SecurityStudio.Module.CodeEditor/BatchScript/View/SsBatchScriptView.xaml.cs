using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.BatchScript.ViewModel;

namespace SecurityStudio.Module.CodeEditor.BatchScript.View
{
    public partial class SsBatchScriptView : SsView
    {
        public SsBatchScriptView(SsBatchScriptViewModel ssBatchScriptViewModel)
            : base(ssBatchScriptViewModel)
        {
            InitializeComponent();
        }
    }
}