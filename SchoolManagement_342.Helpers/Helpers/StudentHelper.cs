using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Helpers.Helpers
{
    public class StudentHelper
    {
        public StudentDetail AddData(StudentModel Registerdata)
        {
            StudentDetail data = new StudentDetail();
            data.Fname = Registerdata.Fname;
            data.LName = Registerdata.LName;
            data.Address = Registerdata.Address;
            data.Phone = Registerdata.Phone;
            data.Email = Registerdata.Email;
            data.Gender = Registerdata.Gender;
            data.TeacherId = Registerdata.TeacherId;
            data.Country = Registerdata.Country;
            data.State = Registerdata.State;
            data.City = Registerdata.City;
            data.CreatedOn = DateTime.Now;
            return data;
        }

        public StudentModel GetData(StudentDetail Student)
        {
            StudentModel data = new StudentModel();

            data.Id = (int)Student.Id;
            data.Fname = Student.Fname;
            data.LName = Student.LName;
            data.Address = Student.Address;
            data.Phone = Student.Phone;
            data.Email = Student.Email;
            data.Gender = Student.Gender;
            data.Country = Student.Country;
            data.State = Student.State;
            data.City = Student.City;
            data.TeacherId = Student.TeacherId;
            return data;
        }

        public void UpdateData(StudentModel Model, StudentDetail Student)
        {
            Student.Id = Model.Id;
            Student.Fname = Model.Fname;
            Student.LName = Model.LName;
            Student.Address = Model.Address;
            Student.Phone = Model.Phone;
            Student.Email = Model.Email;
            Student.Gender = Model.Gender;
            Student.Country = Model.Country;
            Student.State = Model.State;
            Student.City = Model.City;
            Student.TeacherId = Model.TeacherId;
        }


    }
}
