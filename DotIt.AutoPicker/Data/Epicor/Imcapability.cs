using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imcapability
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CapabilityId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string PrimaryResourceGrpId { get; set; }
        public bool AdditionalResourceRequired { get; set; }
        public bool SetupGroupRequired { get; set; }
        public string CapType { get; set; }
        public string OpCode { get; set; }
        public string OpStdId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExternalMes { get; set; }
    }
}
