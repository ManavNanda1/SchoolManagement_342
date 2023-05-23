using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Mgmt_342.Controllers
{
    public class HomeController : Controller
    {
        ICountDashboard NewObj;

        public HomeController(ICountDashboard obj)
        {
            NewObj = obj;
        }
        public ActionResult Index()
        {
            try
            {
                ViewBag.Total = NewObj.GetTotalStudents();
                ViewBag.TotalSub = NewObj.GetTotalSubjets();
                ViewBag.TotalTeacher = NewObj.GetTotalTeachers();
                return View();
            }
            catch(Exception E)
            {
                throw E;
            }
          
        }

        public ActionResult About()
        {
            try
            {
                ViewBag.Message = "Your application description page.";
                return View();
            }
            catch(Exception E)
            {
                throw E;
            }
           
        }

        public ActionResult Contact()
        {try
            {
                ViewBag.Message = "Your contact page.";
                return View();
            }
            catch (Exception E) { 
                throw E; 
            }
        }
    }
}