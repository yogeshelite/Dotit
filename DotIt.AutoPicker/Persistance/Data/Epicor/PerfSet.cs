using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PerfSet
    {
        public string Company { get; set; }
        public string DatasetName { get; set; }
        public string Description { get; set; }
        public string ExportId { get; set; }
        public string QueryId { get; set; }
        public DateTime? DateRun { get; set; }
        public string Dimensions { get; set; }
        public string Facts { get; set; }
        public string CalcFacts { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public string Ebiserver { get; set; }
        public string Sqloperator { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
