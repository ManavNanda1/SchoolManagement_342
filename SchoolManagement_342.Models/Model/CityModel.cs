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
        public int id { get; set; }

        [Required(ErrorMessage ="This Field Is required To be Filled")]
        public string CityName { get; set; }

        [Required(ErrorMessage = "This Field Is required To be Filled")]
        public int StateId { get; set; }

        public int CountryId { get; set; }

    }
}
