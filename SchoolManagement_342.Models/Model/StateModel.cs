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
        public int Id  { get; set; }

        [Required(ErrorMessage ="Please Enter State Name Below ")]
        public string StateName { get; set; }

        public int CountryId { get; set; }
    }
}
