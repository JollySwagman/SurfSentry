using System;
using Microsoft.AspNetCore.Mvc;

namespace SurfSentry.Web.Controllers
{
    public class SentryController : Controller
    {
        //// GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        //
        // GET: /HelloWorld/Welcome/

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}