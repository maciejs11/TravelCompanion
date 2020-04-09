using System;
using System.Collections.Generic;
using System.Text;
using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.Chat;
using Inzynierka.Models.TripAdverts;
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
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne<ApplicationUser>(x => x.Sender)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.UserID);

            builder.Entity<TripAdvert>()
                .HasOne<ApplicationUser>(x => x.ApplicationUser)
                .WithMany(x => x.TripAdverts)
                .HasForeignKey(x => x.UserId);
        }
    }
}
