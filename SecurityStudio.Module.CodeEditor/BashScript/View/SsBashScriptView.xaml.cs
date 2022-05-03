using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.BashScript.ViewModel;

namespace SecurityStudio.Module.CodeEditor.BashScript.View
{
    public partial class SsBashScriptView : SsView
    {
        public SsBashScriptView(SsBashScriptViewModel ssBashScriptViewModel)
            : base(ssBashScriptViewModel)
        {
            InitializeComponent();
        }
    }
}