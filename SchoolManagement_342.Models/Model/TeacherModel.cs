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

        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "First Name should only contain letters and spaces.")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Last Name should only contain letters and spaces.")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100, ErrorMessage = "Address cannot exceed 100 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Phone should only contain numbers.")]
        [StringLength(10, ErrorMessage = "Phone cannot exceed 10 characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public long Country { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public long State { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public long City { get; set; }
    

    }
}
