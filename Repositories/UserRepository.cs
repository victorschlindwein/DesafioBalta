using DesafioBalta.Models;
using System;

namespace DesafioBalta.Repositories 
{ 
    public class UserRepository
    {
        public static User Get(string email, string senha)
        {
            var users = new List<User>
            {
                new User { Id = 1, Email = "admin", Senha = "pwd123" }
            };

            return users.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }

        public static User Create(string email, string senha)
        {

        }
    }
}