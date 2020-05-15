using System.ComponentModel.DataAnnotations;
namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [stringLength(8,MinimunLength = 4, ErrorMessage = "You must specify password between 4 and 8n characters")]
        public string Password { get; set; }
    }
}