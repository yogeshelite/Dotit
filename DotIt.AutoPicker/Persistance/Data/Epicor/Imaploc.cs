using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imaploc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Lcid { get; set; }
        public string BankAcctId { get; set; }
        public int VendorNum { get; set; }
        public decimal Lcvalue { get; set; }
        public decimal Rpt1Lcvalue { get; set; }
        public decimal Rpt2Lcvalue { get; set; }
        public decimal Rpt3Lcvalue { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool RateLocked { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Description { get; set; }
        public int BtcustNum { get; set; }
        public string TermsCode { get; set; }
        public bool ShipComplete { get; set; }
        public bool Inactive { get; set; }
        public string InactiveReason { get; set; }
        public bool Closed { get; set; }
        public string Fob { get; set; }
        public string IssuanceType { get; set; }
        public string PackListCopies { get; set; }
        public string PlaceOfLoading { get; set; }
        public string Comment { get; set; }
        public string RateGrpCode { get; set; }
        public decimal DocLcvalue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
