using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesafioBalta.Models
{
    public class User
    {
        public int Id { get; set; }

        [EmailAddress]
        public required string Email { get; set; }

        [PasswordPropertyText]
        public required string Password { get; set; }

        public string AcessToken { get; set; }
    }
}
