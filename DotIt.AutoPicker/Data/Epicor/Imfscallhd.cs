using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imfscallhd
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int CallNum { get; set; }
        public int CustNum { get; set; }
        public int PrcConNum { get; set; }
        public string ShipToNum { get; set; }
        public int ShpConNum { get; set; }
        public DateTime? EntryDate { get; set; }
        public int EntryTime { get; set; }
        public DateTime? RequestDate { get; set; }
        public int RequestTime { get; set; }
        public DateTime? SchedDate { get; set; }
        public int SchedTime { get; set; }
        public DateTime? ActualDate { get; set; }
        public int ActualTime { get; set; }
        public string CallComment { get; set; }
        public string InvoiceComment { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool OpenCall { get; set; }
        public bool ReadyToInvoice { get; set; }
        public bool Invoiced { get; set; }
        public bool VoidCall { get; set; }
        public string CallPriority { get; set; }
        public string EntryPerson { get; set; }
        public string CallCode { get; set; }
        public string TaxCatId { get; set; }
        public bool LaborComplete { get; set; }
        public bool MaterialComplete { get; set; }
        public string Plant { get; set; }
        public decimal Duration { get; set; }
        public string ClcallNum { get; set; }
        public int HdcaseNum { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool AutoPrintReady { get; set; }
        public string RateGrpCode { get; set; }
        public int BtcustNum { get; set; }
        public bool UseOts { get; set; }
        public string Otsname { get; set; }
        public string Otsaddress1 { get; set; }
        public string Otsaddress2 { get; set; }
        public string Otsaddress3 { get; set; }
        public string Otscity { get; set; }
        public string Otsstate { get; set; }
        public string Otszip { get; set; }
        public string OtsresaleId { get; set; }
        public string OtstaxRegionCode { get; set; }
        public string Otscontact { get; set; }
        public string OtsfaxNum { get; set; }
        public string OtsphoneNum { get; set; }
        public int OtscountryNum { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Ponum { get; set; }
    }
}
