using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Helpers.Helpers
{
    public class TeacherHelper
    {
        public TeacherDetail AddData(TeacherModel Registerdata)
        {
            TeacherDetail data = new TeacherDetail();
            data.Id = Registerdata.Id;
            data.Fname = Registerdata.Fname;
            data.LName = Registerdata.LName;
            data.Address = Registerdata.Address;
            data.Phone = Registerdata.Phone;
            data.Email = Registerdata.Email;
            data.subject = Registerdata.Subject;
            data.Gender = Registerdata.Gender;
            data.Country = Registerdata.Country;
            data.State = Registerdata.State;
            data.City = Registerdata.City;
            return data;
        }

        public TeacherModel GetData (TeacherDetail Registerdata)
        {
            TeacherModel data = new TeacherModel();
            data.Id = Registerdata.Id;
            data.Fname = Registerdata.Fname;
            data.LName = Registerdata.LName;
            data.Address = Registerdata.Address;
            data.Phone = Registerdata.Phone;
            data.Email = Registerdata.Email;
            data.Subject = Registerdata.subject;
            data.Gender = Registerdata.Gender;
            data.Country = Registerdata.Country;
            data.State = Registerdata.State;
            data.City = Registerdata.City;
            return data;
        }

        public void  EditData (TeacherModel data , TeacherDetail Teacher)
        {
            data.Id = Teacher.Id;
            data.Fname = Teacher.Fname;
            data.LName = Teacher.LName;
            data.Address = Teacher.Address;
            data.Phone = Teacher.Phone;
            data.Email = Teacher.Email;
            data.Subject = Teacher.subject;
            data.Gender = Teacher.Gender;
            data.Country = Teacher.Country;
            data.State = Teacher.State;
            data.City = Teacher.City;
        }
    }
}
