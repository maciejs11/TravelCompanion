using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.ChatEmail
{
    public class EmailMessage
    {
        public Guid Id { get; set; }
        public string EmailTo { get; set; }
        public string Message { get; set; }
    }
}
