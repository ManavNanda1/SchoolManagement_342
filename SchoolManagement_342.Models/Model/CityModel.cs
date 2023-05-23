using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Models.Model
{
   public  class CityModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "City Name is required.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "City Name should only contain letters and spaces.")]
        [StringLength(50, ErrorMessage = "City Name cannot exceed 100 characters.")]
        public string CityName { get; set; }

        [Required(ErrorMessage = "State ID is required.")]
        public int StateId { get; set; }

        [Required(ErrorMessage = "Country ID is required.")]
        public int CountryId { get; set; }

    }
}
