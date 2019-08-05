using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImplanContractHdr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
