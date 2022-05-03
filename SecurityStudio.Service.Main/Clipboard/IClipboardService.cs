using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Clipboard
{
    public interface IClipboardService : IService
    {
        string GetText();
        void SetText(string text);
    }
}