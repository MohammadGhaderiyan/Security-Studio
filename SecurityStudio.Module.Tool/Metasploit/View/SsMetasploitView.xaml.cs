using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Metasploit.ViewModel;

namespace SecurityStudio.Module.Tool.Metasploit.View
{
    public partial class SsMetasploitView : SsView
    {
        public SsMetasploitView(SsMetasploitViewModel ssMetasploitViewModel)
            : base(ssMetasploitViewModel)
        {
            InitializeComponent();
        }
    }
}