using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbForecast
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public DateTime? ForeDate { get; set; }
        public bool Inactive { get; set; }
        public decimal ForeQty { get; set; }
        public decimal ConsumedQty { get; set; }
        public string Ponum { get; set; }
        public string CreatedBy { get; set; }
        public string ExtCompany { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? TransDate { get; set; }
        public bool AutoTransfer { get; set; }
        public int TransTime { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DemandContract { get; set; }
        public string DemandReference { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public string ScheduleNumber { get; set; }
        public DateTime? EndDate { get; set; }
        public string ShipToNum { get; set; }
        public string ForeQtyUom { get; set; }
        public string KitFlag { get; set; }
        public string ParentPartNum { get; set; }
        public DateTime? EdiupdateDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
