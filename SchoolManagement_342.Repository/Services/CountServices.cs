using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Services
{
    public class CountServices : ICountDashboard
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();
        public int GetTotalStudents()
        {
            try
            {
                return (context.StudentDetails.Count());
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public int GetTotalSubjets()
        {
            try
            {
                return (context.TeacherDetails.Count());
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public int GetTotalTeachers()
        {
            try
            {
                return (context.SubjectDetails.Count());
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}
