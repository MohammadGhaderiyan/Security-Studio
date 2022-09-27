using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.DateTime
{
    public interface IDateTimeService : IService
    {
        System.DateTime GetNowDateTime();
        System.DateTime GetNowDate();
    }
}