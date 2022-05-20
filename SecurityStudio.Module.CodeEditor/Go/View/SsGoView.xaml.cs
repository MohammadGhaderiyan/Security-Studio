using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.Go.ViewModel;

namespace SecurityStudio.Module.CodeEditor.Go.View
{
    public partial class SsGoView : SsView
    {
        public SsGoView(SsGoViewModel ssGoViewModel)
            : base(ssGoViewModel)
        {
            InitializeComponent();
        }
    }
}