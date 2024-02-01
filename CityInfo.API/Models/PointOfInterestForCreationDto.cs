using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "Enter Same Length Name")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
