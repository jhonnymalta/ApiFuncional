using System.ComponentModel.DataAnnotations;

namespace ApiFuncional.Models
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage ="The field {0} is required.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(100, ErrorMessage = "The field {0} need {2} and {1} character", MinimumLength = 5)]
        public string Password { get; set; }


        [Compare("Password",ErrorMessage ="Passwords dont match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LaginUserViewModel
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        [EmailAddress(ErrorMessage ="The fields format doesnt correct")]
        public string Email { get; set; }
        [StringLength(100, ErrorMessage = "The field {0} need {2} and {1} character", MinimumLength = 5)]
        [Required(ErrorMessage = "The field {0} is required.")]

        public string Password { get; set; }
    }
}
