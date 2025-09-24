using System.ComponentModel.DataAnnotations;

namespace Monkeynetwork.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Сохранить вход")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
