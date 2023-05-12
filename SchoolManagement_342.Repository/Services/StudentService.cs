using SchoolManagement_342.Helpers.Helpers;
using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Services
{
    public class StudentService : IStudent
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();
                StudentHelper userdata = new StudentHelper();
        public void AddStudent(StudentModel StudentData)
        {
            try
            {
                StudentDetail user = userdata.AddData(StudentData);
                context.StudentDetails.Add(user);
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        

        public List<Sp_Get_Students_Result> GetStudentTable()
        {
            try
            {
                List<Sp_Get_Students_Result> StudentList = context.Sp_Get_Students().ToList();
                return StudentList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TeacherDetail> TeacherDropdown()
        {
            try
            {
                List<TeacherDetail> GetTeacherList = context.TeacherDetails.ToList();
                return GetTeacherList;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int DelStudentInDb(int StudentId)
        {
            try
            {
                var DelStudent = context.StudentDetails.Any(x => x.Id == StudentId);
                if (DelStudent)
                {
                    StudentDetail GetStudent = context.StudentDetails.Find(StudentId);
                    context.StudentDetails.Remove(GetStudent);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public StudentModel EditStudentInDb(int StudentId)
        {
            try
            {
                var Student = context.StudentDetails.Where(x => x.Id == StudentId).FirstOrDefault();

                return(userdata.GetData(Student));

            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public void UpdateData(int id, StudentModel Model)
        {
            try
            {
                var Student = context.StudentDetails.Where(x => x.Id == id).FirstOrDefault();

                userdata.UpdateData(Model, Student);

                context.SaveChanges();
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}
