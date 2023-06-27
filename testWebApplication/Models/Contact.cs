using System.ComponentModel.DataAnnotations;

namespace testWebApplication.Models
{
    public class Contact
    {
        [Display(Name = "Input name")]
        [Required(ErrorMessage = "Input name")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name is too short")]
        public string Name { get; set; }
        [Display(Name = "Input second name")]
        [Required(ErrorMessage = "Input second name")]
        public string SurName { get; set; }
        [Display(Name = "Input age")]
        [Required(ErrorMessage = "Input age")]
        public int Age { get; set; }
        [Display(Name = "Input email adress")]
        [Required(ErrorMessage = "Input email")]
        public string Email { get; set; }
        [Display(Name = "Input message")]
        [Required(ErrorMessage = "Input message")]
        [StringLength(200, ErrorMessage = "Message is too short", MinimumLength = 10)]
        public string Message { get; set; }
    }
}
