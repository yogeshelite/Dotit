using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PlanContractHdr
    {
        public PlanContractHdr()
        {
            PlanContractDtl = new HashSet<PlanContractDtl>();
        }

        public string Company { get; set; }
        public string ContractId { get; set; }
        public string Description { get; set; }
        public string Plant { get; set; }
        public string Comments { get; set; }
        public string PlannerId { get; set; }
        public string CreatedBy { get; set; }
        public bool Approved { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public bool Active { get; set; }
        public string NonPcbinAction { get; set; }
        public string BuyerId { get; set; }
        public string RcvWhse { get; set; }
        public string RcvBin { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string NonPcoutsideAction { get; set; }

        public virtual ICollection<PlanContractDtl> PlanContractDtl { get; set; }
    }
}
