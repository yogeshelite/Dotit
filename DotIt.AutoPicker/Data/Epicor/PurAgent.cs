using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PurAgent
    {
        public bool InActive { get; set; }
        public string Company { get; set; }
        public string BuyerId { get; set; }
        public string Name { get; set; }
        public string ApprovalPerson { get; set; }
        public decimal Polimit { get; set; }
        public string EmailAddress { get; set; }
        public bool ConsolidatedPurchasing { get; set; }
        public string CnvEmpId { get; set; }
        public int PerConId { get; set; }
        public bool SyncNameToPerCon { get; set; }
        public bool SyncEmailToPerCon { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
