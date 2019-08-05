using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImquoteAsm
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public int AssemblySeq { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public string RevisionNum { get; set; }
        public decimal QtyPer { get; set; }
        public string Ium { get; set; }
        public bool Direct { get; set; }
        public int Parent { get; set; }
        public int PriorPeer { get; set; }
        public int NextPeer { get; set; }
        public int Child { get; set; }
        public string DrawNum { get; set; }
        public string CommentText { get; set; }
        public int BomSequence { get; set; }
        public int BomLevel { get; set; }
        public decimal RequiredQty { get; set; }
        public bool Template { get; set; }
        public int AutoRecOpr { get; set; }
        public string FindNum { get; set; }
        public int FinalOpr { get; set; }
        public DateTime? WistartDate { get; set; }
        public decimal WistartHour { get; set; }
        public DateTime? WidueDate { get; set; }
        public decimal WidueHour { get; set; }
        public int RelatedOperation { get; set; }
        public string AnalysisCode { get; set; }
        public decimal EstScrap { get; set; }
        public string EstScrapType { get; set; }
        public int OrigMtlSeq { get; set; }
        public string OrigRuleTag { get; set; }
        public bool ValRefDes { get; set; }
        public string BasePartNum { get; set; }
        public string BaseRevisionNum { get; set; }
        public int ReqRefDes { get; set; }
        public int GroupSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string OrigStructTag { get; set; }
        public bool LinkToContract { get; set; }
        public string ContractId { get; set; }
        public bool PclinkRemoved { get; set; }
    }
}
