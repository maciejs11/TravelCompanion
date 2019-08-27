using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.TripAdvert
{
    public class MockTripAdvertRepository : ITripAdvertRepository
    {
        private List<TripAdvert> _tripAverts;

        public MockTripAdvertRepository()
        {
            if(_tripAverts == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _tripAverts = new List<TripAdvert>
            {
                new TripAdvert{ TripAdvertID = 1, AdvertDate = new DateTime(2019,08,26), Country="USA", Title="Wyprawa do NYC", Content="Hej, kto chciałby w październiku wybrać się do Nowego Jorku na ok 2 tygodnie?"  },
                new TripAdvert{ TripAdvertID = 2, AdvertDate = new DateTime(2019,08,26), Country="Francja", Title="Zwiedzanie Paryża", Content="Cześć, miałby ktoś ochotę wybrać się do Paryża we wrześniu na tydzień?"  },
                new TripAdvert{ TripAdvertID = 3, AdvertDate = new DateTime(2019,08,26), Country="Kanada", Title="Toronto w listpoadzie", Content="Hej, kto chciałby w październiku wybrać się do Toronto na 3 tygodnie?"  },
                new TripAdvert{ TripAdvertID = 4, AdvertDate = new DateTime(2019,08,27), Country="Czechy", Title="Wycieczka do Pragi", Content="Witam, interesuje kogoś wycieczka do Pragi na długi weekend? Myślalkem o pobycie w jakimś apartamencie w Airbnb. Jeśli ktoś jest chętny proszę o kontakt."  },
                new TripAdvert{ TripAdvertID = 5, AdvertDate = new DateTime(2019,08,27), Country="Austria", Title="Wiedeń", Content="Cześć, jest ktoś chętny na wyprawę do Wiednia na tydzień? Fajnie by było, jakby zgłosiły się co najmniej 3 osoby."  },
            };

        }

        public IEnumerable<TripAdvert> GetAllTripAdverts()
        {
            return _tripAverts;
        }
    }
}
