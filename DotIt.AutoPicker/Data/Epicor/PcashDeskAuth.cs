using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcashDeskAuth
    {
        public string CashDeskId { get; set; }
        public bool CashIssue { get; set; }
        public bool CashReceipts { get; set; }
        public bool ChangeSetup { get; set; }
        public bool CloseCashDays { get; set; }
        public string Company { get; set; }
        public string DcdUserId { get; set; }
        public bool ReadOnlyAccess { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
