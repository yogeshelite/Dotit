using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imingstr28
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string SupplyType { get; set; }
        public string Hsnsac { get; set; }
        public decimal ValueCompoundAmt { get; set; }
        public decimal ValueUnregisteredAmt { get; set; }
        public decimal ValueExemptedAmt { get; set; }
        public decimal ValueNonRegisteredAmt { get; set; }
        public decimal ValueNilRateAmt { get; set; }
        public decimal ApvalueCompoundAmt { get; set; }
        public decimal ApvalueUnregisteredAmt { get; set; }
        public decimal ApvalueExemptedAmt { get; set; }
        public decimal ApvalueNonregisteredAmt { get; set; }
        public decimal ApvalueNilRateAmt { get; set; }
        public string Message { get; set; }
        public string Notes { get; set; }
        public int LineStatus { get; set; }
        public bool Manual { get; set; }
        public int ImportCounter { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
