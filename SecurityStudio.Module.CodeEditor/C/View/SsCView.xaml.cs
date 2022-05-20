using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.C.ViewModel;

namespace SecurityStudio.Module.CodeEditor.C.View
{
    public partial class SsCView : SsView
    {
        public SsCView(SsCViewModel ssCViewModel)
            : base(ssCViewModel)
        {
            InitializeComponent();
        }
    }
}