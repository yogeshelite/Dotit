using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImreminderLetter
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
