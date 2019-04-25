using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImrptStructuredOutputDef
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
