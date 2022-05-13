using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.WindowsNslookup.ViewModel;

namespace SecurityStudio.Module.Windows.WindowsNslookup.View
{
    public partial class SsWindowsNslookupView : SsView
    {
        public SsWindowsNslookupView(SsWindowsNslookupViewModel ssWindowsNslookupViewModel)
            : base(ssWindowsNslookupViewModel)
        {
            InitializeComponent();
        }
    }
}