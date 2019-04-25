using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImmktgCamp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string MktgCampaignId { get; set; }
        public string CampDescription { get; set; }
        public string CampComments { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal BudgetCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal EstRevenue { get; set; }
        public bool Inactive { get; set; }
        public int DefMktgEvntSeq { get; set; }
        public decimal ActRevenue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
