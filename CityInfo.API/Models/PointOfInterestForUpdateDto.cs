using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
