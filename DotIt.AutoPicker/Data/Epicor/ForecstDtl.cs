using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ForecstDtl
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShiptoNum { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public DateTime? ForeDate { get; set; }
        public decimal ForeQty { get; set; }
        public string ForeQtyUom { get; set; }
        public DateTime? EdiUpdateDate { get; set; }
        public string Ponum { get; set; }
        public string DemandReference { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public string ScheduleNumber { get; set; }
        public int Sequence { get; set; }
        public bool Active { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
