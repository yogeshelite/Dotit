using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysTaskAgentRule
    {
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
