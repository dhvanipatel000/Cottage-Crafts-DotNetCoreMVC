using System.ComponentModel.DataAnnotations;

namespace cottage_crafts.Models.ViewModel
{
    public class SignUpViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter email address")]
        [RegularExpression(@"^(.+)@(.+)$", ErrorMessage ="Enter valid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter mobile number")]
        [RegularExpression(@"^\s*\+?\s*([0-9][\s-]*){9,}$",ErrorMessage ="Enter valid Mobile Number")]
        public long? Mobile_no { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please enter confirm password")]
        [Compare("Password",ErrorMessage ="Password and Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}
