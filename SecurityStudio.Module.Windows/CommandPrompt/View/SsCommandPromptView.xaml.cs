using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.CommandPrompt.ViewModel;

namespace SecurityStudio.Module.Windows.CommandPrompt.View
{
    public partial class SsCommandPromptView : SsView
    {
        public SsCommandPromptView(SsCommandPromptViewModel ssCommandPromptViewModel)
            : base(ssCommandPromptViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            ((SsCommandPromptViewModel)SsViewModel).ConsoleControl = ConsoleControlMain;
        }
    }
}