using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImecooprMachParam
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public int OprSeq { get; set; }
        public int MachParamSeq { get; set; }
        public string RequestCode { get; set; }
        public string MachineNum { get; set; }
        public string ToolNum { get; set; }
        public int ParamNum { get; set; }
        public decimal ParamUpperLimit { get; set; }
        public decimal ParamNominalValue { get; set; }
        public decimal ParamLowerLimit { get; set; }
        public decimal ParamDelayValue { get; set; }
        public bool SpecEnable { get; set; }
        public bool SpecControlAlarm { get; set; }
        public bool SpecRunAlarm { get; set; }
        public bool ProcSpecAlarm { get; set; }
        public bool ProcControlAlarm { get; set; }
        public bool PartQualSpecEnable { get; set; }
        public bool PartQualControlEnable { get; set; }
        public int OrigOprSeq { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
