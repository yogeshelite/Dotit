using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImjobPart
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string JobNum { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int PartsPerOp { get; set; }
        public decimal PartQty { get; set; }
        public decimal StockQty { get; set; }
        public decimal ShippedQty { get; set; }
        public decimal ReceivedQty { get; set; }
        public decimal Wipqty { get; set; }
        public decimal QtyCompleted { get; set; }
        public decimal ReservedQty { get; set; }
        public decimal AllocatedQty900 { get; set; }
        public decimal PickingQty { get; set; }
        public decimal PickedQty { get; set; }
        public int LbrCostBase { get; set; }
        public int MtlCostBase { get; set; }
        public bool JobClosed { get; set; }
        public bool JobComplete { get; set; }
        public string Plant { get; set; }
        public string PartDescription { get; set; }
        public string Ium { get; set; }
        public bool ShipDocReq { get; set; }
        public bool ShipDocAvail { get; set; }
        public string MtlList { get; set; }
        public bool PreventSugg { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
