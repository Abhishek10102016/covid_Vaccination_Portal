using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindRuby.Cowin.Entities1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(mmbersDetailMetaData))]
    public partial class MmbersDetail
    {
        

        class mmbersDetailMetaData
        {
            public int MemberID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Aadhar { get; set; }
            public bool Dose1Status { get; set; }
            public bool Dose2Status { get; set; }
            public bool Gender { get; set; }
            public System.DateTime DOB { get; set; }

        }
        
    }
}
