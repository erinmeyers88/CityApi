using System.ComponentModel.DataAnnotations;

namespace CityInfo.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50, ErrorMessage = "The name field has a maximum length of 50.")]
        public string Name { get; set; }
        
        [MaxLength(200, ErrorMessage = "The name field has a maximum length of 200.")]
        public string Description { get; set; }
    }
}