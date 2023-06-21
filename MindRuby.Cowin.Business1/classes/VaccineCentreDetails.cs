using MindRuby.Cowin.Entities1;
using MindRuby.Cowin.Entities1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindRuby.Cowin.Business1.classes
{
    public class VaccineCentreDetails
    {
        public Learn_DBEntities _context;
        public VaccineCentreDetails() 
        {
            _context = new Learn_DBEntities();
        }
        public MemberAndCentre Details(int memberId)
        {
            var memberDetail = _context.MmbersDetails.Where(c => c.MemberID == memberId).ToList();
            var centreDetail = _context.CentreDetails.ToList();
            var memberAndCentres = new MemberAndCentre
            {
                memberDetail = memberDetail,
                centreDetail = centreDetail
            };
//            var resultList = new List<MemberAndCentre>();
  //          resultList.Add(memberAndCentres);
            return memberAndCentres;
        }
        public void BookSlot(int memberID,int centreID, bool dose1Satus, bool dose2Satus)
        {
           var centre = _context.CentreDetails.Single(c=>c.CentreID==centreID);
            var member = _context.MmbersDetails.Single(c=>c.MemberID==memberID);
            if (dose2Satus == false && dose1Satus == true)
            {
                member.Dose2Status = true;
            }
            if (dose1Satus==false)
            {
                member.Dose1Status = true;
            }
            centre.AvailableVaccine = centre.AvailableVaccine - 1;
            _context.SaveChanges();
            
        }
    }
}
