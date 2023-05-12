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
    public class StateController : Controller
    {
        IStateRepo newObj;

        public  StateController(IStateRepo obj)
        {
            newObj = obj;
        }

        public ActionResult AddState()
        {
            try
            {
                ViewBag.CountryList = new SelectList(GetCountryList(), "Id", "CountryName");
                return View();

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        [HttpPost]
        public ActionResult AddState(StateModel StateData)
        {
            try
            {
                newObj.AddStateInDb(StateData);
                return View();

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public ActionResult GetState()
        {
            try
            {
                return View(newObj.GetStateTable());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Country> GetCountryList()
        {
            try
            {
                List<Country> GetCountry = newObj.CountryDropDown().ToList();
                return GetCountry;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred in GetCountryList", ex);
            }
        }

        public ActionResult DelState(int id)
        {
            try
            {
                newObj.DelStateInDb(id);
                return View();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult EditState(int id)
        {
            try
            {
                ViewBag.CountryList = new SelectList(GetCountryList(), "Id", "CountryName");
                return View(newObj.EditStateInDb(id));
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult EditState(int StateId, StateModel model)
        {
            try
            {
                newObj.UpdateData(StateId, model);
                return RedirectToAction("GetState");
            }
            catch (Exception E)
            {
                throw E;
            }
        }

    }
}