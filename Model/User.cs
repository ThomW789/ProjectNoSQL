using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Model
{
    public class User
    {
        public ObjectId id;
        public string firstName;
        public string lastName;
        public TypeOfUser typeOfUser;
        public string email;
        public string phone;
        public Location location;
        public string password;

        public User(string firstName, string lastName, TypeOfUser typeOfUser, string email, string phone, Location location, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.typeOfUser = typeOfUser;
            this.email = email;
            this.phone = phone;
            this.location = location;
            this.password = password;
        }
    }
}
