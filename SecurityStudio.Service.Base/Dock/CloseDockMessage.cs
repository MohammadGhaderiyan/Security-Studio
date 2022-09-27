using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Base.Dock
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