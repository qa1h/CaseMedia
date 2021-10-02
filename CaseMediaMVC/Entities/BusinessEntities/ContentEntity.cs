using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Entities.BusinessEntities
{
    public class ContentEntity : BaseEntity
    {
        public string _t { get; set; }

        [BsonIgnoreIfNull]
        public string Text { get; set; }
        [BsonIgnoreIfNull]
        public string ImageUrl { get; set; }
    }
}
