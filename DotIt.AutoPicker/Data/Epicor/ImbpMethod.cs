using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImbpMethod
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Source { get; set; }
        public string BpMethodCode { get; set; }
        public string SystemCode { get; set; }
        public string ObjectNs { get; set; }
        public string BusinessObject { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public bool HasRootTransaction { get; set; }
        public int SignatureStatus { get; set; }
        public bool Disabled { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int Flags { get; set; }
    }
}
