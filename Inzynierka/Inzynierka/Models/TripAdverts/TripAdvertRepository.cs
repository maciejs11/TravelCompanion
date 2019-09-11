using Inzynierka.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.TripAdverts
{
    public class TripAdvertRepository : ITripAdvertRepository
    {
        private readonly AppDbContext _appDbContext;

        public TripAdvertRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }        

        public IEnumerable<TripAdvert> GetAllTripAdverts()
        {
            return _appDbContext.TripAdverts;
        }

        public void AddTripAdvert(TripAdvert tripAdvert)
        {
            _appDbContext.TripAdverts.Add(tripAdvert);
            _appDbContext.SaveChanges();
        }
    }
}
