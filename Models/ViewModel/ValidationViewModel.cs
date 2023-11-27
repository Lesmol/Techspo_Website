using System.ComponentModel.DataAnnotations;

namespace Work_Integrated_Learning.Models.ViewModel
{
    public class ValidationViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(6, ErrorMessage = "Username must have at least 6 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
    }
}
