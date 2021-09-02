using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Responses
{
    public class LoginResponse
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string AccessToken { get; set; }
        public LoginResponse()
        {
        }
    }
}
