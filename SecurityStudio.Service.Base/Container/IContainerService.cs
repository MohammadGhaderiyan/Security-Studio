using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Container
{
    public interface IContainerService : IService
    {
        T Resolve<T>() where T : class;
        object Resolve(Type type);
    }
}