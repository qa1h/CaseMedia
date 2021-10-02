using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Entities.BusinessEntities
{
    public class NewsEntity : BaseEntity
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public ObjectId _id { get; set; }
        public string Title { get; set; }
        public string Spot { get; set; }
        public DateTime PublishedTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public string[] NewsKeywords { get; set; }
        public CategoryEntity MainCategory { get; set; }
        public List<SourceEntity> SourcesData { get; set; }
        public AccountEntity PublishedAccount { get; set; }
        public AccountEntity CreatedAccount { get; set; }
        public StoryEntity Story { get; set; }

        public string MainArtUrl { get; set; }
    }
}
