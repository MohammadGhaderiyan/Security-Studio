using System.Diagnostics;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SecurityStudio.Service.Main.Utility
{
    public class UtilityService : IUtilityService
    {
        public void StartFileOrFolderInWindows(string fileOrFolderAddress)
        {
            Process.Start(fileOrFolderAddress);
        }

        public void RunOnUiThread(Action action)
        {
            Application.Current.Dispatcher.Invoke(action);
        }

        public BitmapImage GetBitmapImageFromBytes(byte[] bytes)
        {
            var memoryStream = new System.IO.MemoryStream(bytes);

            var result = new BitmapImage();
            result.BeginInit();
            result.CacheOption = BitmapCacheOption.OnLoad;
            result.StreamSource = memoryStream;
            result.EndInit();

            return result;
        }

        public bool IsValidNationalCode(string nationalCode)
        {
            var allDigitEqual = new[]
            {
                "0000000000",
                "1111111111",
                "2222222222",
                "3333333333",
                "4444444444",
                "5555555555",
                "6666666666",
                "7777777777",
                "8888888888",
                "9999999999"
            };

            if (allDigitEqual.Contains(nationalCode))
                return false;

            var chArray = nationalCode.ToCharArray();
            var num0 = Convert.ToInt32(chArray[0].ToString()) * 10;
            var num2 = Convert.ToInt32(chArray[1].ToString()) * 9;
            var num3 = Convert.ToInt32(chArray[2].ToString()) * 8;
            var num4 = Convert.ToInt32(chArray[3].ToString()) * 7;
            var num5 = Convert.ToInt32(chArray[4].ToString()) * 6;
            var num6 = Convert.ToInt32(chArray[5].ToString()) * 5;
            var num7 = Convert.ToInt32(chArray[6].ToString()) * 4;
            var num8 = Convert.ToInt32(chArray[7].ToString()) * 3;
            var num9 = Convert.ToInt32(chArray[8].ToString()) * 2;
            var a = Convert.ToInt32(chArray[9].ToString());

            var b = num0 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9;
            var c = b % 11;

            return c < 2 && a == c || c >= 2 && 11 - c == a;
        }

        public void Dispose()
        {
        }
    }
}