using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.CodeEditor.Java.ViewModel;

namespace SecurityStudio.Module.CodeEditor.Java.View
{
    public partial class SsJavaView : SsView
    {
        public SsJavaView(SsJavaViewModel ssJavaViewModel)
            : base(ssJavaViewModel)
        {
            InitializeComponent();
        }
    }
}