using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class user
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
    }
}
