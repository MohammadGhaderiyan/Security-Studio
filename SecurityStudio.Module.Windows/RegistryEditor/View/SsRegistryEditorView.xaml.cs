using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.RegistryEditor.ViewModel;

namespace SecurityStudio.Module.Windows.RegistryEditor.View
{
    public partial class SsRegistryEditorView : SsView
    {
        public SsRegistryEditorView(SsRegistryEditorViewModel ssRegistryEditorViewModel)
            : base(ssRegistryEditorViewModel)
        {
            InitializeComponent();
        }
    }
}