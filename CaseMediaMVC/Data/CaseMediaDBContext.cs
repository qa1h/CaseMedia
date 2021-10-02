using CaseMediaMVC.Data.Interfaces;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using CaseMediaMVC.Helpers;
using CaseMediaMVC.Data.Seed;
using CaseMediaMVC.Entities.BusinessEntities;

namespace CaseMediaMVC.Data
{
    public class CaseMediaDBContext : ICaseMediaDBContext
    {
        private IMongoDatabase _db { get; set; }

        private MongoClient _mongoClient { get; set; }

        IMongoDatabase ICaseMediaDBContext._db { get { return _db; } }

        MongoClient ICaseMediaDBContext._mongoClient { get { return _mongoClient; } }

        public CaseMediaDBContext(IOptions<CaseMediaDBSettings> configuration)
        {
            _mongoClient = new MongoClient(configuration.Value.ConnectionString);
            _db = _mongoClient.GetDatabase(configuration.Value.DatabaseName);
            var newsCollect = _db.GetCollection<NewsEntity>("NewsEntity");
            CaseMediaContextSeed.SeedData(newsCollect);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _db.GetCollection<T>(name);
        }
    }
}
