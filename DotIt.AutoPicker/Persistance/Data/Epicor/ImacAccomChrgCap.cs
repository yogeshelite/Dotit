using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacAccomChrgCap
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal AccomChrgCapId { get; set; }
        public DateTime? EffDt { get; set; }
        public decimal PenCap { get; set; }
        public decimal LpenCap { get; set; }
        public decimal RetCap { get; set; }
        public decimal LretCap { get; set; }
        public decimal MinAssetsReqd { get; set; }
        public decimal MaxAssetsChrg { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string Category { get; set; }
        public decimal AnnualCap { get; set; }
        public decimal LifeTimeCap { get; set; }
        public decimal SelfFundedCap { get; set; }
        public decimal PartPensionerCap { get; set; }
    }
}
