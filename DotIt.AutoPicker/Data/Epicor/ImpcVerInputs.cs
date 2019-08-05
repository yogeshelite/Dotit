﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcVerInputs
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int ConfigVersion { get; set; }
        public string InputName { get; set; }
        public int TabOrder { get; set; }
        public string DataType { get; set; }
        public string FormatString { get; set; }
        public string InitVal { get; set; }
        public string StatusText { get; set; }
        public bool Required { get; set; }
        public int PageSeq { get; set; }
        public string SideLabel { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int PWidth { get; set; }
        public int PHeight { get; set; }
        public string ControlType { get; set; }
        public string PromptWhen { get; set; }
        public string ListItems { get; set; }
        public decimal StartDec { get; set; }
        public decimal EndDec { get; set; }
        public decimal IncrPrec { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ValList { get; set; }
        public bool Horizontal { get; set; }
        public bool IsGlobal { get; set; }
        public string OnLeave { get; set; }
        public string WebInputName { get; set; }
        public string SummaryLabel { get; set; }
        public bool DlrunProgram { get; set; }
        public string DlprogramName { get; set; }
        public string DlprogramInputs { get; set; }
        public string SourceDbrecid { get; set; }
        public bool HideInSummary { get; set; }
        public string OnLeave2 { get; set; }
        public bool Invisible { get; set; }
        public string Comments { get; set; }
        public bool GlobalInputVar { get; set; }
        public string GlbInputVarName { get; set; }
        public bool NoDispSummary { get; set; }
        public bool ShowDistinct { get; set; }
        public string DesignControlType { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
