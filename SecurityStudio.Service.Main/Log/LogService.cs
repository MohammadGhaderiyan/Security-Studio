using NLog;

namespace SecurityStudio.Service.Main.Log
{
    public class LogService : ILogService
    {
        private readonly Logger _logger;

        public LogService()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public void Info(string info)
        {
            _logger.Info(info);
        }

        public void Warning(string warning)
        {
            _logger.Warn(warning);
        }

        public void Error(string error)
        {
            _logger.Error(error);
        }

        public void Error(Exception exception)
        {
            _logger.Error(exception);
        }

        public void Dispose()
        {
        }
    }
}