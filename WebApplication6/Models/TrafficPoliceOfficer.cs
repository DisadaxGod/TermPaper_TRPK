//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrafficPoliceOfficer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrafficPoliceOfficer()
        {
            this.ResultsTI = new HashSet<ResultsTI>();
        }
    
        public int idTrafficPoliceOfficer { get; set; }
        public string passportData { get; set; }
        public string login { get; set; }
        public string pasword { get; set; }
        public string fullName { get; set; }
        public string rank { get; set; }
        public string position { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultsTI> ResultsTI { get; set; }
    }
}
