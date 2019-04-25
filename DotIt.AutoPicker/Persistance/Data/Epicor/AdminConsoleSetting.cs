using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AdminConsoleSetting
    {
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

        public virtual ApplicationServerSetting ApplicationNameNavigation { get; set; }
    }
}
