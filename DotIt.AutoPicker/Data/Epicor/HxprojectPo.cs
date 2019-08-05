using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class HxprojectPo
    {
        public int Revision { get; set; }
        public int AssemblySeq { get; set; }
        public decimal BaseQty { get; set; }
        public string BaseUom { get; set; }
        public int BtoorderLine { get; set; }
        public int BtoorderNum { get; set; }
        public int BtoorderRelNum { get; set; }
        public string Company { get; set; }
        public string ComplianceMsg { get; set; }
        public bool Confirmed { get; set; }
        public string ConfirmVia { get; set; }
        public int ContainerId { get; set; }
        public bool DropShip { get; set; }
        public DateTime? DueDate { get; set; }
        public bool ExpOverride { get; set; }
        public string ExtCompany { get; set; }
        public string GlbCompany { get; set; }
        public bool GlbCreateJobMtl { get; set; }
        public string GlbPlant { get; set; }
        public string GlbWarehouse { get; set; }
        public string JobNum { get; set; }
        public int JobSeq { get; set; }
        public string JobSeqType { get; set; }
        public bool Linked { get; set; }
        public string LockRel { get; set; }
        public int MangCustNum { get; set; }
        public bool OpenRelease { get; set; }
        public int OrderLine { get; set; }
        public int OrderNum { get; set; }
        public int OrderRelNum { get; set; }
        public string Otsaddress1 { get; set; }
        public string Otsaddress2 { get; set; }
        public string Otsaddress3 { get; set; }
        public string Otscity { get; set; }
        public string Otscontact { get; set; }
        public int OtscountryNum { get; set; }
        public string OtsfaxNum { get; set; }
        public string Otsname { get; set; }
        public string OtsphoneNum { get; set; }
        public string OtsresaleId { get; set; }
        public string Otsstate { get; set; }
        public string Otszip { get; set; }
        public string Plant { get; set; }
        public int Poline { get; set; }
        public int Ponum { get; set; }
        public int PorelNum { get; set; }
        public DateTime? PreviousDueDate { get; set; }
        public string ProjectId { get; set; }
        public DateTime? PromiseDt { get; set; }
        public decimal PurchasingFactor { get; set; }
        public string PurchasingFactorDirection { get; set; }
        public decimal ReceivedQty { get; set; }
        public string RefCode { get; set; }
        public string RefCodeDesc { get; set; }
        public string RefDisplayAccount { get; set; }
        public string RefType { get; set; }
        public decimal RelQty { get; set; }
        public DateTime? ReqChgDate { get; set; }
        public decimal ReqChgQty { get; set; }
        public int ReqLine { get; set; }
        public int ReqNum { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal ShippedQty { get; set; }
        public int ShipToCustNum { get; set; }
        public string ShipToNum { get; set; }
        public int ShpConNum { get; set; }
        public decimal SmircvdQty { get; set; }
        public int SoldToNum { get; set; }
        public string TranType { get; set; }
        public bool UseOts { get; set; }
        public bool VoidRelease { get; set; }
        public string WarehouseCode { get; set; }
        public decimal XrelQty { get; set; }
        public bool PorelOpen { get; set; }
        public bool Mapping { get; set; }
        public string PhaseId { get; set; }
        public string WbsphaseId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
