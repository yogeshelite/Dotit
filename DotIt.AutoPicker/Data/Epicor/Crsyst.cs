using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Crsyst
    {
        public string Company { get; set; }
        public string DefTaskSetId { get; set; }
        public string DefMktgCampaignId { get; set; }
        public string DefWebMktgCampaignId { get; set; }
        public string WinReasonCode { get; set; }
        public string LossReasonCode { get; set; }
        public string TaskReasonCode { get; set; }
        public bool CloseTasksWin { get; set; }
        public bool CloseTasksLose { get; set; }
        public string TerritoryId { get; set; }
        public string DefIcmktgCampaignId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool UseTerritorySecurity { get; set; }
        public int CrmcallsShown { get; set; }
        public bool ExternalCrmintegration { get; set; }
        public string ExternalCrmsystem { get; set; }
        public string ExternalCrmurl { get; set; }
        public string ExternalCrmmasterFile { get; set; }
        public string ExternalToken { get; set; }
        public string ExternalCrmloginId { get; set; }
        public string ExternalCrmpassword { get; set; }
        public string ExternalCrmtimeZoneId { get; set; }
        public string ExternalCrmdefaultIctypeId { get; set; }
        public DateTime? ExternalCrmlastSync { get; set; }
        public DateTime? ExternalCrmlastSyncContact { get; set; }
        public DateTime? ExternalCrmlastSyncCustomer { get; set; }
        public DateTime? ExternalCrmlastSyncPart { get; set; }
        public DateTime? ExternalCrmlastSyncQuote { get; set; }
        public int ExternalCrmcreateSo { get; set; }
    }
}
