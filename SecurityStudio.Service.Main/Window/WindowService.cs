using System.Text;
using System.Windows;
using Microsoft.Win32;
using SecurityStudio.Base.Control.Window;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Main.Container;

namespace SecurityStudio.Service.Main.Window
{
    public class WindowService : IWindowService
    {
        private readonly IContainerService _containerService;

        public WindowService(IContainerService containerService)
        {
            _containerService = containerService;
        }

        public void ShowSsView<T>(ShowViewOption showViewOption = null) where T : SsView
        {
            var ssView = _containerService.Resolve<T>();
            ShowSsView(ssView, showViewOption);
        }

        public void ShowSsView<T>(T ssView, ShowViewOption showViewOption = null) where T : SsView
        {
            GetSsThemedWindow(ssView, showViewOption).Show();
        }

        public void ShowDialogSsView<T>(ShowViewOption showViewOption = null) where T : SsView
        {
            var ssView = _containerService.Resolve<T>();
            ShowDialogSsView(ssView, showViewOption);
        }

        public void ShowDialogSsView<T>(T ssView, ShowViewOption showViewOption = null) where T : SsView
        {
            GetSsThemedWindow(ssView, showViewOption).ShowDialog();
        }

        public void Close<T>(T ssViewModel) where T : SsViewModel
        {
            ssViewModel.SsView.Window.Close();
        }

        private SsThemedWindow GetSsThemedWindow(SsView ssView, ShowViewOption showViewOption)
        {
            var ssThemedWindow = new SsThemedWindow
            {
                Title = ssView.SsViewModel.Title,
                SizeToContent = SizeToContent.WidthAndHeight,
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            ssThemedWindow.SetContent(ssView);

            if (showViewOption != null)
            {
                if (showViewOption.WindowState != null)
                {
                    if (showViewOption.WindowState == WindowState.Maximized)
                        ssThemedWindow.SizeToContent = SizeToContent.Manual;

                    ssThemedWindow.WindowState = showViewOption.WindowState.Value;
                }

                if (showViewOption.ResizeMode != null)
                    ssThemedWindow.ResizeMode = showViewOption.ResizeMode.Value;

                if (showViewOption.Width != null)
                {
                    ssThemedWindow.SizeToContent = SizeToContent.Manual;
                    ssThemedWindow.Width = showViewOption.Width.Value;
                }

                if (showViewOption.Height != null)
                {
                    ssThemedWindow.SizeToContent = SizeToContent.Manual;
                    ssThemedWindow.Height = showViewOption.Height.Value;
                }
            }

            ssView.Window = ssThemedWindow;

            return ssThemedWindow;
        }

        public string ShowOpenFileDialog(string filter)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = filter
            };

            return openFileDialog.ShowDialog() == true ? openFileDialog.FileName : null;
        }

        public string ShowSaveFileDialog(string filter, string directoryAddress = null, string fileName = null)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = filter,
                InitialDirectory = directoryAddress ?? "",
                FileName = fileName ?? string.Empty,
            };

            return saveFileDialog.ShowDialog() == true ? saveFileDialog.FileName : null;
        }

        public string ShowOpenFileDialog(params FileType[] fileTypes)
        {
            return ShowOpenFileDialog(GetFilter(fileTypes));
        }

        public string ShowSaveFileDialog(string directoryAddress = null, string fileName = null, params FileType[] fileTypes)
        {
            return ShowSaveFileDialog(GetFilter(fileTypes), directoryAddress, fileName);
        }

        private string GetFilter(FileType[] fileTypes)
        {
            var stringBuilder = new StringBuilder();

            if (fileTypes.Contains(FileType.Image))
                stringBuilder.Append("Image Files|*.jpg;*.jpeg;*.png;|");

            if (fileTypes.Contains(FileType.Music))
                stringBuilder.Append("Music Files|*.mp3;*.wma;*.wav;|");

            if (fileTypes.Contains(FileType.Pdf))
                stringBuilder.Append("PDF Files|*.pdf;|");

            if (fileTypes.Contains(FileType.Text))
                stringBuilder.Append("Text Files|*.txt;|");

            if (fileTypes.Contains(FileType.Video))
                stringBuilder.Append("Video Files|*.avi;*.mov;*.wmv;*.mp4;*.mpeg;|");

            if (fileTypes.Contains(FileType.Word))
                stringBuilder.Append("Word Files|*.docx;*.doc;|");

            if (fileTypes.Contains(FileType.Zip))
                stringBuilder.Append("Zip File (*.zip)|*.zip|");

            return stringBuilder.ToString().Trim('|');
        }

        public string ShowChooseFolderFileDialog()
        {
            return null;

            //var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();

            //return folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK ?
            //    folderBrowserDialog.SelectedPath : null;
        }

        public void Dispose()
        {
            _containerService?.Dispose();
        }
    }
}