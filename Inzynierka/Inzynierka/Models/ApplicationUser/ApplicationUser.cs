using Inzynierka.Models.TripAdverts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.ApplicationUser
{
    public class ApplicationUser : IdentityUser
    {
        public string About { get; set; }

    }
}
