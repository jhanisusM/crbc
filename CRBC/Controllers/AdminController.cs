using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRBC.Model;
using System.Web.Mvc;

namespace CRBC
{
    public class AdminController : Controller
    {
        public ActionResult LogInPortal()
        {
            PageContent pgps = new PageContent
            {
                Title = "Administration - Calvary Road Baptist Church",
                Header = "",
            };
            return View(pgps);
        }
    }
}
