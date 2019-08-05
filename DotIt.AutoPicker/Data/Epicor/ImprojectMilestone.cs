using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImprojectMilestone
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
