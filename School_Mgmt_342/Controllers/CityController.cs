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
    public class CityController : Controller
    {
 
        ICity NewObj;

        public CityController (ICity obj)
        {
            NewObj = obj;
        }
        public ActionResult GetCity()
        {
            try
            {
            return View(NewObj.GetCity());
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public ActionResult AddCity()
        {
            try
            {
                ViewBag.CountryList = new SelectList(GetCountries(), "Id", "CountryName");
                return View();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        [HttpPost]
        public ActionResult AddCity(CityModel CityData)
        {
            try
            {
                NewObj.AddCity(CityData);
                return View();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public List<Country> GetCountries()
        {
            try
            {
                List<Country> getCountry = NewObj.CountryDropDown().ToList();
                return getCountry;
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
                List<State> selectList = NewObj.StateDropDown(CountryId).ToList();
                ViewBag.StateList = new SelectList(selectList, "Id", "StateName");
                return PartialView("DisplayState");
            }
            catch (Exception ex)
            {

                return View("Error", ex);
            }
        }

        public ActionResult DelCity(int id)
        {
            try
            {
                NewObj.DelCityInDb(id);
                return View();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult EditCity(int id)
        {
            try
            {
                ViewBag.CountryList = new SelectList(GetCountries(), "Id", "CountryName");
                return View(NewObj.EditCityInDb(id));
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult EditCity(int CityId, CityModel model)
        {
            try
            {
                NewObj.UpdateData(CityId, model);
                return RedirectToAction("GetCity");
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}