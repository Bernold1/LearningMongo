using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Models;

namespace MongoDB.Services
{
    public class DataAccess : IDisposable
    {
        private IMongoDatabase database;
        public DataAccess()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("SocialNetworkDB");
        }

        public IMongoCollection<T> GetMongoCollection<T>(String docName)
        {
            return database.GetCollection<T>(docName);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
