using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class RegistrationViewModel
    {
        [Required, StringLength(100), Display(Name = "Full Name")]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required, StringLength(100)]
        public string Address { get; set; }

    }
}
