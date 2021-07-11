using CRBC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CRBC
{
    public class TermsAndConditionsController : Controller
    {
        public ActionResult Index()
        {
            PageContent pgps = new PageContent
            {
                Title = "Temrs and Conditions - Calvary Road Baptist Church",
                Header = "Web Site Terms and Conditions of Use",
            };
            return View(pgps);
        }
    }
}
