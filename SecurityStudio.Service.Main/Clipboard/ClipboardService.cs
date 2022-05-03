using SecurityStudio.Service.Main.Utility;

namespace SecurityStudio.Service.Main.Clipboard
{
    public class ClipboardService : IClipboardService
    {
        private readonly IUtilityService _utilityService;

        public ClipboardService(IUtilityService utilityService)
        {
            _utilityService = utilityService;
        }

        public string GetText()
        {
            return System.Windows.Clipboard.GetText();
        }

        public void SetText(string text)
        {
            System.Windows.Clipboard.SetText(text);
        }

        public void Dispose()
        {
            _utilityService?.Dispose();
        }
    }
}