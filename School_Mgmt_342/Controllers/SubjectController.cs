using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Mgmt_342.Controllers
{
    public class SubjectController : Controller
    {
        ISubject NewObj;
        public SubjectController(ISubject obj)
        {
            NewObj = obj;
        }
        public ActionResult AddSubject()
        {
            try
            {
               
            return View();

            }
            catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult AddSubject(SubjectModel SubjectData)
        {
            try
            {
                NewObj.AddSubjectData(SubjectData);
                return View();

            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public ActionResult AllSubjects ()
        {
            try
            {
                return View(NewObj.GetSubjectTable());
            }
            catch (Exception E)
            {
                throw E;
            }
         }
     
        public ActionResult DelSubject(int id)
        {
            try
            {
                NewObj.DelSubjectInDb(id);
                return View();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult EditSubject(int id)
        {
            try
            {
                return View(NewObj.EditSubjectInDb(id));
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult EditSubject(int SubjectId, SubjectModel model)
        {
            try
            {
                NewObj.UpdateData(SubjectId, model);
                return RedirectToAction("AllSubjects");
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}