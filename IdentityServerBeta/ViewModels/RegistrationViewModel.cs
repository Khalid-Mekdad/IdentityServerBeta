using System.ComponentModel.DataAnnotations;

namespace StateOfTravel.ViewModels
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Required Field")]
        [MaxLength(50)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [MaxLength(50)]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [MaxLength(50)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        public string ClientUrl { get; set; }

        public string DublicatedEmailErrorMessage { get; set; }
    }
}
