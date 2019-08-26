using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.TripAdvert
{
    public interface ITripAdvertRepository
    {
        IEnumerable<TripAdvert> GetAllTripAdverts();
    }
}
