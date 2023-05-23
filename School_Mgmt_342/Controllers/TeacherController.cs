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
    public class TeacherController : Controller
    {
        ITeacher NewObj;
        ICSCDropdown DropdownObj;

        public TeacherController(ITeacher Obj , ICSCDropdown Obj2)
        {
            NewObj = Obj;
            DropdownObj = Obj2;
        }

        // GET: Teacher
        public ActionResult AddTeacher()
        {
            try
            {
                ViewBag.CountryList = new SelectList(GetCountryList(), "Id", "CountryName");
                ViewBag.SubjectList = new SelectList(GetSubjectList(), "Id", "SubjectName");
                return View();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        [HttpPost]
        public ActionResult AddTeacher(TeacherModel TeacherData, FormCollection collection)
        {
            try
            {
                string SubjectID = collection["Subject"];
                TeacherData.Subject = SubjectID;
                NewObj.AddTeacher(TeacherData);
                return View();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public ActionResult GetTeachers()
        {
            try
            {
                return View(NewObj.GetTeacherTable());
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

        public List<SubjectDetail> GetSubjectList()
        {
            try
            {
                List<SubjectDetail> GetSubject = NewObj.SubjectDropdown().ToList();
                return GetSubject;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred in GetCountryList", ex);
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

        public ActionResult DelTeacher(int id)
        {
            try
            {
                NewObj.DelTeacherInDb(id);
                return View();
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public ActionResult EditTeacher(int id)
        {
            try
            {
                ViewBag.CountryList = new SelectList(GetCountryList(), "Id", "CountryName");
                ViewBag.SubjectList = new SelectList(GetSubjectList(), "Id", "SubjectName");
                return View(NewObj.EditTeacherInDb(id));
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult EditTeacher(int Id, TeacherModel model, FormCollection collection)
        {
            try
            {
                string SubjectID = collection["Subject"];
                model.Subject = SubjectID;
                NewObj.UpdateData(Id, model);
                return RedirectToAction("GetTeachers");
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}