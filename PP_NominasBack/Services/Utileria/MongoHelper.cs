using MongoDB.Driver;
using System.Threading.Tasks;

public static class MongoHelper
{
    public static async Task ReplaceOneOrInsertAsync<T>(
        IMongoCollection<T> collection,
        FilterDefinition<T> filter,
        T document
    ) where T : class
    {
        await collection.ReplaceOneAsync(
            filter,
            document,
            new ReplaceOptions { IsUpsert = true });
    }
}
