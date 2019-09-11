using System;
using System.Collections.Generic;
using System.Text;
using Inzynierka.Models.ApplicationUser;
using Inzynierka.Models.TripAdvert;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inzynierka.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<TripAdvert> TripAdverts { get; set; }
    }
}
