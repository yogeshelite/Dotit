using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MktgCamp
    {
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
