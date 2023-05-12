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

        [Required(ErrorMessage ="This Field Need To Be Filled")]
        public string SubjectName { get; set; }
    }
}
