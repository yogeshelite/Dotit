using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WebSessionInputs
    {
        public string SessId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateTime { get; set; }
        public string SessSubId { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
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
        public string ScreenValue { get; set; }
        public bool DisableField { get; set; }
        public bool LeaveTrigger { get; set; }
        public string DynListItems { get; set; }
        public int ConfigVersion { get; set; }
        public bool ApplyGlobal { get; set; }
        public string GivinputName { get; set; }
        public int Sequence { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
