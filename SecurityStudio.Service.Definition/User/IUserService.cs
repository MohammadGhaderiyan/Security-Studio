using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Definition.User
{
    public interface IUserService : IService
    {
        List<Database.Model.Definition.User> GetUsers();
        Database.Model.Definition.User GetUser(int userId);
        void Save(Database.Model.Definition.User user);
        void Delete(Database.Model.Definition.User user);
        bool IsValid(Database.Model.Definition.User user);
    }
}