using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Models.Model
{
   public  class TeacherModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        public string LName { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        [MaxLength(10)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        public System.DateTime DOB { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        public string Gender { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        public long Country { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        public long State { get; set; }

        [Required(ErrorMessage = "This Field Is Required To Be Filled")]
        public long City { get; set; }
    }
}
