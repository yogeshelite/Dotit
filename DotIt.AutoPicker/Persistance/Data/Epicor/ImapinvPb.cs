using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImapinvPb
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public string RoleCd { get; set; }
        public string ProjectId { get; set; }
        public string PhaseId { get; set; }
        public decimal HoursChg { get; set; }
        public decimal MtlChg { get; set; }
        public decimal DocMtlChg { get; set; }
        public decimal Rpt1MtlChg { get; set; }
        public decimal Rpt2MtlChg { get; set; }
        public decimal Rpt3MtlChg { get; set; }
        public decimal InvDtlValue { get; set; }
        public decimal DocInvDtlValue { get; set; }
        public decimal Rpt1InvDtlValue { get; set; }
        public decimal Rpt2InvDtlValue { get; set; }
        public decimal Rpt3InvDtlValue { get; set; }
        public int PbinvNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
