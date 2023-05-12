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
   public  class TeacherService : ITeacher
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();
                TeacherHelper userdata = new TeacherHelper();
        public void AddTeacher(TeacherModel TeacherData)
        {
            try
            {
                TeacherDetail user = userdata.AddData(TeacherData);
                context.TeacherDetails.Add(user);
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

       

        public List<Sp_Get_Teachers_Result> GetTeacherTable()
        {
            try
            {
                List<Sp_Get_Teachers_Result> TeacherList = context.Sp_Get_Teachers().ToList();
                return TeacherList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<SubjectDetail> SubjectDropdown()
        {
            try
            {
                List<SubjectDetail> GetSubjectList = context.SubjectDetails.ToList();
                return GetSubjectList;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int DelTeacherInDb(int TeacherId)
        {
            try
            {
                var Delteacher = context.TeacherDetails.Any(x => x.Id == TeacherId);
                if (Delteacher)
                {
                    TeacherDetail GetTeacher = context.TeacherDetails.Find(TeacherId);
                    context.TeacherDetails.Remove(GetTeacher);
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

        public TeacherModel EditTeacherInDb(int TeacherId)
        {
            try
            {
                var Teacher = context.TeacherDetails.Where(x => x.Id == TeacherId).FirstOrDefault();
                return (userdata.GetData(Teacher));
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public void UpdateData(int id, TeacherModel Model)
        {
            try
            {
                var Teacher = context.TeacherDetails.Where(x => x.Id == id).FirstOrDefault();
                userdata.EditData(Model, Teacher);

                context.SaveChanges();
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}
