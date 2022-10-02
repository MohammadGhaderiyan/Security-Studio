using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.TcpDump.ViewModel;

namespace SecurityStudio.Module.Tool.TcpDump.View
{
    public partial class SsTcpDumpView : SsView
    {
        public SsTcpDumpView(SsTcpDumpViewModel ssTcpDumpViewModel)
            : base(ssTcpDumpViewModel)
        {
            InitializeComponent();
        }
    }
}