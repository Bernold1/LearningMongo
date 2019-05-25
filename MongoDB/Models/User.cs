using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Models
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        [BsonDateTimeOptions(DateOnly = true)]
        public DateTime Birthday { get; set; }

        public List<ObjectId> Followers { get; set; }
        public List<ObjectId> Following { get; set; }
        public List<ObjectId> Circles { get; set; }
        public List<ObjectId> Blocked { get; set; }
    }
}
