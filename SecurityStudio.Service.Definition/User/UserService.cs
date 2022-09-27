using SecurityStudio.Service.Base.Repository;

namespace SecurityStudio.Service.Definition.User
{
    public class UserService : IUserService
    {
        private readonly IRepositoryService<Database.Model.Definition.User> _userRepositoryService;

        public UserService(IRepositoryService<Database.Model.Definition.User> userRepositoryService)
        {
            _userRepositoryService = userRepositoryService;
        }

        public List<Database.Model.Definition.User> GetUsers()
        {
            return _userRepositoryService.GetAll().ToList();
        }

        public Database.Model.Definition.User GetUser(int userId)
        {
            return _userRepositoryService.Find(userId);
        }

        public void Save(Database.Model.Definition.User user)
        {
            if (user.Id == 0)
                _userRepositoryService.Add(user);

            _userRepositoryService.Save();
        }

        public void Delete(Database.Model.Definition.User user)
        {
            _userRepositoryService.Remove(user);
            _userRepositoryService.Save();
        }

        public bool IsValid(Database.Model.Definition.User user)
        {
            return true;
        }

        public void Dispose()
        {
            _userRepositoryService?.Dispose();
        }
    }
}