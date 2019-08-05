using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImdemandContractHdr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int DemandContractNum { get; set; }
        public int CustNum { get; set; }
        public string DemandContract { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int FirmDays { get; set; }
        public string TradingPartnerName { get; set; }
        public string Cummsetting { get; set; }
        public string Fob { get; set; }
        public string ShipViaCode { get; set; }
        public string TermsCode { get; set; }
        public string CurrencyCode { get; set; }
        public bool LockRate { get; set; }
        public string AllocPriorityCode { get; set; }
        public string ReservePriorityCode { get; set; }
        public bool ShipOrderComplete { get; set; }
        public string ContractComments { get; set; }
        public DateTime? ContractDate { get; set; }
        public string ProjectId { get; set; }
        public bool OpenContract { get; set; }
        public string EntryPerson { get; set; }
        public bool AutoOrderBasedDisc { get; set; }
        public int BtcustNum { get; set; }
        public decimal TotalInvoiceAmt { get; set; }
        public decimal TotalOrderAmt { get; set; }
        public bool MatchByRef { get; set; }
        public bool MatchByReqDate { get; set; }
        public bool MatchByQty { get; set; }
        public bool MatchByOpen { get; set; }
        public int MatchSeqRef { get; set; }
        public int MatchSeqReqDate { get; set; }
        public int MatchSeqQty { get; set; }
        public int MatchSeqOpen { get; set; }
        public bool OrderHoldForReview { get; set; }
        public bool DemandCloseNoMatch { get; set; }
        public bool WflockByLine { get; set; }
        public string RateGrpCode { get; set; }
        public bool PerfectMatch { get; set; }
        public string MatchPriorityList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AllowNonPerfectMatch { get; set; }
        public string MatchOptionAvailList { get; set; }
        public string MatchOptSelectedList { get; set; }
        public bool ExcludeUntil { get; set; }
        public bool ExcludeBefore { get; set; }
        public int UntilDays { get; set; }
        public int BeforeDays { get; set; }
        public decimal DocTotalInvoiceAmt { get; set; }
        public decimal Rpt1TotalInvoiceAmt { get; set; }
        public decimal Rpt2TotalInvoiceAmt { get; set; }
        public decimal Rpt3TotalInvoiceAmt { get; set; }
        public decimal DocTotalOrderAmt { get; set; }
        public decimal Rpt1TotalOrderAmt { get; set; }
        public decimal Rpt2TotalOrderAmt { get; set; }
        public decimal Rpt3TotalOrderAmt { get; set; }
    }
}
