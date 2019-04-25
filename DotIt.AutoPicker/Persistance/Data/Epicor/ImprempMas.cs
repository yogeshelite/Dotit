using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprempMas
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string EmpId { get; set; }
        public string EmpLink { get; set; }
        public string SocSecNum { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string EmgPhone { get; set; }
        public string EmgContact { get; set; }
        public string ClassId { get; set; }
        public int Shift { get; set; }
        public decimal LaborRate { get; set; }
        public string ExpenseCode { get; set; }
        public string Jcdept { get; set; }
        public DateTime? HireDate { get; set; }
        public bool Terminated { get; set; }
        public DateTime? TerminatedDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PayType { get; set; }
        public string PayFrequency { get; set; }
        public bool Pension { get; set; }
        public bool DeferredComp { get; set; }
        public string WorkCompCode { get; set; }
        public decimal VacAccrualRate { get; set; }
        public decimal VacRemaining { get; set; }
        public decimal VacHrsMax { get; set; }
        public decimal SickAccrualRate { get; set; }
        public decimal SickRemaining { get; set; }
        public decimal SickHrsMax { get; set; }
        public string Division { get; set; }
        public string Gldept { get; set; }
        public string PhotoFile { get; set; }
        public bool ShopEmployee { get; set; }
        public decimal Otday { get; set; }
        public decimal Otweek { get; set; }
        public string SupervisorId { get; set; }
        public string CommentText { get; set; }
        public int CountryNum { get; set; }
        public bool ServTech { get; set; }
        public string EmailAddress { get; set; }
        public string DcdUserId { get; set; }
        public bool ProductionWorker { get; set; }
        public bool MaterialHandler { get; set; }
        public bool ShopSupervisor { get; set; }
        public bool CanReportQty { get; set; }
        public bool CanOverrideJob { get; set; }
        public bool CanRequestMaterial { get; set; }
        public bool CanReportScrapQty { get; set; }
        public bool CanReportNcqty { get; set; }
        public bool ShipRecv { get; set; }
        public bool ThirdPartySickPay { get; set; }
        public bool RetirePlan { get; set; }
        public string ExternalId { get; set; }
        public string CnvEmpId { get; set; }
        public bool WarehouseManager { get; set; }
        public bool CanOverrideAllocations { get; set; }
        public int PerConId { get; set; }
        public bool SyncNameToPerCon { get; set; }
        public bool SyncAddressToPerCon { get; set; }
        public bool SyncPhoneToPerCon { get; set; }
        public bool SyncEmailToPerCon { get; set; }
        public bool Hcmlinked { get; set; }
        public bool InActive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ImageId { get; set; }
    }
}
