using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Models.Context;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Repository
{
    public interface IStudent
    {
        void AddStudent(StudentModel StudentData);

        List<Sp_Get_Students_Result> GetStudentTable();

        List<TeacherDetail> TeacherDropdown();

        int DelStudentInDb(int StudentId);

        StudentModel EditStudentInDb(int StudentId);

        void UpdateData(int id, StudentModel Model);

    }
}
