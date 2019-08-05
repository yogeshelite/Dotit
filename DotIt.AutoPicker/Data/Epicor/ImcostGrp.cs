using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcostGrp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string Description { get; set; }
        public DateTime? BomrollupDate { get; set; }
        public string CreatedBy { get; set; }
        public string CostMethod { get; set; }
        public string Comment { get; set; }
        public DateTime? LastPartRefresh { get; set; }
        public DateTime? LastWcrefresh { get; set; }
        public string Burden { get; set; }
        public bool Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public string Labor { get; set; }
        public DateTime? LastOprefresh { get; set; }
        public string PrimaryPlant { get; set; }
        public bool LoadAltMethod { get; set; }
        public bool LoadCostLot { get; set; }
        public string CopyFromPlantCostId { get; set; }
        public string CopyFromGroupId { get; set; }
        public bool DeimportRateStatus { get; set; }
        public bool DeimpRtsLockStatus { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
