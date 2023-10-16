using DesafioBalta.Models;
using System;

namespace DesafioBalta.Repositories 
{ 
    public class UserRepository
    {

        private static List<User> _user = new();

        public static List<User> Get()
        {
            return _user;
        }

        public static User Create(string email, string senha)
        {
            var user = new User { Id = 1, Email = email, Senha = senha };
            _user.Add(user);

            return user;
        }
    }
}