using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FscallMt
    {
        public string Company { get; set; }
        public int CallNum { get; set; }
        public int CallLine { get; set; }
        public int MatNum { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public string ProdCode { get; set; }
        public decimal EstQty { get; set; }
        public decimal ActQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BillableUnitPrice { get; set; }
        public decimal DocUnitPrice { get; set; }
        public decimal DocBillableUnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal DocUnitCost { get; set; }
        public string Complete { get; set; }
        public string ResReasonCode { get; set; }
        public string PricePerCode { get; set; }
        public bool Billable { get; set; }
        public decimal Rpt1BillableUnitPrice { get; set; }
        public decimal Rpt2BillableUnitPrice { get; set; }
        public decimal Rpt3BillableUnitPrice { get; set; }
        public decimal Rpt1UnitCost { get; set; }
        public decimal Rpt2UnitCost { get; set; }
        public decimal Rpt3UnitCost { get; set; }
        public decimal Rpt1UnitPrice { get; set; }
        public decimal Rpt2UnitPrice { get; set; }
        public decimal Rpt3UnitPrice { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
