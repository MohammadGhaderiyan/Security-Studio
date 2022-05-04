using LiteDB;

namespace SecurityStudio.Database.Data.Configuration
{
    public class LiteDbConfiguration
    {
        private static bool _isConfigured;

        public static void Config()
        {
            if (_isConfigured)
                return;

            var mapper = BsonMapper.Global;

            //mapper.Entity<MasterObject>()
            //    .DbRef(masterObject => masterObject.DetailObject, "DetailObjects");

            _isConfigured = true;
        }
    }
}