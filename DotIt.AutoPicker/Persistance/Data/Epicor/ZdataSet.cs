using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ZdataSet
    {
        public ZdataSet()
        {
            ExtensionDataSetTable = new HashSet<ExtensionDataSetTable>();
            ExtensionRelation = new HashSet<ExtensionRelation>();
            ZbodataSets = new HashSet<ZbodataSets>();
            Zrelation = new HashSet<Zrelation>();
            ZsubDataSet = new HashSet<ZsubDataSet>();
        }

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

        public virtual Zsystem SystemCodeNavigation { get; set; }
        public virtual ICollection<ExtensionDataSetTable> ExtensionDataSetTable { get; set; }
        public virtual ICollection<ExtensionRelation> ExtensionRelation { get; set; }
        public virtual ICollection<ZbodataSets> ZbodataSets { get; set; }
        public virtual ICollection<Zrelation> Zrelation { get; set; }
        public virtual ICollection<ZsubDataSet> ZsubDataSet { get; set; }
    }
}
