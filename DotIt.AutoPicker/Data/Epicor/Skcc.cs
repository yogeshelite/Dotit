using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Skcc
    {
        public string Company { get; set; }
        public string CardId { get; set; }
        public string CreditCardNo { get; set; }
        public string IssuingBank { get; set; }
        public string CardMemberName { get; set; }
        public string CardTypeCode { get; set; }
        public string CardDesc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
