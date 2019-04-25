using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Plant
    {
        public string Company { get; set; }
        public string Plant1 { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int CountryNum { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string CommentText { get; set; }
        public int PlanningExceptionDays { get; set; }
        public string Isregion { get; set; }
        public string PlantCostId { get; set; }
        public int PrepTime { get; set; }
        public int KitTime { get; set; }
        public bool ReqTransferHeader { get; set; }
        public string CalendarId { get; set; }
        public string AllowShipAction { get; set; }
        public int AutoConfirmWindow { get; set; }
        public bool SingleLineOrder { get; set; }
        public int MaxOpStartDelay { get; set; }
        public int MaxOpLength { get; set; }
        public string DefStationId { get; set; }
        public int FiniteHorz { get; set; }
        public string NextUnfirmJob { get; set; }
        public string NextUnfirmTfline { get; set; }
        public bool AddlHdlgFlag { get; set; }
        public int RcutHorz { get; set; }
        public bool IncLeadTime { get; set; }
        public bool IncTransLeadTime { get; set; }
        public bool IncReceiveTime { get; set; }
        public bool IncKitTime { get; set; }
        public bool IncRcparams { get; set; }
        public int OverloadHorz { get; set; }
        public string SchedulingSendAhead { get; set; }
        public int UnfirmSeriesHorizon { get; set; }
        public int AutoFirmHorizon { get; set; }
        public string ManagerName { get; set; }
        public string BranchId { get; set; }
        public string MaintPlant { get; set; }
        public string SiteCode { get; set; }
        public string SiteDesc1 { get; set; }
        public string SiteDesc2 { get; set; }
        public string SiteType { get; set; }
        public string BusinessTypeCode { get; set; }
        public string BusTypeDesc1 { get; set; }
        public string BusTypeDesc2 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string AgdefaultInvoicingPoint { get; set; }
        public bool ForceSstime { get; set; }
        public bool ForceFftime { get; set; }
        public bool UseLeadTimeDos { get; set; }
        public bool AllowMinQty { get; set; }
        public bool IgnoreMtlConstraints { get; set; }
        public string AgprovinceCode { get; set; }
        public string AglocationCode { get; set; }
        public string Agneighborhood { get; set; }
        public string Agstreet { get; set; }
        public string AgstreetNumber { get; set; }
        public string AgextraStreetNumber { get; set; }
        public string Agfloor { get; set; }
        public string Agapartment { get; set; }
        public string Mxmunicipio { get; set; }
        public int MaxLateDaysPorel { get; set; }
        public string Ineccnumber { get; set; }
        public string InexciseRange { get; set; }
        public string InexciseDivision { get; set; }
        public string InexCommissionRate { get; set; }
        public string Intinnumber { get; set; }
        public string Incstnumber { get; set; }
        public string Instregistration { get; set; }
        public bool UseSchedulingMultiJob { get; set; }
        public bool AutoLoadChildJobs { get; set; }
        public bool AutoLoadParentJobs { get; set; }
        public bool MinimizeWip { get; set; }
        public string TimeZoneId { get; set; }
        public bool TimeZoneAdjustForDst { get; set; }
        public bool SyncReqBy { get; set; }
        public int Acwpercentage { get; set; }
        public int BwschedStartTime { get; set; }
        public string IntaxRegistrationId { get; set; }
        public bool SendToFsa { get; set; }
        public string SchedulingDirection { get; set; }
    }
}
