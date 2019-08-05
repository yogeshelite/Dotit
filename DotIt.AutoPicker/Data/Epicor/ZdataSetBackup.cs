using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ZdataSetBackup
    {
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
