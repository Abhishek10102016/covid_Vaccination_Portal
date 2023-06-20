using MindRuby.Cowin.Entities1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindRuby.Cowin.Business1.classes
{
    public class Member
    {
        public Learn_DBEntities _context;
        public Member()
        {
            _context = new Learn_DBEntities();
        }
        public void SaveMember(MmbersDetail mmbersDetail)
        {
            mmbersDetail.Dose1Status = false;
            mmbersDetail.Dose2Status = false;
            _context.MmbersDetails.Add(mmbersDetail);
            _context.SaveChanges();
        }
        
    }
}
