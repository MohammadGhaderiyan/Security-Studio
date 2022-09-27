using Ninject;
using SecurityStudio.Service.Base.Session;

namespace SecurityStudio.Service.Base.Container
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