using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCompanion.Models
{
    public enum Sex
    {
        Male,
        Female
    }
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public string About { get; set; }
    }
}
