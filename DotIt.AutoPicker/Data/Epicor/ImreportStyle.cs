﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImreportStyle
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReportId { get; set; }
        public int StyleNum { get; set; }
        public string StyleDescription { get; set; }
        public string RptTypeId { get; set; }
        public string PrintProgram { get; set; }
        public string PrintProgramOptions { get; set; }
        public string RptDefId { get; set; }
        public string CompanyList { get; set; }
        public int ServerNum { get; set; }
        public string OutputLocation { get; set; }
        public string OutputEdi { get; set; }
        public bool SystemFlag { get; set; }
        public string Cgccode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string RptCriteriaSetId { get; set; }
        public string RptStructuredOutputDefId { get; set; }
        public bool StructuredOutputEnabled { get; set; }
        public bool RequireSubmissionId { get; set; }
        public bool AllowResetAfterSubmit { get; set; }
    }
}
