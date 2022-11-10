using System.ComponentModel.DataAnnotations;

namespace cottage_crafts.Models.Account
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public long? Mobile_no { get; set; }
        public string Password { get; set; }
    }
}
