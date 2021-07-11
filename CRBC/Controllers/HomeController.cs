using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRBC.Model;

namespace CRBC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             PageContent pageContent = new PageContent
            {
                Title = "Calvary Road Baptist Church",
            };
            return View(pageContent);
        }
    }
}
