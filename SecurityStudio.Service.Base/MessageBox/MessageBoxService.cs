using System.Windows;
using DevExpress.Xpf.Core;
using SecurityStudio.Base.Main.Model;
using SecurityStudio.Service.Base.Text;

namespace SecurityStudio.Service.Base.MessageBox
{
    public class MessageBoxService : IMessageBoxService
    {
        private readonly ITextService _textService;

        public MessageBoxService(ITextService textService)
        {
            _textService = textService;
        }

        public void ShowInfo(string message)
        {
            DXMessageBox.Show(message, "Security Studio",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void ShowWarning(string message)
        {
            DXMessageBox.Show(message, "Security Studio",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void ShowError(string message)
        {
            DXMessageBox.Show(message, "Security Studio",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public bool? ShowYesNoQuestion(string question)
        {
            var messageBoxResult = DXMessageBox.Show(question, "Security Studio",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.Yes)
                return true;

            if (messageBoxResult == MessageBoxResult.No)
                return false;

            return null;
        }

        public bool ShowDeleteYesNoQuestion(ModelName modelName)
        {
            return ShowYesNoQuestion($"Are You Sure You Want To Delete The {_textService.GetName(modelName)}?") ?? false;
        }

        public void Dispose()
        {
        }
    }
}