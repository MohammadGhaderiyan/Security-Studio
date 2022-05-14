using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.Persistence.ViewModel;

namespace SecurityStudio.Module.Mitre.Persistence.View
{
    public partial class SsPersistenceView : SsView
    {
        public SsPersistenceView(SsPersistenceViewModel ssPersistenceViewModel)
            : base(ssPersistenceViewModel)
        {
            InitializeComponent();
        }
    }
}