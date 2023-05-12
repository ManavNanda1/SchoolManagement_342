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

        [Required(ErrorMessage ="Country Name Need To be Filled")]
        public string CountryName { get; set; }
    }
}
