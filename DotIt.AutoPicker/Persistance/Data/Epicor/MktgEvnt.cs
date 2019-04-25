using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MktgEvnt
    {
        public string Company { get; set; }
        public string MktgCampaignId { get; set; }
        public int MktgEvntSeq { get; set; }
        public string ActivityType { get; set; }
        public string EvntDescription { get; set; }
        public string AdvertisementCode { get; set; }
        public string PublicationCode { get; set; }
        public string MktgEvntComment { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal BudgetCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal EstRevenue { get; set; }
        public bool Inactive { get; set; }
        public string ProjectId { get; set; }
        public decimal ActRevenue { get; set; }
        public string SourceDbrecid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
