using System.ComponentModel.DataAnnotations;

namespace DancePlatform.DAL.Models
{
    public class DanceType
    {
        public int ID { get; set; }

        [MaxLength(255, ErrorMessage = "Invalid DanceType Name legth")]
        public string Name { get; set; }
    }
}
