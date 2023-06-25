using Microsoft.EntityFrameworkCore;
using PetHotelDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHotelData
{
    public class PetHotelDataAccess : IPetHotelDataAccess
    {
        private readonly PetHotelContext _context;
        private  List<Cats> cats = new List<Cats>();

        public PetHotelDataAccess(PetHotelContext context)
        {
            _context = context;
        }

        public async Task<List<Cats>> GetAllCats()
        {
            cats = await _context.Cats.ToListAsync();
            return cats;
        }

        public async Task<Cats>  AddCats(Cats cat)
        {
            var addedEntity = _context.Cats.Add(cat);
            _context.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<List<Cats>> DeleteCat(int catId)
        {

            var foundCat = _context.Cats.Find(catId);
            if (foundCat == null)
            {
                return new List<Cats>() ;
            }
            else
            {
                _context.Cats.Remove(foundCat);
                await _context.SaveChangesAsync();

                // Updating the cats collection by re-fetching the data
                return await _context.Cats.ToListAsync();
            }
        }

        public async Task<List<string>> FindOccupiedCage()
        {
            List<string> cageLocations = new List<string>();
            var foundCages = await _context.Cats.ToListAsync();
            foreach(var cage in foundCages)
            {
                cageLocations.Add(cage.CageLocation);
            }
            return cageLocations;
        }


    }
}
