using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.DateTime
{
    public interface IDateTimeService : IService
    {
        System.DateTime GetNowDateTime();
        System.DateTime GetNowDate();
    }
}