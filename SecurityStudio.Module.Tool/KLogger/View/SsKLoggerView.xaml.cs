using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.KLogger.ViewModel;

namespace SecurityStudio.Module.Tool.KLogger.View
{
    public partial class SsKLoggerView : SsView
    {
        public SsKLoggerView(SsKLoggerViewModel ssKLoggerViewModel)
            : base(ssKLoggerViewModel)
        {
            InitializeComponent();
        }
    }
}