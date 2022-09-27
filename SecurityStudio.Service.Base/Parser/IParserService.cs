using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Parser
{
    public interface IParserService : IService
    {
        int? ToInt(string value);
        long? ToLong(string value);
        double? ToDouble(string value);
        System.DateTime? ToDateTime(string value);
    }
}