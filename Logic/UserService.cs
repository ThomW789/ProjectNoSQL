using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class UserService
    {
        UserDAO userDAO = new UserDAO();

        public void CreateUser(string firstName, string lastName, TypeOfUser typeOfUser, string email, string phone, Location location, string password)
        {
            User user = new User(firstName,lastName,typeOfUser,email,phone,location,password);
            userDAO.CreateUser(user);
        }

        public User ReadUser(string email)
        {
            return userDAO.ReadUser(email);
        }

        public List<User> ReadUserAll()
        {
            return userDAO.ReadUserAll();
        }
    }
}
