using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class InspResultsInputs
    {
        public string Company { get; set; }
        public string InspPlanType { get; set; }
        public string File { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public int SampleNumber { get; set; }
        public DateTime? InspectDate { get; set; }
        public int InspectTime { get; set; }
        public string InputName { get; set; }
        public string ControlType { get; set; }
        public string DataType { get; set; }
        public string InputValue { get; set; }
        public int ConfigVersion { get; set; }
        public int Assembly { get; set; }
        public string SeqType { get; set; }
        public int Sequence { get; set; }
        public string RuleTag { get; set; }
        public string SummaryLabel { get; set; }
        public bool Required { get; set; }
        public string SideLabel { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int PWidth { get; set; }
        public int PHeight { get; set; }
        public decimal StartDec { get; set; }
        public decimal EndDec { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Invisible { get; set; }
        public string InitVal { get; set; }
        public decimal Increment { get; set; }
        public string ValidList { get; set; }
        public string ToolTip { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string InspPlanPartNum { get; set; }
        public string InspPlanRevNum { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public string AttributeUse { get; set; }
        public string AttrType { get; set; }
        public string FieldName { get; set; }
        public decimal InputPrice { get; set; }
        public string AttributeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
