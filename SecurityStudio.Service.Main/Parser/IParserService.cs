using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Parser
{
    public interface IParserService : IService
    {
        int? ToInt(string value);
        long? ToLong(string value);
        double? ToDouble(string value);
        System.DateTime? ToDateTime(string value);
    }
}