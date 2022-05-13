using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Encryption.ViewModel;

namespace SecurityStudio.Module.Tool.Encryption.View
{
    public partial class SsEncryptionView : SsView
    {
        public SsEncryptionView(SsEncryptionViewModel ssEncryptionViewModel)
            : base(ssEncryptionViewModel)
        {
            InitializeComponent();
        }
    }
}