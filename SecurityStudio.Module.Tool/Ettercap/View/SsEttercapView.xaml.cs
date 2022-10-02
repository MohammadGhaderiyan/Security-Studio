using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Ettercap.ViewModel;

namespace SecurityStudio.Module.Tool.Ettercap.View
{
    public partial class SsEttercapView : SsView
    {
        public SsEttercapView(SsEttercapViewModel ssEttercapViewModel)
            : base(ssEttercapViewModel)
        {
            InitializeComponent();
        }
    }
}