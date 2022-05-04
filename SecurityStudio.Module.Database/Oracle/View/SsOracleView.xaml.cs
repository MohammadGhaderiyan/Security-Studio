using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Database.Oracle.ViewModel;

namespace SecurityStudio.Module.Database.Oracle.View
{
    public partial class SsOracleView : SsView
    {
        public SsOracleView(SsOracleViewModel ssOracleViewModel)
            : base(ssOracleViewModel)
        {
            InitializeComponent();
        }
    }
}