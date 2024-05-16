using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace API.Data.DTO
{
    public class LoginDto
    {
         public string Username { get; set; }
         public string Password { get; set; }
    }
}