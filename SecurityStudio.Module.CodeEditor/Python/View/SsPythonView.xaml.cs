using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.Python.ViewModel;

namespace SecurityStudio.Module.CodeEditor.Python.View
{
    public partial class SsPythonView : SsView
    {
        public SsPythonView(SsPythonViewModel ssPythonViewModel)
            : base(ssPythonViewModel)
        {
            InitializeComponent();
        }
    }
}