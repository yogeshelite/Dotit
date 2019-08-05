using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PplanHed
    {
        public string Company { get; set; }
        public string JobNum { get; set; }
        public string Plant { get; set; }
        public int PriorityFactor { get; set; }
        public string SchedCode { get; set; }
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public string ProdCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReqDueDate { get; set; }
        public decimal ProdQty { get; set; }
        public bool Shortage { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
