using Inzynierka.Models.ApplicationUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.Administration
{
    public interface IAdministrationRepository
    {
        IEnumerable<ApplicationUser> Search(string searchTerm);
    }
}
