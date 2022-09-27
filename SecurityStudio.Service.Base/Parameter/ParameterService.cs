namespace SecurityStudio.Service.Base.Parameter
{
    public class ParameterService : IParameterService
    {
        private readonly List<Tuple<string, object>> _values;

        public ParameterService()
        {
            _values = new List<Tuple<string, object>>();
        }

        public T GetValue<T>(string parameterName)
        {
            var currentParameter = _values.FirstOrDefault(item => item.Item1 == parameterName);
            var result = (T)currentParameter?.Item2;
            _values.Remove(currentParameter);

            return result;
        }

        public void SetValue(string parameterName, object value)
        {
            var currentParameter = _values.FirstOrDefault(item => item.Item1 == parameterName);
            if (currentParameter != null)
                _values.Remove(currentParameter);

            _values.Add(new Tuple<string, object>(parameterName, value));
        }

        public bool Exist(string parameterName)
        {
            return _values.Any(item => item.Item1 == parameterName);
        }

        public void Dispose()
        {
        }
    }
}