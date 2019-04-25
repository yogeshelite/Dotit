using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxSvcJurDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TaxSvcId { get; set; }
        public int LineNum { get; set; }
        public int OrderRelNum { get; set; }
        public int Seq { get; set; }
        public decimal TaxableAmount { get; set; }
        public string JurisCode { get; set; }
        public string JurisName { get; set; }
        public string JurisType { get; set; }
        public decimal Percent { get; set; }
        public decimal TaxAmt { get; set; }
        public string TaxType { get; set; }
        public int DocId { get; set; }
        public string Tcno { get; set; }
        public decimal TchtaxableAmount { get; set; }
        public string TchjurisCode { get; set; }
        public string TchjurisName { get; set; }
        public string TchjurisType { get; set; }
        public decimal Tchpercent { get; set; }
        public decimal TchtaxAmt { get; set; }
        public string TchtaxType { get; set; }
        public int ItemSeq { get; set; }
        public int QuoteNum { get; set; }
        public int OrderNum { get; set; }
        public int InvoiceNum { get; set; }
        public string ApinvoiceNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
