using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Fsrenewal
    {
        public string Company { get; set; }
        public int ContractNum { get; set; }
        public int RenewalNbr { get; set; }
        public bool QuotedRenewal { get; set; }
        public string TaskSetId { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public bool QuoteAccepted { get; set; }
        public string RenewalCode { get; set; }
        public bool ShipRenewal { get; set; }
        public string Racode { get; set; }
        public bool DeferredRev { get; set; }
        public DateTime? DefRevStart { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool LockRate { get; set; }
        public string EntryPerson { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool Material { get; set; }
        public bool Labor { get; set; }
        public bool Misc { get; set; }
        public bool OnSite { get; set; }
        public bool Invoiced { get; set; }
        public int InvoiceNum { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public bool RecurringInv { get; set; }
        public string RecurringFreq { get; set; }
        public string PricePer { get; set; }
        public bool LastInvGen { get; set; }
        public string TaxCatId { get; set; }
        public string RateGrpCode { get; set; }
        public bool ReadyToInvoice { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int Duration { get; set; }
        public string RenewalComment { get; set; }
        public DateTime? RenewEffDate { get; set; }
        public DateTime? RenewedUntil { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string InvcTiming { get; set; }
        public string ContractCode { get; set; }
        public string Modifier { get; set; }
        public string FiscalCalendarId { get; set; }
        public bool Renewable { get; set; }
    }
}
