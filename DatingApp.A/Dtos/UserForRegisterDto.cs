using System.ComponentModel.DataAnnotations;

namespace DatingApp.A.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string   Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="passworw must be 4 to 8 haracters")]
        public string Password { get; set; }
    }
}