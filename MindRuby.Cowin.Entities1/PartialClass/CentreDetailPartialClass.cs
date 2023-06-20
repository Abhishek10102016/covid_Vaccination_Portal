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

    [MetadataType(typeof(CentreDetailMetaData))]
    public partial class CentreDetail
    {
        class CentreDetailMetaData
        {
            public int CentreID { get; set; }
            public string CentreName { get; set; }
            public int Pincode { get; set; }
            public string VaccineName { get; set; }
            public int cost { get; set; }
            public int AvailableVaccine { get; set; }
        }
        
    }
}