using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcashDesk
    {
        public bool AllowDraftCi { get; set; }
        public bool AllowDraftCr { get; set; }
        public bool AllowNegBal { get; set; }
        public string CashDeskId { get; set; }
        public string Cashier { get; set; }
        public string Company { get; set; }
        public string CurrencyCode { get; set; }
        public string DayCloseMode { get; set; }
        public decimal DocInitPayrollBal { get; set; }
        public decimal DocInitTotalBal { get; set; }
        public string EntrustedCashier { get; set; }
        public DateTime? EntrustedFrom { get; set; }
        public DateTime? EntrustedTill { get; set; }
        public bool Inactive { get; set; }
        public decimal InitTotalBal { get; set; }
        public decimal InitPayrollBal { get; set; }
        public decimal LimitExptPayroll { get; set; }
        public decimal LimitTotal { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public DateTime? OpenedFrom { get; set; }
        public string PostingOpt { get; set; }
        public string RateGrpCode { get; set; }
        public decimal Rpt1InitPayrollBal { get; set; }
        public decimal Rpt2InitPayrollBal { get; set; }
        public decimal Rpt3InitPayrollBal { get; set; }
        public decimal Rpt1InitTotalBal { get; set; }
        public decimal Rpt2InitTotalBal { get; set; }
        public decimal Rpt3InitTotalBal { get; set; }
        public bool UseExtnNumForCi { get; set; }
        public bool UseExtnNumForCr { get; set; }
        public decimal FloatAmt { get; set; }
        public int CashPayMethodPmuid { get; set; }
        public string CashPayMethodName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int PrintLastPage { get; set; }
        public int PrintPerPage { get; set; }
        public string ReportTranDocType { get; set; }
    }
}
