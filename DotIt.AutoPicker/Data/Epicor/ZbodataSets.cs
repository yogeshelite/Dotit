using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ZbodataSets
    {
        public string SystemCode { get; set; }
        public string ClassName { get; set; }
        public string DataSetSystemCode { get; set; }
        public string DataSetId { get; set; }
        public string ObjectNs { get; set; }
        public bool IsMainDataSet { get; set; }
        public bool IsListDataSet { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ZdataSet DataSet { get; set; }
        public virtual Zbodef Zbodef { get; set; }
    }
}
