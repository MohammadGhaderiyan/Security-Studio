using Ninject;
using SecurityStudio.Service.Main.Session;

namespace SecurityStudio.Service.Main.Container
{
    public class ContainerService : IContainerService
    {
        private readonly ISessionService _sessionService;

        public ContainerService(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public T Resolve<T>() where T : class
        {
            return _sessionService.Kernel.Get<T>();
        }

        public object Resolve(Type type)
        {
            return _sessionService.Kernel.Get(type);
        }

        public void Dispose()
        {
            _sessionService?.Dispose();
        }
    }
}