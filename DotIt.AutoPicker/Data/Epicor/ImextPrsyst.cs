using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImextPrsyst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FilePath { get; set; }
        public string ExtIntCompId { get; set; }
        public bool ConsHrs { get; set; }
        public bool TempD { get; set; }
        public bool ZeroNul { get; set; }
        public bool SupHead { get; set; }
        public int SemiMonthDay { get; set; }
        public string Delimiter { get; set; }
        public bool TotalAllHrs { get; set; }
        public bool GrpPayTypeId { get; set; }
        public string PayExportLayoutId { get; set; }
        public bool DetailHours { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SplitExportLines { get; set; }
    }
}
