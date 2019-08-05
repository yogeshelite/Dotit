using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptStructuredOutputDef
    {
        public RptStructuredOutputDef()
        {
            RptStructuredOutputFile = new HashSet<RptStructuredOutputFile>();
        }

        public string Company { get; set; }
        public string RptStructuredOutputDefId { get; set; }
        public string RptStructuredOutputDescription { get; set; }
        public string RptDefId { get; set; }
        public bool SystemFlag { get; set; }
        public bool ConfirmedCompliance { get; set; }
        public string ComplianceRule { get; set; }
        public string InternalComments { get; set; }
        public string DateFormat { get; set; }
        public string DecimalSymbol { get; set; }
        public string DigitGroupingSymbol { get; set; }
        public string NegativeSignSymbol { get; set; }
        public string Encoding { get; set; }
        public string Delimiter { get; set; }
        public string EndOfRecordSymbol { get; set; }
        public string QuotationMark { get; set; }
        public bool QuoteAllValues { get; set; }
        public string BooleanTrue { get; set; }
        public string BooleanFalse { get; set; }
        public string PrePostProcessingEftheadCompany { get; set; }
        public int? PrePostProcessingEftheadUid { get; set; }
        public string AdditionalSettings { get; set; }
        public int CompanyVisibility { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptDataDef RptDef { get; set; }
        public virtual ICollection<RptStructuredOutputFile> RptStructuredOutputFile { get; set; }
    }
}
