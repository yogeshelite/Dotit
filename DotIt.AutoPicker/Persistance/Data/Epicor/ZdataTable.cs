using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ZdataTable
    {
        public ZdataTable()
        {
            ExtensionDataSetTable = new HashSet<ExtensionDataSetTable>();
            ExtensionRelationChild = new HashSet<ExtensionRelation>();
            ExtensionRelationParent = new HashSet<ExtensionRelation>();
            RptCalcField = new HashSet<RptCalcField>();
            RptExclude = new HashSet<RptExclude>();
            RptLinkField = new HashSet<RptLinkField>();
            RptLinkTable = new HashSet<RptLinkTable>();
            RptTable = new HashSet<RptTable>();
            RptWhereItem = new HashSet<RptWhereItem>();
            ZdataField = new HashSet<ZdataField>();
            Zkey = new HashSet<Zkey>();
            ZlinkColumn = new HashSet<ZlinkColumn>();
            ZlookupLinkForeign = new HashSet<ZlookupLink>();
            ZlookupLinkZdataTable = new HashSet<ZlookupLink>();
            ZrelationChild = new HashSet<Zrelation>();
            ZrelationParent = new HashSet<Zrelation>();
            ZsubDataSet = new HashSet<ZsubDataSet>();
        }

        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string Description { get; set; }
        public string SchemaName { get; set; }
        public string DbtableName { get; set; }
        public string WhereClause { get; set; }
        public bool RestrictedByTer { get; set; }
        public bool RestrictedByPlant { get; set; }
        public bool FullSync { get; set; }
        public string TableType { get; set; }
        public bool SystemFlag { get; set; }
        public string TableLabel { get; set; }
        public string ChgLogId { get; set; }
        public string Boupdate { get; set; }
        public string UpdateMethod { get; set; }
        public string Cgccode { get; set; }
        public string Interface { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Zsystem SystemCodeNavigation { get; set; }
        public virtual ICollection<ExtensionDataSetTable> ExtensionDataSetTable { get; set; }
        public virtual ICollection<ExtensionRelation> ExtensionRelationChild { get; set; }
        public virtual ICollection<ExtensionRelation> ExtensionRelationParent { get; set; }
        public virtual ICollection<RptCalcField> RptCalcField { get; set; }
        public virtual ICollection<RptExclude> RptExclude { get; set; }
        public virtual ICollection<RptLinkField> RptLinkField { get; set; }
        public virtual ICollection<RptLinkTable> RptLinkTable { get; set; }
        public virtual ICollection<RptTable> RptTable { get; set; }
        public virtual ICollection<RptWhereItem> RptWhereItem { get; set; }
        public virtual ICollection<ZdataField> ZdataField { get; set; }
        public virtual ICollection<Zkey> Zkey { get; set; }
        public virtual ICollection<ZlinkColumn> ZlinkColumn { get; set; }
        public virtual ICollection<ZlookupLink> ZlookupLinkForeign { get; set; }
        public virtual ICollection<ZlookupLink> ZlookupLinkZdataTable { get; set; }
        public virtual ICollection<Zrelation> ZrelationChild { get; set; }
        public virtual ICollection<Zrelation> ZrelationParent { get; set; }
        public virtual ICollection<ZsubDataSet> ZsubDataSet { get; set; }
    }
}
