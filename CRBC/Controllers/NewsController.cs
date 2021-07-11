using CRBC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CRBC
{
    public class NewsController : Controller
    {
        public ActionResult NewsIndex()
        {
            PageContent pgps = new PageContent
            {
                Title = "News - Calvary Road Baptist Church",
                Header = "",
            };
            return View(pgps);
        }
    }
}
