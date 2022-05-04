using System.Linq.Expressions;
using LiteDB;
using SecurityStudio.Database.Data.Configuration;
using SecurityStudio.Database.Model.Infrastructure;

namespace SecurityStudio.Service.Main.Repository
{
    public class LiteDbRepositoryService<TEntity> : IRepositoryService<TEntity> where TEntity : ModelBase
    {
        private readonly LiteDatabase _liteDatabase;
        private readonly ILiteCollection<TEntity> _liteCollection;
        private readonly List<TEntity> _editedEntities;
        private readonly List<TEntity> _addedEntities;
        private readonly List<TEntity> _removedEntities;

        public LiteDbRepositoryService()
        {
            LiteDbConfiguration.Config();
            _liteDatabase = new LiteDatabase(@"Filename=SecurityStudio.db;Connection=Shared;"); ;
            _liteCollection = _liteDatabase.GetCollection<TEntity>();

            _editedEntities = new List<TEntity>();
            _addedEntities = new List<TEntity>();
            _removedEntities = new List<TEntity>();
        }

        public TEntity Find(int id)
        {
            var result = _liteCollection.FindById(id);
            _editedEntities.Add(result);

            return result;
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, bool isTracking = false,
            string[] includePaths = null, params Expression<Func<TEntity, object>>[] includes)
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

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter = null, bool isTracking = false,
            string[] includePaths = null, params Expression<Func<TEntity, object>>[] includes)
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

        public TValue Max<TValue>(Func<TEntity, TValue> selector, Expression<Func<TEntity, bool>> filter = null)
        {
            var liteQueryable = _liteCollection.Query();

            if (filter != null)
                liteQueryable = liteQueryable.Where(filter);

            return liteQueryable.ToList() // All object load in memory. Optimize this section.
                .Max(selector);
        }

        public TValue Min<TValue>(Func<TEntity, TValue> selector, Expression<Func<TEntity, bool>> filter = null)
        {
            var liteQueryable = _liteCollection.Query();

            if (filter != null)
                liteQueryable = liteQueryable.Where(filter);

            return liteQueryable.ToList() // All object load in memory. Optimize this section.
                .Min(selector);
        }

        public void Add(TEntity entity)
        {
            _addedEntities.Add(entity);
        }

        public void Remove(TEntity entity)
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
            _editedEntities.AddRange(result.Cast<TEntity>());

            return result;
        }

        public void Dispose()
        {
        }
    }
}