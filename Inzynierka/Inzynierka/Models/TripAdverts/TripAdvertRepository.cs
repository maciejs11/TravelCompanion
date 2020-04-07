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

        public void DeleteTripAdvertAdmin(Guid id)
        {
            var tripAdvert = new TripAdvert { TripAdvertID = id };
            _appDbContext.TripAdverts.Attach(tripAdvert);
            _appDbContext.TripAdverts.Remove(tripAdvert);
            _appDbContext.SaveChanges();
        }

        public void DeleteTripAdvertUserProfile(Guid id)
        {
            var tripAdvert = new TripAdvert { TripAdvertID = id };
            _appDbContext.TripAdverts.Attach(tripAdvert);
            _appDbContext.TripAdverts.Remove(tripAdvert);
            _appDbContext.SaveChanges();
        }
    }
}
