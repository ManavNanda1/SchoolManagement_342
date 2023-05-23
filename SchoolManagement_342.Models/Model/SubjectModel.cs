using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Models.Model
{
   public  class SubjectModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Subject Name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Subject Name should only contain letters and spaces.")]
        [StringLength(50, ErrorMessage = "Subject Name cannot exceed 50 characters.")]
        public string SubjectName { get; set; }
    }
}
