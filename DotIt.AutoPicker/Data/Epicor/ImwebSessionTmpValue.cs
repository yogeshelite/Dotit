using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImwebSessionTmpValue
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SessId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateTime { get; set; }
        public string SessSubId { get; set; }
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
        public bool ApplyGlobal { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
