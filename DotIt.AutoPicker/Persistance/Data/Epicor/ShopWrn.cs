using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShopWrn
    {
        public string Company { get; set; }
        public int LaborHedSeq { get; set; }
        public int LaborDtlSeq { get; set; }
        public int LabWarnNum { get; set; }
        public bool CurrWarn { get; set; }
        public DateTime? EventDate { get; set; }
        public int EventTime { get; set; }
        public string MsgText { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public string EmployeeNum { get; set; }
        public int OprSeq { get; set; }
        public string ResourceGrpId { get; set; }
        public int VariancePct { get; set; }
        public string WarnType { get; set; }
        public string Plant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
