namespace SecurityStudio.Service.Base.Tunnel
{
    public class TunnelService : ITunnelService
    {
        private readonly List<Tuple<string, List<Action<object>>>> _tunnels;

        public TunnelService()
        {
            _tunnels = new List<Tuple<string, List<Action<object>>>>();
        }

        public void Send<T>(string tunnelName, T data) where T : class
        {
            foreach (var tunnel in _tunnels.Where(item => item.Item1 == tunnelName))
                foreach (var action in tunnel.Item2)
                    action(data);
        }

        public void Register<T>(string tunnelName, Action<T> action) where T : class
        {
            var tunnel = _tunnels.FirstOrDefault(item => item.Item1 == tunnelName);
            if (tunnel == null)
            {
                tunnel = new Tuple<string, List<Action<object>>>(tunnelName, new List<Action<object>>());
                _tunnels.Add(tunnel);
            }

            tunnel.Item2.Add(parameter => { action((T)parameter); });
        }

        public void UnRegister(string tunnelName)
        {
            var tunnel = _tunnels.FirstOrDefault(item => item.Item1 == tunnelName);
            if (tunnel != null)
                _tunnels.Remove(tunnel);
        }

        public void Dispose()
        {
        }
    }
}