using MindRuby.Cowin.Business1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MindRuby.Cowin.PresentationL.Controllers
{
    public class VaccineCentreController : Controller
    {
        // GET: VaccineCentre
        public ActionResult Index()
        {
            var listOfCentre = new VaccineCentreDetails()
            {

            };
            var res = listOfCentre.Details();
            return View(res);
        }
        
    }
}