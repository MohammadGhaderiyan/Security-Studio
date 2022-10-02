using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.Php.ViewModel;

namespace SecurityStudio.Module.CodeEditor.Php.View
{
    public partial class SsPhpView : SsView
    {
        public SsPhpView(SsPhpViewModel ssPhpViewModel)
            : base(ssPhpViewModel)
        {
            InitializeComponent();
        }
    }
}