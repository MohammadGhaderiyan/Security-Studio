using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Validator
{
    public interface IEntityValidatorService<T> : IService where T : SecurityStudio.Base.Main.Database.BaseEntity
    {
        bool IsValid(T baseEntity);
    }
}