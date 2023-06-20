using MindRuby.Cowin.Entities1;
using System.Collections.Generic;
using System.Linq;

namespace MindRuby.Cowin.Business1.classes
{
    public class FamilyList
    {
        public Learn_DBEntities _context;
        public FamilyList()
        {
            _context = new Learn_DBEntities();
        }
        public List<MmbersDetail> callingMemberDetails(string id)
        {
            return _context.MmbersDetails.Where(c=>c.FamilyID== id).ToList();
        }

    }
}
