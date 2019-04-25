using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpcashOprType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string OprTypeCode { get; set; }
        public string Direction { get; set; }
        public bool PayrollBal { get; set; }
        public string ReasonCode { get; set; }
        public string RecPayerType { get; set; }
        public string RoleCode { get; set; }
        public string OprClass { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string OprTypeReason { get; set; }
        public bool OverrideExchRateDate { get; set; }
    }
}
