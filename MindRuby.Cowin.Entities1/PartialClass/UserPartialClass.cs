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

    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        
        class UserMetaData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Aadhar { get; set; }
            public bool Dose1Status { get; set; }
            public bool Dose2Status { get; set; }
            public bool Gender { get; set; }
            public System.DateTime DOB { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<MmbersDetail> MmbersDetails { get; set; }
        }
        
    }
}
