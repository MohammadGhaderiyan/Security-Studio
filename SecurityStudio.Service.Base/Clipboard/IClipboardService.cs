using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Clipboard
{
    public interface IClipboardService : IService
    {
        string GetText();
        void SetText(string text);
    }
}