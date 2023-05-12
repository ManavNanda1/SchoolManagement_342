using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Repository.Repository;

namespace School_Mgmt_342.Controllers
{
    public class CountryController : Controller
    {
        ICountryRepo newobj;

        public CountryController(ICountryRepo obj)
        {

            newobj = obj;
        }
        // GET: Country
        public ActionResult AddCountry()
        {
            try
            {
                return View();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        [HttpPost]
        public ActionResult AddCountry(CountryModel CountryData)
        {
            try
            {
                newobj.AddCountryInDb(CountryData);
                return View();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public ActionResult GetCountry()
        {
            try
            {
                
                return View(newobj.GetCountryTable());
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public ActionResult Delete(int id)

        {
            try
            {
                var Status = newobj.DelCountryInDb(id); 
                if(Status == 1)
                {
                    ViewBag.success = "Country Deleted Successfully";
                    return View();
                }
                else if(Status == -1)
                {
                    ViewBag.error = "Country used";
                    return View();

                }
                return View();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult EditCountry(int id)
        {
            try
            {
                return View(newobj.EditCountryInDb(id));
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult EditCountry(int CountryID, CountryModel model)
        {
            try
            {
                newobj.UpdateData(CountryID, model);
                return RedirectToAction("GetCountry");
            }
            catch(Exception E)
            {
                    throw E;
            }
        }
    }
}