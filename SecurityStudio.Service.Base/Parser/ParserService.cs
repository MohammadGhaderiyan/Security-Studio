namespace SecurityStudio.Service.Base.Parser
{
    public class ParserService : IParserService
    {
        public int? ToInt(string value)
        {
            if (int.TryParse(value, out var result))
                return result;

            return null;
        }

        public long? ToLong(string value)
        {
            if (long.TryParse(value, out var result))
                return result;

            return null;
        }

        public double? ToDouble(string value)
        {
            if (double.TryParse(value, out var result))
                return result;

            return null;
        }

        public System.DateTime? ToDateTime(string value)
        {
            if (System.DateTime.TryParse(value, out var result))
                return result;

            return null;
        }

        public void Dispose()
        {
        }
    }
}