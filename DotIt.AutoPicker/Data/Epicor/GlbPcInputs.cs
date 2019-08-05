using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPcInputs
    {
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
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public string AttributeId { get; set; }
        public bool ExternalRef { get; set; }
        public bool UseIncrValue { get; set; }
        public bool UseInitVal { get; set; }
        public bool UseListValues { get; set; }
        public bool UseMaxValue { get; set; }
        public bool UseMinValue { get; set; }
        public bool UseScreenLabel { get; set; }
        public bool UseToolTip { get; set; }
        public int SmartPartSeq { get; set; }
        public int SmartStringStart { get; set; }
        public int SmartStringEnd { get; set; }
        public bool ShowDistinct { get; set; }
        public string DesignControlType { get; set; }
        public string ConfigId { get; set; }
        public bool ReadOnly { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AutoSizeList { get; set; }
        public int ListWidth { get; set; }
        public string ImageSource { get; set; }
        public string ImageLayerId { get; set; }
    }
}
