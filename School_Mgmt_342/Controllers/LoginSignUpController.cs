using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Mgmt_342.Controllers
{
    public class LoginSignUpController : Controller
    {
        // GET: LoginSignUp

        IuserRepo newobj;

        public LoginSignUpController(IuserRepo obj)
        {
            newobj = obj;
        }
        public ActionResult LoginPage()
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
        public ActionResult LoginPage(LoginModel LoginData)
        {
            try
            {

                if (newobj.LoginDataCheck(LoginData) == 1)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.message = "Invalid Credentials";
                    return View();
                }
                
                
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


        public ActionResult SignUpPage()
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
        public ActionResult SignUpPage(RegisterModel RegisterData)
        {
            try
            {
                newobj.AddUserInData(RegisterData);
                
                return RedirectToAction("LoginPage");

            }
            catch(Exception E)
            {
                throw E;
            }
           
        }
    }
}