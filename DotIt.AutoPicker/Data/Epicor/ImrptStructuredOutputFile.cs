﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrptStructuredOutputFile
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
        public string RptStructuredOutputFileId { get; set; }
        public string RptStructuredOutputFileDesc { get; set; }
        public bool Enabled { get; set; }
        public int StructuredOutputFileType { get; set; }
        public string OutputLocation { get; set; }
        public bool OutputColumnHeaders { get; set; }
        public string AdditionalSettings { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}