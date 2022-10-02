using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint.OneMillionTweetMap.ViewModel;

namespace SecurityStudio.Module.Osint.OneMillionTweetMap.View
{
    public partial class SsOneMillionTweetMapView : SsView
    {
        public SsOneMillionTweetMapView(SsOneMillionTweetMapViewModel ssOneMillionTweetMapViewModel)
            : base(ssOneMillionTweetMapViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}