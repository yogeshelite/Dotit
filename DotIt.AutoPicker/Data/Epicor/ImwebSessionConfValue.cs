using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImwebSessionConfValue
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SessId { get; set; }
        public string SessSubId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateTime { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public string JobNum { get; set; }
        public string InputName { get; set; }
        public string ControlType { get; set; }
        public string DataType { get; set; }
        public string InputValue { get; set; }
        public int ConfigVersion { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int Assembly { get; set; }
        public string SeqType { get; set; }
        public int Sequence { get; set; }
        public decimal InputPrice { get; set; }
        public string SourceDbrecid { get; set; }
        public string BasePartNum { get; set; }
        public string BaseRevisionNum { get; set; }
        public string RuleTag { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public bool ExtConfig { get; set; }
        public string SummaryLabel { get; set; }
        public int OrderRelNum { get; set; }
        public bool HasLeaveTrigger { get; set; }
        public bool DisabledInput { get; set; }
        public string DynListItems { get; set; }
        public bool ApplyGlobal { get; set; }
        public string ContextMode { get; set; }
        public int ContextQuoteNum { get; set; }
        public int ContextQuoteLine { get; set; }
        public int ContextOrderNum { get; set; }
        public int ContextOrderLine { get; set; }
        public string ContextJobNum { get; set; }
        public decimal DecimalInputValue { get; set; }
        public bool GlobalInputVar { get; set; }
        public string GivpartNum { get; set; }
        public string GivrevisionNum { get; set; }
        public string GivinputName { get; set; }
        public DateTime? DateInputValue { get; set; }
        public string FormatString { get; set; }
        public string Baqcriteria { get; set; }
        public string BaqdispValue { get; set; }
        public string BaqinputVal { get; set; }
        public string BaqprogramName { get; set; }
        public bool BaqrunProgram { get; set; }
        public bool Invisible { get; set; }
        public string ToolTip { get; set; }
        public bool Required { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int PWidth { get; set; }
        public decimal Increment { get; set; }
        public string ValidList { get; set; }
        public string SideLabel { get; set; }
        public bool PropertyChanged { get; set; }
        public string FieldProperties { get; set; }
        public int PHeight { get; set; }
        public decimal StartDec { get; set; }
        public decimal EndDec { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool SetInitValProperty { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
