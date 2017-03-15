using DancePlatform.GAC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DancePlatform.DAL.Models
{
    public class Event
    {
        public int ID { get; set; }

        public string ClubID { get; set; }

        public virtual Club Club { get; set; }

        [MaxLength(256, ErrorMessage = "Invalid Title length")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Invalid Description length")]
        public string Description { get; set; }

        [MaxLength(256, ErrorMessage = "Invalid PhotoPath length")]
        public string PhotoPath { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [MaxLength(256, ErrorMessage = "Invalid Title length")]
        public string LocationName { get; set; }

        public double LocationLongitude { get; set; }

        public double LocationLatitude { get; set; }

        public double EntrancePrice { get; set; }

        public int InterestedCount { get; set; }

        public int ViewsCount { get; set; }

        public ICollection<DanceType> DanceTypes { get; set; }
    }
}
