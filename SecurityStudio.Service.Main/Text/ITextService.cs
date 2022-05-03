using SecurityStudio.Base.Main.Model;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Text
{
    public interface ITextService : IService
    {
        string GetName(ModelName modelName);
    }
}