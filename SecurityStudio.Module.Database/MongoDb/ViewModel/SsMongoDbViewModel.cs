using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Database.MongoDb.ViewModel
{
    public class SsMongoDbViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Mongo DB";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}