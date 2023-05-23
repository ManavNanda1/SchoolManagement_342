using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Models.Model
{
    public  class StateModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "State Name is required.")]
        [StringLength(50, ErrorMessage = "State Name cannot exceed 50 characters.")]
        public string StateName { get; set; }

        [Required(ErrorMessage = "Country ID is required.")]
        public int CountryId { get; set; }
    }
}
