using SecurityStudio.Base.Main.Model;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.MessageBox
{
    public interface IMessageBoxService : IService
    {
        void ShowInfo(string message);
        void ShowWarning(string message);
        void ShowError(string message);
        bool? ShowYesNoQuestion(string question);
        bool ShowDeleteYesNoQuestion(ModelName modelName);
    }
}