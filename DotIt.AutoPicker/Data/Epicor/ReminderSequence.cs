using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ReminderSequence
    {
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public string ReportStyle { get; set; }
        public string ReminderMessage { get; set; }
        public int Sequence { get; set; }
        public int DaysToRemind { get; set; }
        public string FinChargeCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
