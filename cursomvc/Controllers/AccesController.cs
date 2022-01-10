using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cursomvc.Controllers
{
    public class AccesController : Controller
    {
        // GET: Acces
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                return Content("1");   
            }
            catch (Exception ex)
            {
                return Content("Ocurrió un error :( " + ex.Message);
            }
        }
    }
}