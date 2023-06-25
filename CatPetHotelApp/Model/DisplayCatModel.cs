using CatPetHotelApp.ValidationAttributes;
using PetHotelData;
using System.ComponentModel.DataAnnotations;

namespace CatPetHotelApp.Model
{
    public class DisplayCatModel
    {
        [Required]
        [StringLength(10,ErrorMessage ="Cat Name is too long.")]
        public string CatName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Cat Name is too long.")]
        public string Description { get; set; }

        [MaxByteLength(512 * 1024, ErrorMessage = "Maximum file size is 512 KB.")]
        public byte[]? Photo { get; set; }

        [Required] 
        public DateTime ArrivalDate { get; set; }

        [Required]
        [DateGreaterThan("ArrivalDate", ErrorMessage = "Departure date must be later than the arrival date.")]
        public DateTime EstimatedDepartureDate { get; set; }

        public string CageLocation { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Cat Name is too long.")]
        public string ownerName { get; set; }

        [Required]
        [EmailAddress]
        public string ownerEmail { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a numeric value.")]
        public string ownerPhone { get; set; } = string.Empty;

        private string fullName = typeof(PetHotelData.PetHotelDataAccess).FullName;
       // public Dictionary<string, int> AssignedCageDictionary = new Dictionary<string, int>();
    }
}
