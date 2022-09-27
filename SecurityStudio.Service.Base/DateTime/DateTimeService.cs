namespace SecurityStudio.Service.Base.DateTime
{
    public class DateTimeService : IDateTimeService
    {
        public System.DateTime GetNowDateTime()
        {
            return System.DateTime.Now;
        }

        public System.DateTime GetNowDate()
        {
            return System.DateTime.Now.Date;
        }

        public void Dispose()
        {
        }
    }
}