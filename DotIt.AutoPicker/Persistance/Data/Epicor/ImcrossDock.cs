using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcrossDock
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
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string SupplyJobNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string TfordNum { get; set; }
        public int TfordLine { get; set; }
        public decimal CrossDockedQty { get; set; }
        public string CrossDockedUm { get; set; }
        public string ToPlant { get; set; }
        public string FromPlant { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreateTime { get; set; }
        public bool BuyToOrder { get; set; }
        public int CustNum { get; set; }
        public string CustId { get; set; }
        public int Priority { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string DistributionType { get; set; }
        public string AssignEmpId { get; set; }
        public string WhseGroupCode { get; set; }
        public bool OnHold { get; set; }
        public bool ReleaseToPicking { get; set; }
    }
}
