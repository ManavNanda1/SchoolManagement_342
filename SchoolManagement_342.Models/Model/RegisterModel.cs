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

        [Required(ErrorMessage = "User Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password should be at least 8 characters long.")]
        [MaxLength(15)]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "First name should only contain letters and spaces.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Last name should only contain letters and spaces.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string UserLastName { get; set; }
    }
}
