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
    
    public partial class ResultsTI
    {
        public int idResultsTI { get; set; }
        public int TrafficPoliceOfficer_idTrafficPoliceOfficer { get; set; }
        public int DiagnosticMap_idDiagnosticMap { get; set; }
        public int CharacteristicsTI_idCharacteristicsTI { get; set; }
        public System.DateTime dateOfPassage { get; set; }
        public string cityOfMaintenance { get; set; }
        public string placeOfMaintenance { get; set; }
        public bool resultOfMaintenance { get; set; }
    
        public virtual CharacteristicsTI CharacteristicsTI { get; set; }
        public virtual TrafficPoliceOfficer TrafficPoliceOfficer { get; set; }
    }
}
