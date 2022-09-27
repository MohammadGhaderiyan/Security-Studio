using System.Linq.Expressions;
using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Base.Repository
{
    public interface IRepositoryService<T> : IService where T : SecurityStudio.Base.Main.Database.BaseEntity
    {
        T Find(int id);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null,
            bool isTracking = false, string[] includePaths = null,
            params Expression<Func<T, object>>[] includes);
        T FirstOrDefault(Expression<Func<T, bool>> filter = null,
            bool isTracking = false, string[] includePaths = null,
            params Expression<Func<T, object>>[] includes);
        TValue Max<TValue>(Func<T, TValue> selector, Expression<Func<T, bool>> filter = null);
        TValue Min<TValue>(Func<T, TValue> selector, Expression<Func<T, bool>> filter = null);
        void Add(T baseEntity);
        void Remove(T baseEntity);
        void Save();
        IEnumerable<TCustomEntity> CustomGet<TCustomEntity>(Expression<Func<TCustomEntity, bool>> filter = null,
            bool isTracking = false, string[] includePaths = null,
            params Expression<Func<TCustomEntity, object>>[] includes) where TCustomEntity : class;
    }
}