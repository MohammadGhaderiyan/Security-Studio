using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Container
{
    public interface IContainerService : IService
    {
        T Resolve<T>() where T : class;
        object Resolve(Type type);
    }
}