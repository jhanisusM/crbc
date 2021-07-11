using CRBC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CRBC
{
    public class ContactController : Controller
    {
        public ActionResult ContactIndex()
        {
            PageContent pageContent = new PageContent
            {
                Title = "Administrator Login - Calvary Road Baptist Church",
                Header = "Administrator Login",
            };
            return View(pageContent);
        }
    }
}
