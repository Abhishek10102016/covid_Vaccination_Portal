using MindRuby.Cowin.Business1.classes;
using MindRuby.Cowin.Entities1.ViewModel;
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
        
        public ActionResult Index(int memberId)
        {
            var listOfCentre = new VaccineCentreDetails();
            //{

            //};
            var res = listOfCentre.Details(memberId);
            return View(res);
        }
        public ActionResult BookSlot(int memberID,int centreID, bool dose1Status, bool dose2Status) 
        {
            var doseBooking = new VaccineCentreDetails();
            doseBooking.BookSlot(memberID, centreID, dose1Status, dose2Status);
            return RedirectToAction("Index","FamilyList");
        }
        
    }
}