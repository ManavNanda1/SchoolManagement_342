using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Models.Model
{
    public class CountryModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Country Name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Country Name should only contain letters and spaces.")]
        [StringLength(50, ErrorMessage = "Country Name cannot exceed 50 characters.")]
        public string CountryName { get; set; }
    }
}
