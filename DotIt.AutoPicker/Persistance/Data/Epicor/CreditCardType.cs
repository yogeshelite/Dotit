using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CreditCardType
    {
        public string Company { get; set; }
        public string CardType { get; set; }
        public string Description { get; set; }
        public string Mask { get; set; }
        public int CardNumberLength { get; set; }
        public bool Mod10validation { get; set; }
        public string Prefix { get; set; }
        public bool GlobalCreditCardType { get; set; }
        public bool GlobalLock { get; set; }
        public string Wiapplication { get; set; }
        public string Wicctype { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int QtyLeftSide { get; set; }
        public int QtyRightSide { get; set; }
        public bool SystemFlag { get; set; }
    }
}
