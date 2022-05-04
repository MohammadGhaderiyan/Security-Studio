using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Log
{
    public interface ILogService : IService
    {
        void Info(string info);
        void Warning(string warning);
        void Error(string error);
        void Error(Exception exception);
    }
}