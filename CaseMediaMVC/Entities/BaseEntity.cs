using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;

namespace CaseMediaMVC.Entities.BusinessEntities
{
    public class BaseEntity
    {
        //[BsonElement("Id")]
        //public string Id__ { get { return Id.ToString(); } set { Id = Guid.Parse(value); } }

        //[BsonIgnore]
        //public Guid Id { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; } 

        public DateTime CreateTime { get; set; }
    }
}
