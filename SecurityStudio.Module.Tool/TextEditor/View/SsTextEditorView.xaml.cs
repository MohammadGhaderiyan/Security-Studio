using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.TextEditor.ViewModel;

namespace SecurityStudio.Module.Tool.TextEditor.View
{
    public partial class SsTextEditorView : SsView
    {
        public SsTextEditorView(SsTextEditorViewModel ssTextEditorViewModel)
            : base(ssTextEditorViewModel)
        {
            InitializeComponent();
        }
    }
}