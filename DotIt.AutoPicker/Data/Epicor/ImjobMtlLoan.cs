using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImjobMtlLoan
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public string FromJobNum { get; set; }
        public int FromAssmSeq { get; set; }
        public int FromMtlSeq { get; set; }
        public string ToJobNum { get; set; }
        public int ToAssmSeq { get; set; }
        public int ToMtlSeq { get; set; }
        public decimal TotalLoanQty { get; set; }
        public string Ium { get; set; }
        public decimal TotalBaseQty { get; set; }
        public string BaseUom { get; set; }
        public decimal TotalCost { get; set; }
        public decimal MaterialMtlCost { get; set; }
        public decimal MaterialLabCost { get; set; }
        public decimal MaterialSubCost { get; set; }
        public decimal MaterialBurCost { get; set; }
        public decimal MtlBurCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
