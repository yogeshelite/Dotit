using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImdataExportDef
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string Description { get; set; }
        public string SelectionMethod { get; set; }
        public string ExportFolder { get; set; }
        public string DateFormat { get; set; }
        public string DecimalSeparator { get; set; }
        public string ThousandSeparator { get; set; }
        public bool IsReleased { get; set; }
        public bool Inactive { get; set; }
        public string Comments { get; set; }
        public string BookId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartDateToken { get; set; }
        public int StartPeriod { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndDateToken { get; set; }
        public int EndPeriod { get; set; }
        public DateTime? LastRunDate { get; set; }
        public string LastRunBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UrlforDtd { get; set; }
        public bool IsUsed { get; set; }
        public bool GenerateIndex { get; set; }
        public string CommonFileName { get; set; }
        public string RootNodeName { get; set; }
        public string Dsymbol { get; set; }
        public string Lesymbol { get; set; }
        public string Qsymbol { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string FileType { get; set; }
        public bool IsCommonFile { get; set; }
        public bool AddRecordType { get; set; }
        public bool AddCommonFooter { get; set; }
        public string CommonFooter { get; set; }
        public int Encoding { get; set; }
    }
}
