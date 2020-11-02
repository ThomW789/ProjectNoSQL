using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Base
    {
        protected IMongoClient client;
        private IMongoDatabase database;
        protected IMongoCollection<BsonDocument> userCollection;
        protected IMongoCollection<BsonDocument> ticketCollection;

        public Base()
        {
            client = new MongoClient("mongodb+srv://ThomWu:SViCgBHWOIRC94Cn@nodesk.f6jtd.mongodb.net");
            database = client.GetDatabase("GardenGroup");
            userCollection = database.GetCollection<BsonDocument>("Users");
            ticketCollection = database.GetCollection<BsonDocument>("Tickets");
        }
    }
}
