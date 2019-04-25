using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RecurringCycle
    {
        public string Company { get; set; }
        public string CycleCode { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
        public bool HoldInvoice { get; set; }
        public bool CopyLatestInvoice { get; set; }
        public bool Inactive { get; set; }
        public int Interval { get; set; }
        public string Modifier { get; set; }
        public int BillingDay { get; set; }
        public int Duration { get; set; }
        public bool MaximumValue { get; set; }
        public bool EditEnable { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
