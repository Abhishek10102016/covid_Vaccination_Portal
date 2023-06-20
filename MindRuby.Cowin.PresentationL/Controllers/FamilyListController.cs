using MindRuby.Cowin.Business1.classes;
using MindRuby.Cowin.Entities1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace MindRuby.Cowin.PresentationL.Controllers
{
    public class FamilyListController : Controller
    {
        // GET: FamilyList
        public ActionResult Index()
        {
            var id = Convert.ToString(User.Identity.GetUserId());
            var familyList = new FamilyList();
            var res = familyList.callingMemberDetails(id);
            
            return View(res);
        }

    }
}