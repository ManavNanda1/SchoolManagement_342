using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Repository
{
   public  interface ITeacher
    {
        void AddTeacher(TeacherModel TeacherData);

        List<SubjectDetail> SubjectDropdown();

        List<Sp_Get_Teachers_Result> GetTeacherTable();

        int DelTeacherInDb(int TeacherId);

        TeacherModel EditTeacherInDb(int TeacherId);

        void UpdateData(int id, TeacherModel Model);
    }
}
