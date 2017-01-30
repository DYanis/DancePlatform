using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DancePlatform.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MinLength(3, ErrorMessage = "Invalid MinLength for LastName")]
        [MaxLength(30, ErrorMessage = "Invalid MaxLength for LastName")]
        public string FirstName { get; set; }

        [MinLength(3, ErrorMessage = "Invalid MinLength for LastName")]
        [MaxLength(30, ErrorMessage = "Invalid MaxLength for LastName")]
        public string LastName { get; set; }

        [MaxLength(300, ErrorMessage = "Invalid MaxLength for PhotoPath")]
        public string PhotoPath { get; set; }

        public byte Age { get; set; }
    }
}
