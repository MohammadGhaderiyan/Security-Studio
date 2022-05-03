using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.CSharp.ViewModel;

namespace SecurityStudio.Module.CodeEditor.CSharp.View
{
    public partial class SsCSharpView : SsView
    {
        public SsCSharpView(SsCSharpViewModel ssCSharpViewModel)
            : base(ssCSharpViewModel)
        {
            InitializeComponent();
        }
    }
}