using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImkanBanRcptLnopts
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReceiptId { get; set; }
        public string LegalNumberId { get; set; }
        public string TransYearSuffix { get; set; }
        public string DspTransYear { get; set; }
        public string Prefix { get; set; }
        public string PrefixList { get; set; }
        public string NumberSuffix { get; set; }
        public string NumberOption { get; set; }
        public string GenerationType { get; set; }
        public string Description { get; set; }
        public string PeriodPrefix { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int TransYear { get; set; }
        public int TransPeriod { get; set; }
        public bool ShowDspTransYear { get; set; }
        public bool EnablePrefix { get; set; }
        public bool EnableSuffix { get; set; }
        public bool ShowTransPeriod { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
