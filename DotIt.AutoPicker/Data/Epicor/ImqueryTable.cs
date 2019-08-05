using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImqueryTable
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string QueryId { get; set; }
        public Guid SubQueryId { get; set; }
        public string TableId { get; set; }
        public int Seq { get; set; }
        public string DbschemaName { get; set; }
        public string DbtableName { get; set; }
        public string TableType { get; set; }
        public bool IsSummaryTable { get; set; }
        public bool IsVisibleInDesigner { get; set; }
        public string Modifiers { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PivotFunction { get; set; }
        public string PivotDataType { get; set; }
        public string PivotFieldFormat { get; set; }
    }
}
