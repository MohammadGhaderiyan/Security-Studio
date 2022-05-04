using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Database.MongoDb.ViewModel;

namespace SecurityStudio.Module.Database.MongoDb.View
{
    public partial class SsMongoDbView : SsView
    {
        public SsMongoDbView(SsMongoDbViewModel ssMongoDbViewModel)
            : base(ssMongoDbViewModel)
        {
            InitializeComponent();
        }
    }
}