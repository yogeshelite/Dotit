using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysCompany
    {
        public SysCompany()
        {
            ExtensionSetMapping = new HashSet<ExtensionSetMapping>();
            SysUserComp = new HashSet<SysUserComp>();
        }

        public string Company { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string MfgSys { get; set; }
        public string EmailLinkPort { get; set; }
        public string EmailFromAddr { get; set; }
        public string EmailFromLabel { get; set; }
        public string Smtpserver { get; set; }
        public int Smtpport { get; set; }
        public string AttachNetworkRoot { get; set; }
        public string AttachSharePointRoot { get; set; }
        public int AttachDefaultMechanism { get; set; }
        public bool EnableFileSys { get; set; }
        public bool EnableSharePoint { get; set; }
        public bool AllowDefaultDoc { get; set; }
        public string MetadataPath { get; set; }
        public string WinWebUrl { get; set; }
        public bool TrackSysActivity { get; set; }
        public bool TrackPersonalizationChg { get; set; }
        public string ReportTypePref { get; set; }
        public string MobileUrl { get; set; }
        public string MobileMetaPath { get; set; }
        public string WorkstationMethod { get; set; }
        public string EntSearchUrl { get; set; }
        public string Smtpacct { get; set; }
        public string SmptacctPw { get; set; }
        public string Ssrsurl { get; set; }
        public bool GlobalEntSearch { get; set; }
        public string Scserver { get; set; }
        public string ScuserId { get; set; }
        public string Scpassword { get; set; }
        public string Ubaqwfpackage { get; set; }
        public Guid InstallationId { get; set; }
        public string CountryGroupCode { get; set; }
        public string CountryCode { get; set; }
        public Guid CountryCodeId { get; set; }
        public string DefaultLabelsPrinter { get; set; }
        public string DefaultReportsPrinter { get; set; }
        public string Eseurl { get; set; }
        public string EsenotificationSourceId { get; set; }
        public bool IsSmtpcredential { get; set; }
        public string HelpUri { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string SsrsbaseUrl { get; set; }
        public string SsrsdatabaseServerName { get; set; }
        public string SsrsauthenticationType { get; set; }
        public string SsrsdatabaseUser { get; set; }
        public string SsrsdatabaseUserPassword { get; set; }
        public string SsrsdatabaseName { get; set; }
        public bool SsrsoverrideDefaults { get; set; }
        public string SsrsprintOptions { get; set; }
        public string TimeZoneId { get; set; }
        public bool SmtpenableSsl { get; set; }
        public string DefaultLayoutId { get; set; }
        public string OdbcuserId { get; set; }
        public string Odbcpassword { get; set; }
        public string EpicorEducationUrl { get; set; }
        public string EpicorHelpUrl { get; set; }
        public string TenantId { get; set; }
        public int FileTransferMode { get; set; }
        public bool GridsUseBaseCurrencyInfo { get; set; }
        public string Eddurl { get; set; }
        public bool EnableDocStar { get; set; }
        public string AttachDocStarSiteUrl { get; set; }
        public bool CanViewDocStar { get; set; }
        public string EdiProcessing { get; set; }
        public string ReportLoggingLevel { get; set; }
        public int ImportApimaxDop { get; set; }
        public bool TelemetryOptIn { get; set; }
        public string TelemetryOptOutReason { get; set; }
        public int ImportPurgeInterval { get; set; }
        public int ImportMaxFileSize { get; set; }
        public Guid? TelemetryKey { get; set; }
        public string DefaultHomepageLayoutId { get; set; }

        public virtual ICollection<ExtensionSetMapping> ExtensionSetMapping { get; set; }
        public virtual ICollection<SysUserComp> SysUserComp { get; set; }
    }
}
