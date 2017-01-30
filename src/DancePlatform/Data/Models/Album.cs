using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DancePlatform.Data.Models
{
    public class Album
    {
        public int ID { get; set; }        

        [Required]
        [MaxLength(100, ErrorMessage = "Invalid MaxLength for Name")]
        public string Name { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ClubID { get; set; }

        public Club Club { get; set; }
    }
}
