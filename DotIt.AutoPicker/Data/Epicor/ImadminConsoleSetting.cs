using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImadminConsoleSetting
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string ApplicationName { get; set; }
        public string DisplayName { get; set; }
        public string EpicorUserName { get; set; }
        public string EpicorUserPassword { get; set; }
        public int? OperationTimeout { get; set; }
        public bool ValidateWcfcert { get; set; }
        public string Dnsidentity { get; set; }
        public bool DoNotAllowClientAcces { get; set; }
        public bool UseEwaclient { get; set; }
        public bool UseSmartClient { get; set; }
        public string SmartClientBasePath { get; set; }
        public string EwabaseUrl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
