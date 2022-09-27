using System.Linq.Expressions;
using LiteDB;
using SecurityStudio.Database.Data.Configuration;

namespace SecurityStudio.Service.Base.Repository
{
    public class LiteDbRepositoryService<T> : IRepositoryService<T> where T : SecurityStudio.Base.Main.Database.BaseEntity
    {
        private readonly LiteDatabase _liteDatabase;
        private readonly ILiteCollection<T> _liteCollection;
        private readonly List<T> _editedEntities;
        private readonly List<T> _addedEntities;
        private readonly List<T> _removedEntities;

        public LiteDbRepositoryService()
        {
            LiteDbConfiguration.Config();
            _liteDatabase = new LiteDatabase(@"Filename=SecurityStudio.db;Connection=Shared;"); ;
            _liteCollection = _liteDatabase.GetCollection<T>();

            _editedEntities = new List<T>();
            _addedEntities = new List<T>();
            _removedEntities = new List<T>();
        }

        public T Find(int id)
        {
            var result = _liteCollection.FindById(id);
            _editedEntities.Add(result);

            return result;
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, bool isTracking = false,
            string[] includePaths = null, params Expression<Func<T, object>>[] includes)
        {
            var liteQueryable = _liteCollection.Query();

            if (filter != null)
                liteQueryable = liteQueryable.Where(filter);

            // NoTracking is not supported in lite db
            //if (!isTracking)
            //    queryable = queryable.AsNoTracking();

            if (includePaths != null)
            {
                foreach (var includePath in includePaths)
                    liteQueryable = liteQueryable.Include(includePath);
            }

            foreach (var include in includes)
                liteQueryable = liteQueryable.Include(include);

            var result = liteQueryable.ToList();
            _editedEntities.AddRange(result);

            return result;
        }

        public T FirstOrDefault(Expression<Func<T, bool>> filter = null, bool isTracking = false,
            string[] includePaths = null, params Expression<Func<T, object>>[] includes)
        {
            var liteQueryable = _liteCollection.Query();

            if (filter != null)
                liteQueryable = liteQueryable.Where(filter);

            // NoTracking is not supported in lite db
            //if (!isTracking)
            //    queryable = queryable.AsNoTracking();

            if (includePaths != null)
            {
                foreach (var includePath in includePaths)
                    liteQueryable = liteQueryable.Include(includePath);
            }

            foreach (var include in includes)
                liteQueryable = liteQueryable.Include(include);

            var result = liteQueryable.FirstOrDefault();
            _editedEntities.Add(result);

            return result;
        }

        public TValue Max<TValue>(Func<T, TValue> selector, Expression<Func<T, bool>> filter = null)
        {
            var liteQueryable = _liteCollection.Query();

            if (filter != null)
                liteQueryable = liteQueryable.Where(filter);

            return liteQueryable.ToList() // All object load in memory. Optimize this section.
                .Max(selector);
        }

        public TValue Min<TValue>(Func<T, TValue> selector, Expression<Func<T, bool>> filter = null)
        {
            var liteQueryable = _liteCollection.Query();

            if (filter != null)
                liteQueryable = liteQueryable.Where(filter);

            return liteQueryable.ToList() // All object load in memory. Optimize this section.
                .Min(selector);
        }

        public void Add(T entity)
        {
            _addedEntities.Add(entity);
        }

        public void Remove(T entity)
        {
            _removedEntities.Add(entity);
            _liteCollection.Delete(entity.Id);
        }

        public void Save()
        {
            _liteCollection.InsertBulk(_addedEntities);

            foreach (var removedEntity in _removedEntities)
                _liteCollection.Delete(removedEntity.Id);

            foreach (var editedEntity in _editedEntities)
                _liteCollection.Update(editedEntity);
        }

        public IEnumerable<TCustomEntity> CustomGet<TCustomEntity>(
            Expression<Func<TCustomEntity, bool>> filter = null, bool isTracking = false, string[] includePaths = null,
            params Expression<Func<TCustomEntity, object>>[] includes) where TCustomEntity : class
        {
            var liteQueryable = _liteDatabase.GetCollection<TCustomEntity>().Query();

            if (filter != null)
                liteQueryable = liteQueryable.Where(filter);

            // NoTracking is not supported in lite db
            //if (!isTracking)
            //    liteQueryable = liteQueryable.AsNoTracking();

            if (includePaths != null)
            {
                foreach (var includePath in includePaths)
                    liteQueryable = liteQueryable.Include(includePath);
            }

            foreach (var include in includes)
                liteQueryable = liteQueryable.Include(include);

            var result = liteQueryable.ToList();
            _editedEntities.AddRange(result.Cast<T>());

            return result;
        }

        public void Dispose()
        {
        }
    }
}