using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImzdataSet
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SystemCode { get; set; }
        public string DataSetId { get; set; }
        public string DataSetName { get; set; }
        public string Description { get; set; }
        public string TargetNamespace { get; set; }
        public string ProIncDir { get; set; }
        public string ProIncName { get; set; }
        public string Version { get; set; }
        public string XsdTypeName { get; set; }
        public bool AutoGen { get; set; }
        public bool VerIncr { get; set; }
        public bool Generated { get; set; }
        public string Dstype { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
