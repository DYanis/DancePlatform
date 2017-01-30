using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DancePlatform.Data.Models
{
    public class Club : IdentityUser
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Invalid MaxLength for Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(300, ErrorMessage = "Invalid MaxLength for PhotoPath")]
        public string PhotoPath { get; set; }

        public virtual ICollection<Album> Albums{ get; set; }
    }
}
