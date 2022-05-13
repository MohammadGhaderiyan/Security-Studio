using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Whois.ViewModel;

namespace SecurityStudio.Module.Tool.Whois.View
{
    public partial class SsWhoisView : SsView
    {
        public SsWhoisView(SsWhoisViewModel ssWhoisViewModel)
            : base(ssWhoisViewModel)
        {
            InitializeComponent();
        }
    }
}