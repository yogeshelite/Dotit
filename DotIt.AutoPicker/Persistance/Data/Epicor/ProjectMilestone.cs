using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ProjectMilestone
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string MilestoneId { get; set; }
        public bool Complete { get; set; }
        public string Description { get; set; }
        public string BillingType { get; set; }
        public bool BillingRequired { get; set; }
        public decimal BillingAmount { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public decimal MarkupMtlPct { get; set; }
        public decimal MarkupSubcontractPct { get; set; }
        public decimal MarkupLaborPct { get; set; }
        public decimal MarkupBurdenPct { get; set; }
        public decimal MarkupMtlBurdenPct { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
