using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Models
{
    public class Circle
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string CircleName { get; set; }
        public string InterestArea { get; set; }
        public List<ObjectId> Users { get; set; }

    }
}
