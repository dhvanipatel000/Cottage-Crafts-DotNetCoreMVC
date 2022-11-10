using System.ComponentModel.DataAnnotations;

namespace cottage_crafts.Models.ViewModel
{
    public class LoginSignUpViewModel
    {

        [Required(ErrorMessage = "Please enter username")]
        
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}
