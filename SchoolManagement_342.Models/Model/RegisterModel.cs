using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement_342.Models.Model
{
    public class RegisterModel
    {
        [Key]
        public long UserId { get; set; }
        [Required(ErrorMessage ="User Email Need To Be Filled")]
        [EmailAddress(ErrorMessage ="Please Write Proper Email Address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage ="Password Is Required")]
        [MinLength(8)]
        public string UserPassword { get; set; }

        [Required(ErrorMessage ="Firstname Required To Be Filled")]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "Lastname Required To Be Filled")]
        public string UserLastName { get; set; }
    }
}
