using System;
using System.ComponentModel.DataAnnotations;

namespace DancePlatform.Data.Models
{
    public class Photo
    {
        public int ID { get; set; }

        public int AlbumID { get; set; }

        public Album Album { get; set; }

        [Required]
        [MaxLength(300, ErrorMessage = "Invalid MaxLength for Path")]
        public string Path { get; set; }

        [MaxLength(1000, ErrorMessage = "Invalid MaxLength for Description")]
        public string Description { get; set; }

        public DateTime UploadDate { get; set; }
    }
}
