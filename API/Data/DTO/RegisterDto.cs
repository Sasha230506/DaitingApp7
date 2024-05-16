using System.ComponentModel.DataAnnotations;

namespace _1314.API.Data.DTO;

public class RegisterDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}
