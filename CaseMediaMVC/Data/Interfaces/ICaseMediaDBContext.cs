using MongoDB.Driver;

namespace CaseMediaMVC.Data.Interfaces
{
    public interface ICaseMediaDBContext
    {
        IMongoDatabase _db { get; }
        MongoClient _mongoClient { get; }
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
