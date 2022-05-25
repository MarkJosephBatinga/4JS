using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4JS.Shared
{
    public class Admin
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "first name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage = "Invelid Email Address")]
        public string email { get; set; }
        [Required(ErrorMessage = "password is Required")]
        [MinLength(8, ErrorMessage = "8 Minimum Characters Required")]
        public string password { get; set; }
    }
}
