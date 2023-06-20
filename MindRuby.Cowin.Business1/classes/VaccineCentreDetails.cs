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
        public List<CentreDetail> Details()
        {
            var memberAndCentre = new MemberAndCentre()
            {
                
            };
            return _context.CentreDetails.ToList(); 
        }
    }
}
