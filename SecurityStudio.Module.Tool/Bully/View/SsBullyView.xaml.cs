using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Bully.ViewModel;

namespace SecurityStudio.Module.Tool.Bully.View
{
    public partial class SsBullyView : SsView
    {
        public SsBullyView(SsBullyViewModel ssBullyViewModel)
            : base(ssBullyViewModel)
        {
            InitializeComponent();
        }
    }
}