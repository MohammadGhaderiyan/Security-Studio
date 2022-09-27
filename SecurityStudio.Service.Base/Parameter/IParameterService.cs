using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Parameter
{
    public interface IParameterService : IService
    {
        T GetValue<T>(string parameterName);
        void SetValue(string parameterName, object value);
        bool Exist(string parameterName);
    }
}