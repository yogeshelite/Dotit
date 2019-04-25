using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FscontHd
    {
        public string Company { get; set; }
        public int ContractNum { get; set; }
        public string ContractType { get; set; }
        public int CustNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public DateTime? EntryDate { get; set; }
        public string ContractCode { get; set; }
        public string ContractComment { get; set; }
        public string InvoiceComment { get; set; }
        public int PrcConNum { get; set; }
        public string ShipToNum { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool LockRate { get; set; }
        public string EntryPerson { get; set; }
        public bool ContVoid { get; set; }
        public int ShpConNum { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int Duration { get; set; }
        public string Modifier { get; set; }
        public bool Material { get; set; }
        public bool Labor { get; set; }
        public bool Misc { get; set; }
        public bool Invoiced { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public bool OnSite { get; set; }
        public bool RecurringInv { get; set; }
        public string RecurringFreq { get; set; }
        public string PricePer { get; set; }
        public bool LastInvGen { get; set; }
        public int InvoiceNum { get; set; }
        public string TaxCatId { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
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
        public bool DeferredRev { get; set; }
        public string Racode { get; set; }
        public DateTime? DefRevStart { get; set; }
        public bool Suspended { get; set; }
        public bool QuotedContract { get; set; }
        public bool ShipContract { get; set; }
        public string TaskSetId { get; set; }
        public bool ReadyToInvoice { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public bool QuoteAccepted { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string InvcTiming { get; set; }
        public string FiscalCalendarId { get; set; }
        public bool Renewable { get; set; }
        public bool IncIntrastat { get; set; }
        public bool SendToFsa { get; set; }
    }
}
