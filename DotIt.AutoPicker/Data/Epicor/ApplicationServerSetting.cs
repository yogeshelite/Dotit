using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ApplicationServerSetting
    {
        public ApplicationServerSetting()
        {
            AdminConsoleSetting = new HashSet<AdminConsoleSetting>();
        }

        public string ApplicationName { get; set; }
        public string DeploymentDirectory { get; set; }
        public string WebSiteDirectory { get; set; }
        public bool CopyAssembliesToSite { get; set; }
        public string NetTcpbinding { get; set; }
        public string Sslcertificate { get; set; }
        public string ApplicationPoolName { get; set; }
        public string ApplicationPoolUserName { get; set; }
        public string ApplicationPoolUserPassword { get; set; }
        public string SystemCode { get; set; }
        public string DatabaseServerName { get; set; }
        public string AuthenticationType { get; set; }
        public string DatabaseUser { get; set; }
        public string DatabaseUserPassword { get; set; }
        public string DatabaseName { get; set; }
        public string PatchDirectory { get; set; }
        public string CustomDirectory { get; set; }
        public string UpdateLevel { get; set; }
        public string SsrsbaseUrl { get; set; }
        public string SsrsdatabaseServerName { get; set; }
        public string SsrsauthenticationType { get; set; }
        public string SsrsdatabaseUser { get; set; }
        public string SsrsdatabaseUserPassword { get; set; }
        public string SsrsdatabaseName { get; set; }
        public bool SsrscreateDatabase { get; set; }
        public bool Ssrsconfigure { get; set; }
        public bool UseAppPoolIdentity { get; set; }
        public bool Ssrsimport { get; set; }
        public string SsrsreportDirectory { get; set; }
        public string Ssrsroot { get; set; }
        public string Ssrslocation { get; set; }
        public string SharedAssemblyDir { get; set; }
        public string ServerName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<AdminConsoleSetting> AdminConsoleSetting { get; set; }
    }
}
