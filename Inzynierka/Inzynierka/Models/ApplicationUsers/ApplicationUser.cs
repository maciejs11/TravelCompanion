using Inzynierka.Models.Chat;
using Inzynierka.Models.TripAdverts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.ApplicationUsers
{
   
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Messages = new HashSet<Message>();
        }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; } 
        public string About { get; set; }

        public List<TripAdvert> TripAdverts { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

    }
}
