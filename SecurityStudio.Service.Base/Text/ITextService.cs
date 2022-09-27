using SecurityStudio.Base.Main.Model;
using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Text
{
    public interface ITextService : IService
    {
        string GetName(ModelName modelName);
    }
}