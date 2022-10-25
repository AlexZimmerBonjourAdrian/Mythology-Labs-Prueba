using System.ComponentModel.DataAnnotations;
namespace football_MVC.Models
{
    public class Usuario
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        
        [Phone]
        public string PhoneNumber { get; set; }

        [MinLength(6)]
        public string Password { get; set; }

        [MinLength(4)]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        
    }
        
    }
