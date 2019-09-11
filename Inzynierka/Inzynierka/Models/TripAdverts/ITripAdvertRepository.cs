using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.TripAdverts
{
    public interface ITripAdvertRepository
    {
        IEnumerable<TripAdvert> GetAllTripAdverts();
        void AddTripAdvert(TripAdvert tripAdvert);
    }
}
