using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Repository
{
   public  interface ICountDashboard
    {
        int GetTotalSubjets();

        int GetTotalStudents();

        int GetTotalTeachers();



    }
}
