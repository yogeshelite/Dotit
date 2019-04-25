using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcashBfilterOptions
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BankAcctId { get; set; }
        public decimal CashBookNum { get; set; }
        public int LineType { get; set; }
        public bool FilterApinvoices { get; set; }
        public bool FilterAppay { get; set; }
        public bool FilterAppi { get; set; }
        public bool FilterArpi { get; set; }
        public bool FilterArinvoices { get; set; }
        public bool FilterBankAdj { get; set; }
        public bool FilterBankTran { get; set; }
        public bool FilterCrpay { get; set; }
        public bool FilterRevAppay { get; set; }
        public bool FilterRevCrpay { get; set; }
        public bool FilterAll { get; set; }
        public bool FilterPayments { get; set; }
        public bool FilterReceipts { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool FilterPrpay { get; set; }
    }
}
