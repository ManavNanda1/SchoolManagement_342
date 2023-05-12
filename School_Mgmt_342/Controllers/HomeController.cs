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
            ViewBag.Total = NewObj.GetTotalStudents();
            ViewBag.TotalSub = NewObj.GetTotalSubjets();
            ViewBag.TotalTeacher = NewObj.GetTotalTeachers();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}