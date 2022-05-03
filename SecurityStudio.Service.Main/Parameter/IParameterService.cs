using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Parameter
{
    public interface IParameterService : IService
    {
        T GetValue<T>(string parameterName);
        void SetValue(string parameterName, object value);
        bool Exist(string parameterName);
    }
}