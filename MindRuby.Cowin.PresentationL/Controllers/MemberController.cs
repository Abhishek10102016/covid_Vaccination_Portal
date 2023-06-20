using Microsoft.AspNet.Identity;
using MindRuby.Cowin.Business1.classes;
using MindRuby.Cowin.Entities1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MindRuby.Cowin.PresentationL.Controllers
{
    public class MemberController : Controller
    {
        // GET: AddMember
        public ActionResult AddMember()
        {
            
            return View();
        }
        public ActionResult Save(MmbersDetail mmbersDetail)
        {
            if(!ModelState.IsValid)
            {
                return View("AddMember");
            }
            var id = Convert.ToString(User.Identity.GetUserId());
            mmbersDetail.FamilyID= id;
            var memberDetail = new Member();
            memberDetail.SaveMember(mmbersDetail);

            return RedirectToAction("Index","FamilyList");
        }
    }
}