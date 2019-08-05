using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbCustCred
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ExtCompany { get; set; }
        public string ExtCompName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal DocArtotal { get; set; }
        public decimal DocSototal { get; set; }
        public decimal DocPitotal { get; set; }
        public decimal Artotal { get; set; }
        public decimal Sototal { get; set; }
        public decimal Pitotal { get; set; }
        public string ErrorMsg { get; set; }
        public int GlbCustNum { get; set; }
        public int ParentCustNum { get; set; }
        public string GlobalCurrencyCode { get; set; }
        public int TotalInvoices { get; set; }
        public int TotalOrders { get; set; }
        public int TotalPayIns { get; set; }
        public decimal NaparentsCreditUsed { get; set; }
        public decimal NasharedCreditUsed { get; set; }
        public decimal NaownCreditUsed { get; set; }
        public decimal GlbNaparentsCreditUsed { get; set; }
        public decimal GlbNasharedCreditUsed { get; set; }
        public decimal NapoolCreditUsed { get; set; }
        public decimal GlbNapoolCreditUsed { get; set; }
        public decimal GlbNaownCreditUsed { get; set; }
        public decimal NaexceedLimit { get; set; }
        public decimal GlbNaexceedLimit { get; set; }
        public decimal Arloctotal { get; set; }
        public decimal DocArloctotal { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
