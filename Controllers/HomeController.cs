using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;
namespace dome.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QueryAll(int pageindex, int pagesize) {
            return Json(StudentManager.QueryAll(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }
        public int GetCount()
        {
            return StudentManager.GetCount();
        }

    }
}