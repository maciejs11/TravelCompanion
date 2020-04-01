using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.ViewModels
{
    public class CreateRoleViewModel
    {   [Required(ErrorMessage ="Nazwa roli jest wymagana")]
        public string RoleName { get; set; }
    }
}
