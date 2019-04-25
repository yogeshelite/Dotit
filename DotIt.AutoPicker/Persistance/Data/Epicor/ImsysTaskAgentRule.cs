using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsysTaskAgentRule
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string SecGroupCode { get; set; }
        public string RuleType { get; set; }
        public string ProcessId { get; set; }
        public string AppServerUrl { get; set; }
        public string EndpointBinding { get; set; }
        public string DnsIdentity { get; set; }
        public string SysUserId { get; set; }
        public string SysPassword { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
