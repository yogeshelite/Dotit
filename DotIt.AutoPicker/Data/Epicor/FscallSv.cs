using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FscallSv
    {
        public string Company { get; set; }
        public int CallNum { get; set; }
        public int CallLine { get; set; }
        public int ServNum { get; set; }
        public string ServCode { get; set; }
        public decimal LaborRate { get; set; }
        public decimal BillableLaborRate { get; set; }
        public decimal DocLaborRate { get; set; }
        public decimal DocBillableLaborRate { get; set; }
        public decimal EstLabHours { get; set; }
        public decimal ActLabHours { get; set; }
        public bool Complete { get; set; }
        public string ResReasonCode { get; set; }
        public bool Billable { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public decimal Rpt1BillableLaborRate { get; set; }
        public decimal Rpt2BillableLaborRate { get; set; }
        public decimal Rpt3BillableLaborRate { get; set; }
        public decimal Rpt1LaborRate { get; set; }
        public decimal Rpt2LaborRate { get; set; }
        public decimal Rpt3LaborRate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
