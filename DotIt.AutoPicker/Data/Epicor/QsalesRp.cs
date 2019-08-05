using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QsalesRp
    {
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public string SalesRepCode { get; set; }
        public string Name { get; set; }
        public bool PrimeRep { get; set; }
        public decimal RepRate { get; set; }
        public int RepSplit { get; set; }
        public string RoleCode { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
