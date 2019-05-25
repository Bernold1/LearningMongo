using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Models;

namespace MongoDB.SamleData
{
    public class ExampleData
    {
        public void SeedDataToDocuments()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            client.DropDatabase("SocialNetworkDB");
            var db = client.GetDatabase("SocialNetworkDB");

            #region Users

            var users = db.GetCollection<User>("Users");
            users.InsertOne(new User
            {
                FirstName = "John",
                LastName = "Wick",
                Gender = "Male",
                Location = "North America",
                Birthday = new DateTime(1966, 1, 20)
            });
            users.InsertOne(new User
            {
                FirstName = "Jason",
                LastName = "Pickle",
                Gender = "Male",
                Location = "North America",
                Birthday = new DateTime(1966, 1, 20)
            });
            users.InsertOne(new User
            {
                FirstName = "Chris",
                LastName = "Bernold",
                Gender = "Male",
                Location = "North America",
                Birthday = new DateTime(1997, 1, 20)
            });
            users.InsertOne(new User
            {
                FirstName = "Thomas",
                LastName = "Charles",
                Gender = "Male",
                Location = "North America",
                Birthday = new DateTime(1966, 1, 20)
            });

            users.InsertOne(new User
            {
                FirstName = "Mette",
                LastName = "Jensen",
                Gender = "Female",
                Location = "Europe",
                Birthday = new DateTime(1996, 2, 13)
            });

            #endregion
        }
    }
}
