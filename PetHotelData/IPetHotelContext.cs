using Microsoft.EntityFrameworkCore;
using PetHotelDomain;

namespace PetHotelData
{
    public interface IPetHotelContext
    {
        DbSet<Cats> Cats { get; set; }
    }
}