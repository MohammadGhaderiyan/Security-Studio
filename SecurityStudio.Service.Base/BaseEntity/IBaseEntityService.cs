using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.BaseEntity
{
    public interface IBaseEntityService<T> : IService where T : SecurityStudio.Base.Main.Database.BaseEntity
    {
        List<T> GetList();
        T Get(int baseEntityId);
        void Save(T baseEntity);
        void Delete(T baseEntity);
        bool IsValid(T baseEntity);
    }
}