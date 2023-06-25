namespace PetHotelDomain
{
    public class Cats 
    {
        public int CatsId { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }

        public byte[]? Photo { get; set; }
        public DateTime EstimatedDepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string CageLocation { get; set; }
        public string ownerName { get; set; }
        public string ownerEmail { get; set; }
        public string ownerPhone { get; set; }
    }
}