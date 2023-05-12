using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Mgmt_342.Controllers
{


    public class StudentController : Controller
    {
        IStudent NewObj;
        ICSCDropdown DropdownObj;

        public StudentController(IStudent Obj , ICSCDropdown Obj2) {
            NewObj = Obj;
            DropdownObj = Obj2; 
        }

        // GET: Student
        public ActionResult AddStudent()
        {
            try
            {
                ViewBag.CountryList = new SelectList(GetCountryList(), "Id", "CountryName");
                ViewBag.TeacherList = new SelectList(GetTeacherList(), "Id", "Fname");
                return View();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        [HttpPost]
        public ActionResult AddStudent(StudentModel StudentData,FormCollection collection)
        {
            try
            {
                string teacherid = collection["TeacherId"];
                StudentData.TeacherId = teacherid;
                NewObj.AddStudent(StudentData);
                return View();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public ActionResult GetStudents()
        {
            try
            {
                return View(NewObj.GetStudentTable());
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<Country> GetCountryList()
        {
            try
            {
                List<Country> GetCountry = DropdownObj.CountryDropDown().ToList();
                return GetCountry;
            }
            catch (Exception ex)
            {
                //throw new Exception("Error occurred in GetCountryList", ex);
                throw ex;
            }
        }


        public ActionResult GetStateList(int CountryId)
        {
            try
            {
                List<State> selectList = DropdownObj.StateDropDown(CountryId).ToList();
                ViewBag.StateList = new SelectList(selectList, "Id", "StateName");
                return PartialView("DisplayState");
            }
            catch (Exception ex)
            {

                return View("Error", ex);
            }
        }

        public ActionResult GetCityList(int StateId)
        {
            try
            {

                List<City> selectList = DropdownObj.CityDropDown(StateId).ToList();
                ViewBag.CityList = new SelectList(selectList, "Id", "CityName");
                return PartialView("DisplayCities");
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        public List<TeacherDetail> GetTeacherList()
        {
            try
            {
                List<TeacherDetail> GetTeacher = NewObj.TeacherDropdown().ToList();
                return GetTeacher;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred in GetCountryList", ex);
            }
        }

        public ActionResult DelStudent(int id)
        {
            try
            {
                NewObj.DelStudentInDb(id);
                return View();
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public ActionResult EditStudent(int id)
        {
            try
            {
                ViewBag.CountryList = new SelectList(GetCountryList(), "Id", "CountryName");
                ViewBag.TeacherList = new SelectList(GetTeacherList(), "Id", "Fname");
                return View(NewObj.EditStudentInDb(id));
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult EditStudent(int Id, StudentModel model)
        {
            try
            {
                NewObj.UpdateData(Id, model);
                return RedirectToAction("GetStudents");
            }
            catch (Exception E)
            {
                throw E;
            }
        }

    }
}