using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ReminderLetter
    {
        public string Company { get; set; }
        public bool Printed { get; set; }
        public string GroupCode { get; set; }
        public int Sequence { get; set; }
        public int CustNum { get; set; }
        public string CurrencyCode { get; set; }
        public int OverdueInvNum { get; set; }
        public decimal OverdueAmt { get; set; }
        public decimal FinChargeAmt { get; set; }
        public int LetterNum { get; set; }
        public bool Posted { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ChisrcodeLine { get; set; }
        public string ChisrrefNum { get; set; }
    }
}
