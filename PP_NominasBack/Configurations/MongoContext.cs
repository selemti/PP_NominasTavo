using Microsoft.Extensions.Options;
using MongoDB.Driver;
namespace PP_NominasBack.Configurations
{
    /// <summary>
    /// Representa la clase MongoContext.
    /// </summary>
    public class MongoContext
    {
        private readonly IMongoDatabase _database;

        public MongoContext(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _database = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}
