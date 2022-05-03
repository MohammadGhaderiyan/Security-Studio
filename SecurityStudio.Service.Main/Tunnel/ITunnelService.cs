using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Tunnel
{
    public interface ITunnelService : IService
    {
        void Send<T>(string tunnelName, T data) where T : class;
        void Register<T>(string tunnelName, Action<T> action) where T : class;
        void UnRegister(string tunnelName);
    }
}