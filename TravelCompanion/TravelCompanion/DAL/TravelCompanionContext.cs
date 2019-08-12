using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompanion.Models;

namespace TravelCompanion.DAL
{
    public class TravelCompanionContext : DbContext
    {
       
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        @"Data Source=LENOVO-Y700\SQLEXPRESS;Database=TravelCompanion;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public TravelCompanionContext(DbContextOptions<TravelCompanionContext> options)
            :base(options)
        {

        }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          
        }
        

    }
}
