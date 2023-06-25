using PetHotelDomain;

namespace PetHotelData
{
    public interface IPetHotelDataAccess
    {
        Task<Cats> AddCats(Cats cat);
        Task<List<Cats>> DeleteCat(int catId);
        Task<List<Cats>> GetAllCats();
        Task<List<string>> FindOccupiedCage();
    }
}