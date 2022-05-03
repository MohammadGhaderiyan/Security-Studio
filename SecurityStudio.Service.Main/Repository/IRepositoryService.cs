using System.Linq.Expressions;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Main.Repository
{
    public interface IRepositoryService<TEntity> : IService where TEntity : class
    {
        TEntity Find(int id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            bool isTracking = false, string[] includePaths = null,
            params Expression<Func<TEntity, object>>[] includes);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter = null,
            bool isTracking = false, string[] includePaths = null,
            params Expression<Func<TEntity, object>>[] includes);
        TValue Max<TValue>(Func<TEntity, TValue> selector, Expression<Func<TEntity, bool>> filter = null);
        TValue Min<TValue>(Func<TEntity, TValue> selector, Expression<Func<TEntity, bool>> filter = null);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Save();
        IEnumerable<TCustomEntity> CustomGet<TCustomEntity>(Expression<Func<TCustomEntity, bool>> filter = null,
            bool isTracking = false, string[] includePaths = null,
            params Expression<Func<TCustomEntity, object>>[] includes) where TCustomEntity : class;
    }
}