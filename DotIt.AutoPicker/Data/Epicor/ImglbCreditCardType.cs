using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbCreditCardType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int CardNumberLength { get; set; }
        public string CardType { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Mask { get; set; }
        public bool Mod10validation { get; set; }
        public string Prefix { get; set; }
        public string GlbCompany { get; set; }
        public string GlbCardType { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalCreditCardType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }
    }
}
