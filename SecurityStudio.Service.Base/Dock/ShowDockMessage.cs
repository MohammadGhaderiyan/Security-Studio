namespace SecurityStudio.Service.Base.Dock
{
    public class ShowDockMessage
    {
        public Type SsViewType { get; set; }

        public ShowDockMessage(Type ssViewType)
        {
            SsViewType = ssViewType;
        }
    }
}