using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcInValue
    {
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
        public string ConfigId { get; set; }
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
        public string ExtCompany { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public bool ExtConfig { get; set; }
        public string SummaryLabel { get; set; }
        public int OrderRelNum { get; set; }
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
        public decimal DisplaySeq { get; set; }
        public int KitParentLine { get; set; }
        public string KitFlag { get; set; }
        public int KitCompParentLine { get; set; }
        public string KitCompParentPart { get; set; }
        public int KitCompParentSeq { get; set; }
        public int KitCompOrigSeq { get; set; }
        public int DemandHeadSeq { get; set; }
        public int DemandDtlSeq { get; set; }
        public int DemandContractNum { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public string RelatedToFile { get; set; }
        public string RelatedType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
