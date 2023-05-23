using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Mgmt_342.Controllers
{
    public class StepperController : Controller
    {
        // GET: Stepper
        public ActionResult StepperForm()
        {
            return View();
        }

        public ActionResult CustomStepper()
        {
            return View();
        }
    }
}