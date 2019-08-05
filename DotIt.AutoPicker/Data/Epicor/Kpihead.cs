using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Kpihead
    {
        public string Company { get; set; }
        public string Kpicode { get; set; }
        public bool CrossCompany { get; set; }
        public string Kpidescription { get; set; }
        public string Kpiname { get; set; }
        public bool SystemFlag { get; set; }
        public string Kpiparent { get; set; }
        public string ParentRule { get; set; }
        public string KpiheadBaqid { get; set; }
        public string KpimemberTypes { get; set; }
        public bool CalendarKpi { get; set; }
        public string CalendarType { get; set; }
        public string Kpitype { get; set; }
        public string KpidefType { get; set; }
        public string KpiperiodType { get; set; }
        public bool FieldDataSpecific { get; set; }
        public string TableName { get; set; }
        public string DimensionName { get; set; }
        public string FieldName { get; set; }
        public string DimFieldName { get; set; }
        public string ValueType { get; set; }
        public string Kpicurrency { get; set; }
        public bool UseReportingCurr { get; set; }
        public string KpiweightType { get; set; }
        public decimal Kpiweight { get; set; }
        public string KpiweightBaqfield { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
