using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.CPlusPlus.ViewModel;

namespace SecurityStudio.Module.CodeEditor.CPlusPlus.View
{
    public partial class SsCPlusPlusView : SsView
    {
        public SsCPlusPlusView(SsCPlusPlusViewModel ssCPlusPlusViewModel)
            : base(ssCPlusPlusViewModel)
        {
            InitializeComponent();
        }
    }
}