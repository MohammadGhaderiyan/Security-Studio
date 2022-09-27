using SecurityStudio.Base.Main.Database;
using SecurityStudio.Service.Base.Repository;
using SecurityStudio.Service.Base.Validator;

namespace SecurityStudio.Service.Base.BaseEntity
{
    public class BaseEntityService<T> : IBaseEntityService<T> where T : SecurityStudio.Base.Main.Database.BaseEntity
    {
        private readonly IRepositoryService<T> _repositoryService;
        private readonly IEntityValidatorService<T> _entityValidatorService;

        public BaseEntityService(IRepositoryService<T> repositoryService,
            IEntityValidatorService<T> entityValidatorService)
        {
            _repositoryService = repositoryService;
            _entityValidatorService = entityValidatorService;
        }

        public List<T> GetList()
        {
            return _repositoryService.GetAll().ToList();
        }

        public T Get(int baseEntityId)
        {
            return _repositoryService.Find(baseEntityId);
        }

        public void Save(T baseEntity)
        {
            if (baseEntity.Id == 0)
                _repositoryService.Add(baseEntity);

            _repositoryService.Save();
        }

        public void Delete(T baseEntity)
        {
            _repositoryService.Remove(baseEntity);
            _repositoryService.Save();
        }

        public bool IsValid(T baseEntity)
        {
            return _entityValidatorService.IsValid(baseEntity);
        }

        public void Dispose()
        {
            _repositoryService?.Dispose();
        }
    }
}