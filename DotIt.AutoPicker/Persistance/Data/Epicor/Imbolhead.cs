using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imbolhead
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Bolnum { get; set; }
        public string Boltype { get; set; }
        public DateTime? ShipDate { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string Carrier { get; set; }
        public string ShipperNum { get; set; }
        public string ProNumber { get; set; }
        public string FreightCharges { get; set; }
        public decimal Codamount { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string CommentText { get; set; }
        public string Plant { get; set; }
        public string EntryPerson { get; set; }
        public string ToPlant { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool AutoPrintReady { get; set; }
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
        public bool Ediready { get; set; }
        public int CounterAsn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
