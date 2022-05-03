using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Dock
{
    public class CloseDockMessage
    {
        public SsView SsView { get; set; }

        public CloseDockMessage(SsView ssView)
        {
            SsView = ssView;
        }
    }
}