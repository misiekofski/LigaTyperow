using System.ComponentModel.DataAnnotations;

namespace LigaTyperow.Models.Users
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }

        public int UserPoints { get; set; }
    }
}