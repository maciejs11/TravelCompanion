﻿using Inzynierka.Models.ApplicationUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.Chat
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public string UserID { get; set; }
        public virtual ApplicationUser Sender { get; set; }
    }
}
