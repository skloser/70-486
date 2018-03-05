using Exam70_486.Data;
using Exam70_486.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam70_486.Controllers
{
    [DebugLoggerFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new PhotoSharingContext();

            var a = context.Photos.ToList();

            return View();
        }

        [AuthorizeMyWaytFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [NoExceptionFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            try
            {
                throw new NullReferenceException();
            }
            catch (Exception)
            {

            }
            return View();
        }
    }
}