using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UserDAO : Base
    {
        public void CreateUser(User user)
        {
            BsonDocument bsonUser = new BsonDocument
            {
                {"firstName", user.firstName },
                {"lastName", user.lastName },
                {"typeOfUser", user.typeOfUser },
                {"email", user.email },
                {"phone", user.phone },
                {"location", user.location },
                {"password",user.password }
            };
            userCollection.InsertOne(bsonUser);
        }

        public List<User> ReadUserAll()
        {
            List<BsonDocument> documents = userCollection.Find(new BsonDocument()).ToList();
            List<User> userList = new List<User>();

            foreach (BsonDocument document in documents)
            {
                User user = BsonSerializer.Deserialize<User>(document);
                userList.Add(user);
            }
            return userList;
        }

        public User ReadUser(string email)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("email", email);
            BsonDocument document = userCollection.Find(filter).FirstOrDefault();
            User user;
            try
            {
                user = BsonSerializer.Deserialize<User>(document);
            }
            catch 
            {
                user = null;
            }
            return user;
        }

        public void UpdateUser(string email, string key, string value)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("email", email);
            UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set(key, value);
            userCollection.UpdateOne(filter, update);
        }

        public void DeleteUser(string email)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("email", email);
            userCollection.DeleteOne(filter);
        }
    }
}
