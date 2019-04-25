using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprckStub
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int HeadNum { get; set; }
        public int LineNum { get; set; }
        public string PayTypeId { get; set; }
        public string Ptdesc { get; set; }
        public decimal CurHours { get; set; }
        public decimal Ytdhours { get; set; }
        public decimal CurPay { get; set; }
        public decimal Ytdpay { get; set; }
        public string TaxTblId { get; set; }
        public string TaxDesc { get; set; }
        public decimal CurTax { get; set; }
        public decimal Ytdtax { get; set; }
        public string DeductionId { get; set; }
        public int DeductionNum { get; set; }
        public string DeductDesc { get; set; }
        public decimal CurDed { get; set; }
        public decimal Ytdded { get; set; }
        public string Reference { get; set; }
        public decimal TaxableYtd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IncludeNetEarnings { get; set; }
    }
}
