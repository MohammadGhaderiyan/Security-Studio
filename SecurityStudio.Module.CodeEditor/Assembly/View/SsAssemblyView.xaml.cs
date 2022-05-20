using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.Assembly.ViewModel;

namespace SecurityStudio.Module.CodeEditor.Assembly.View
{
    public partial class SsAssemblyView : SsView
    {
        public SsAssemblyView(SsAssemblyViewModel ssAssemblyViewModel)
            : base(ssAssemblyViewModel)
        {
            InitializeComponent();
        }
    }
}