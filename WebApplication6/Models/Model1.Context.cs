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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ITEntities : DbContext
    {
        public ITEntities()
            : base("name=ITEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CharacteristicsTI> CharacteristicsTI { get; set; }
        public virtual DbSet<DiagnosticMap> DiagnosticMap { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<ResultsTI> ResultsTI { get; set; }
        public virtual DbSet<TrafficPoliceOfficer> TrafficPoliceOfficer { get; set; }
    
        public virtual int CharacteristicsTIInsert(Nullable<bool> brakeSystems, Nullable<bool> steering, Nullable<bool> lightDevices, Nullable<bool> windscreenWipers, Nullable<bool> tiresAndWheels, Nullable<bool> engine, Nullable<bool> structuralElements, Nullable<bool> safetyRequirements)
        {
            var brakeSystemsParameter = brakeSystems.HasValue ?
                new ObjectParameter("brakeSystems", brakeSystems) :
                new ObjectParameter("brakeSystems", typeof(bool));
    
            var steeringParameter = steering.HasValue ?
                new ObjectParameter("steering", steering) :
                new ObjectParameter("steering", typeof(bool));
    
            var lightDevicesParameter = lightDevices.HasValue ?
                new ObjectParameter("lightDevices", lightDevices) :
                new ObjectParameter("lightDevices", typeof(bool));
    
            var windscreenWipersParameter = windscreenWipers.HasValue ?
                new ObjectParameter("windscreenWipers", windscreenWipers) :
                new ObjectParameter("windscreenWipers", typeof(bool));
    
            var tiresAndWheelsParameter = tiresAndWheels.HasValue ?
                new ObjectParameter("tiresAndWheels", tiresAndWheels) :
                new ObjectParameter("tiresAndWheels", typeof(bool));
    
            var engineParameter = engine.HasValue ?
                new ObjectParameter("engine", engine) :
                new ObjectParameter("engine", typeof(bool));
    
            var structuralElementsParameter = structuralElements.HasValue ?
                new ObjectParameter("structuralElements", structuralElements) :
                new ObjectParameter("structuralElements", typeof(bool));
    
            var safetyRequirementsParameter = safetyRequirements.HasValue ?
                new ObjectParameter("safetyRequirements", safetyRequirements) :
                new ObjectParameter("safetyRequirements", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CharacteristicsTIInsert", brakeSystemsParameter, steeringParameter, lightDevicesParameter, windscreenWipersParameter, tiresAndWheelsParameter, engineParameter, structuralElementsParameter, safetyRequirementsParameter);
        }
    
        public virtual ObjectResult<CharacteristicsTIOutputAll_Result> CharacteristicsTIOutputAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CharacteristicsTIOutputAll_Result>("CharacteristicsTIOutputAll");
        }
    
        public virtual int DiagnosticMapAndDriverInsert(string driverCertificateNumber, string fullName, Nullable<System.DateTime> dateOfBirth, string sex, string adress, string stateCarNumber, string engineNumber, string color, string carModel)
        {
            var driverCertificateNumberParameter = driverCertificateNumber != null ?
                new ObjectParameter("driverCertificateNumber", driverCertificateNumber) :
                new ObjectParameter("driverCertificateNumber", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("fullName", fullName) :
                new ObjectParameter("fullName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("dateOfBirth", dateOfBirth) :
                new ObjectParameter("dateOfBirth", typeof(System.DateTime));
    
            var sexParameter = sex != null ?
                new ObjectParameter("sex", sex) :
                new ObjectParameter("sex", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            var stateCarNumberParameter = stateCarNumber != null ?
                new ObjectParameter("stateCarNumber", stateCarNumber) :
                new ObjectParameter("stateCarNumber", typeof(string));
    
            var engineNumberParameter = engineNumber != null ?
                new ObjectParameter("engineNumber", engineNumber) :
                new ObjectParameter("engineNumber", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var carModelParameter = carModel != null ?
                new ObjectParameter("carModel", carModel) :
                new ObjectParameter("carModel", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiagnosticMapAndDriverInsert", driverCertificateNumberParameter, fullNameParameter, dateOfBirthParameter, sexParameter, adressParameter, stateCarNumberParameter, engineNumberParameter, colorParameter, carModelParameter);
        }
    
        public virtual int DiagnosticMapInsert(Nullable<int> driver_idDriver, string stateCarNumber, string engineNumber, string color, string carModel)
        {
            var driver_idDriverParameter = driver_idDriver.HasValue ?
                new ObjectParameter("Driver_idDriver", driver_idDriver) :
                new ObjectParameter("Driver_idDriver", typeof(int));
    
            var stateCarNumberParameter = stateCarNumber != null ?
                new ObjectParameter("stateCarNumber", stateCarNumber) :
                new ObjectParameter("stateCarNumber", typeof(string));
    
            var engineNumberParameter = engineNumber != null ?
                new ObjectParameter("engineNumber", engineNumber) :
                new ObjectParameter("engineNumber", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("color", color) :
                new ObjectParameter("color", typeof(string));
    
            var carModelParameter = carModel != null ?
                new ObjectParameter("carModel", carModel) :
                new ObjectParameter("carModel", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiagnosticMapInsert", driver_idDriverParameter, stateCarNumberParameter, engineNumberParameter, colorParameter, carModelParameter);
        }
    
        public virtual ObjectResult<DiagnosticMapOutputAll_Result> DiagnosticMapOutputAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiagnosticMapOutputAll_Result>("DiagnosticMapOutputAll");
        }
    
        public virtual ObjectResult<DriverAndDiagnosticMapOutput_Result> DriverAndDiagnosticMapOutput()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DriverAndDiagnosticMapOutput_Result>("DriverAndDiagnosticMapOutput");
        }
    
        public virtual int DriverInsert(string driverCertificateNumber, string fullName, Nullable<System.DateTime> dateOfBirth, string sex, string adress)
        {
            var driverCertificateNumberParameter = driverCertificateNumber != null ?
                new ObjectParameter("driverCertificateNumber", driverCertificateNumber) :
                new ObjectParameter("driverCertificateNumber", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("fullName", fullName) :
                new ObjectParameter("fullName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("dateOfBirth", dateOfBirth) :
                new ObjectParameter("dateOfBirth", typeof(System.DateTime));
    
            var sexParameter = sex != null ?
                new ObjectParameter("sex", sex) :
                new ObjectParameter("sex", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DriverInsert", driverCertificateNumberParameter, fullNameParameter, dateOfBirthParameter, sexParameter, adressParameter);
        }
    
        public virtual ObjectResult<DriverOutputAll_Result> DriverOutputAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DriverOutputAll_Result>("DriverOutputAll");
        }
    
        public virtual int DriverUpdate(Nullable<int> idDriver, string driverCertificateNumber, string fullName, Nullable<System.DateTime> dateOfBirth, string sex, string adress)
        {
            var idDriverParameter = idDriver.HasValue ?
                new ObjectParameter("idDriver", idDriver) :
                new ObjectParameter("idDriver", typeof(int));
    
            var driverCertificateNumberParameter = driverCertificateNumber != null ?
                new ObjectParameter("driverCertificateNumber", driverCertificateNumber) :
                new ObjectParameter("driverCertificateNumber", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("fullName", fullName) :
                new ObjectParameter("fullName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("dateOfBirth", dateOfBirth) :
                new ObjectParameter("dateOfBirth", typeof(System.DateTime));
    
            var sexParameter = sex != null ?
                new ObjectParameter("sex", sex) :
                new ObjectParameter("sex", typeof(string));
    
            var adressParameter = adress != null ?
                new ObjectParameter("adress", adress) :
                new ObjectParameter("adress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DriverUpdate", idDriverParameter, driverCertificateNumberParameter, fullNameParameter, dateOfBirthParameter, sexParameter, adressParameter);
        }
    
        public virtual int ResultsAllInsert(Nullable<int> trafficPoliceOfficer_idTrafficPoliceOfficer, Nullable<int> diagnosticMap_idDiagnosticMap, Nullable<System.DateTime> dateOfPassage, string cityOfMaintenance, string placeOfMaintenance, Nullable<bool> resultOfMaintenance, Nullable<bool> brakeSystems, Nullable<bool> steering, Nullable<bool> lightDevices, Nullable<bool> windscreenWipers, Nullable<bool> tiresAndWheels, Nullable<bool> engine, Nullable<bool> structuralElements, Nullable<bool> safetyRequirements)
        {
            var trafficPoliceOfficer_idTrafficPoliceOfficerParameter = trafficPoliceOfficer_idTrafficPoliceOfficer.HasValue ?
                new ObjectParameter("TrafficPoliceOfficer_idTrafficPoliceOfficer", trafficPoliceOfficer_idTrafficPoliceOfficer) :
                new ObjectParameter("TrafficPoliceOfficer_idTrafficPoliceOfficer", typeof(int));
    
            var diagnosticMap_idDiagnosticMapParameter = diagnosticMap_idDiagnosticMap.HasValue ?
                new ObjectParameter("DiagnosticMap_idDiagnosticMap", diagnosticMap_idDiagnosticMap) :
                new ObjectParameter("DiagnosticMap_idDiagnosticMap", typeof(int));
    
            var dateOfPassageParameter = dateOfPassage.HasValue ?
                new ObjectParameter("dateOfPassage", dateOfPassage) :
                new ObjectParameter("dateOfPassage", typeof(System.DateTime));
    
            var cityOfMaintenanceParameter = cityOfMaintenance != null ?
                new ObjectParameter("cityOfMaintenance", cityOfMaintenance) :
                new ObjectParameter("cityOfMaintenance", typeof(string));
    
            var placeOfMaintenanceParameter = placeOfMaintenance != null ?
                new ObjectParameter("placeOfMaintenance", placeOfMaintenance) :
                new ObjectParameter("placeOfMaintenance", typeof(string));
    
            var resultOfMaintenanceParameter = resultOfMaintenance.HasValue ?
                new ObjectParameter("resultOfMaintenance", resultOfMaintenance) :
                new ObjectParameter("resultOfMaintenance", typeof(bool));
    
            var brakeSystemsParameter = brakeSystems.HasValue ?
                new ObjectParameter("brakeSystems", brakeSystems) :
                new ObjectParameter("brakeSystems", typeof(bool));
    
            var steeringParameter = steering.HasValue ?
                new ObjectParameter("steering", steering) :
                new ObjectParameter("steering", typeof(bool));
    
            var lightDevicesParameter = lightDevices.HasValue ?
                new ObjectParameter("lightDevices", lightDevices) :
                new ObjectParameter("lightDevices", typeof(bool));
    
            var windscreenWipersParameter = windscreenWipers.HasValue ?
                new ObjectParameter("windscreenWipers", windscreenWipers) :
                new ObjectParameter("windscreenWipers", typeof(bool));
    
            var tiresAndWheelsParameter = tiresAndWheels.HasValue ?
                new ObjectParameter("tiresAndWheels", tiresAndWheels) :
                new ObjectParameter("tiresAndWheels", typeof(bool));
    
            var engineParameter = engine.HasValue ?
                new ObjectParameter("engine", engine) :
                new ObjectParameter("engine", typeof(bool));
    
            var structuralElementsParameter = structuralElements.HasValue ?
                new ObjectParameter("structuralElements", structuralElements) :
                new ObjectParameter("structuralElements", typeof(bool));
    
            var safetyRequirementsParameter = safetyRequirements.HasValue ?
                new ObjectParameter("safetyRequirements", safetyRequirements) :
                new ObjectParameter("safetyRequirements", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ResultsAllInsert", trafficPoliceOfficer_idTrafficPoliceOfficerParameter, diagnosticMap_idDiagnosticMapParameter, dateOfPassageParameter, cityOfMaintenanceParameter, placeOfMaintenanceParameter, resultOfMaintenanceParameter, brakeSystemsParameter, steeringParameter, lightDevicesParameter, windscreenWipersParameter, tiresAndWheelsParameter, engineParameter, structuralElementsParameter, safetyRequirementsParameter);
        }
    
        public virtual ObjectResult<ResultsOutputAll_Result> ResultsOutputAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ResultsOutputAll_Result>("ResultsOutputAll");
        }
    
        public virtual int ResultsTIInsert(Nullable<int> trafficPoliceOfficer_idTrafficPoliceOfficer, Nullable<int> diagnosticMap_idDiagnosticMap, Nullable<int> characteristicsTI_idCharacteristicsTI, Nullable<System.DateTime> dateOfPassage, string cityOfMaintenance, string placeOfMaintenance, Nullable<bool> resultOfMaintenance)
        {
            var trafficPoliceOfficer_idTrafficPoliceOfficerParameter = trafficPoliceOfficer_idTrafficPoliceOfficer.HasValue ?
                new ObjectParameter("TrafficPoliceOfficer_idTrafficPoliceOfficer", trafficPoliceOfficer_idTrafficPoliceOfficer) :
                new ObjectParameter("TrafficPoliceOfficer_idTrafficPoliceOfficer", typeof(int));
    
            var diagnosticMap_idDiagnosticMapParameter = diagnosticMap_idDiagnosticMap.HasValue ?
                new ObjectParameter("DiagnosticMap_idDiagnosticMap", diagnosticMap_idDiagnosticMap) :
                new ObjectParameter("DiagnosticMap_idDiagnosticMap", typeof(int));
    
            var characteristicsTI_idCharacteristicsTIParameter = characteristicsTI_idCharacteristicsTI.HasValue ?
                new ObjectParameter("CharacteristicsTI_idCharacteristicsTI", characteristicsTI_idCharacteristicsTI) :
                new ObjectParameter("CharacteristicsTI_idCharacteristicsTI", typeof(int));
    
            var dateOfPassageParameter = dateOfPassage.HasValue ?
                new ObjectParameter("dateOfPassage", dateOfPassage) :
                new ObjectParameter("dateOfPassage", typeof(System.DateTime));
    
            var cityOfMaintenanceParameter = cityOfMaintenance != null ?
                new ObjectParameter("cityOfMaintenance", cityOfMaintenance) :
                new ObjectParameter("cityOfMaintenance", typeof(string));
    
            var placeOfMaintenanceParameter = placeOfMaintenance != null ?
                new ObjectParameter("placeOfMaintenance", placeOfMaintenance) :
                new ObjectParameter("placeOfMaintenance", typeof(string));
    
            var resultOfMaintenanceParameter = resultOfMaintenance.HasValue ?
                new ObjectParameter("resultOfMaintenance", resultOfMaintenance) :
                new ObjectParameter("resultOfMaintenance", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ResultsTIInsert", trafficPoliceOfficer_idTrafficPoliceOfficerParameter, diagnosticMap_idDiagnosticMapParameter, characteristicsTI_idCharacteristicsTIParameter, dateOfPassageParameter, cityOfMaintenanceParameter, placeOfMaintenanceParameter, resultOfMaintenanceParameter);
        }
    
        public virtual ObjectResult<ResultsTIOutputAll_Result> ResultsTIOutputAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ResultsTIOutputAll_Result>("ResultsTIOutputAll");
        }
    
        public virtual int TrafficPoliceOfficerInsert(string passportData, string login, string pasword, string fullName, string rank, string position)
        {
            var passportDataParameter = passportData != null ?
                new ObjectParameter("passportData", passportData) :
                new ObjectParameter("passportData", typeof(string));
    
            var loginParameter = login != null ?
                new ObjectParameter("login", login) :
                new ObjectParameter("login", typeof(string));
    
            var paswordParameter = pasword != null ?
                new ObjectParameter("pasword", pasword) :
                new ObjectParameter("pasword", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("fullName", fullName) :
                new ObjectParameter("fullName", typeof(string));
    
            var rankParameter = rank != null ?
                new ObjectParameter("rank", rank) :
                new ObjectParameter("rank", typeof(string));
    
            var positionParameter = position != null ?
                new ObjectParameter("position", position) :
                new ObjectParameter("position", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TrafficPoliceOfficerInsert", passportDataParameter, loginParameter, paswordParameter, fullNameParameter, rankParameter, positionParameter);
        }
    
        public virtual ObjectResult<TrafficPoliceOfficerOutputAll_Result> TrafficPoliceOfficerOutputAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TrafficPoliceOfficerOutputAll_Result>("TrafficPoliceOfficerOutputAll");
        }
    }
}
