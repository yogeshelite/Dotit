using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptCriteriaFilter
    {
        public string Company { get; set; }
        public string RptDefId { get; set; }
        public string RptCriteriaSetId { get; set; }
        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public string AdapterName { get; set; }
        public string LookupField { get; set; }
        public string FilterLabel { get; set; }
        public string TabLabel { get; set; }
        public string DataType { get; set; }
        public string EpiGuid { get; set; }
        public int DisplayOrder { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptCriteriaSet Rpt { get; set; }
    }
}
