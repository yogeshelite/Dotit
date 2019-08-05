using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ComagneticMediaReport
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string Description { get; set; }
        public string DefinitionId { get; set; }
        public string SchemaId { get; set; }
        public string BookId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public int DeliveryNumber { get; set; }
        public int LastDeliveryNumber { get; set; }
        public int DeliveryType { get; set; }
        public bool ZeroNegativeAmounts { get; set; }
        public bool IsSubmitted { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? SubmitDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ComagneticMediaDef ComagneticMediaDef { get; set; }
    }
}
