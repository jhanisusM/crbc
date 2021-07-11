using CRBC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CRBC
{
    public class SermonsController : Controller
    {
        public ActionResult SermonsIndex()
        {
            PageContent pgps = new PageContent
            {
                Title = "Sermons - Calvary Road Baptist Church",
                Header = "Sermons",
            };
            return View(pgps);
        }
    }
}
