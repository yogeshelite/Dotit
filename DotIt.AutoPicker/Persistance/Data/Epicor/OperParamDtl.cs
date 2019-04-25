using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class OperParamDtl
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string MachResourceId { get; set; }
        public string ToolResourceId { get; set; }
        public int OperParamNum { get; set; }
        public string Description { get; set; }
        public decimal UpperLim { get; set; }
        public decimal NomVal { get; set; }
        public decimal LowerLim { get; set; }
        public decimal DelayVal { get; set; }
        public bool SpcEnable { get; set; }
        public int SpccontrolAlarm { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
