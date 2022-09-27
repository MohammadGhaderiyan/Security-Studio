using SecurityStudio.Service.Base.Repository;
using SecurityStudio.Service.Base.Validator;

namespace SecurityStudio.Service.Definition.AndroidOperatingSystem
{
    public interface IAndroidOperatingSystemService : IRepositoryService<Database.Model.Definition.AndroidOperatingSystem>,
        IEntityValidatorService<Database.Model.Definition.AndroidOperatingSystem>
    {
    }
}