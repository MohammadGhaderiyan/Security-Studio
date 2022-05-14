using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.Collection.ViewModel;

namespace SecurityStudio.Module.Mitre.Collection.View
{
    public partial class SsCollectionView : SsView
    {
        public SsCollectionView(SsCollectionViewModel ssCollectionViewModel)
            : base(ssCollectionViewModel)
        {
            InitializeComponent();
        }
    }
}