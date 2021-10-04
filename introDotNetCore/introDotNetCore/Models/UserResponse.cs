using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCore.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Epostanızı unutmayın!")]
        [EmailAddress(ErrorMessage = "Bu ne biçim eposta?")]
        public string Email { get; set; }
        public bool? IsAccept { get; set; }
    }
}
