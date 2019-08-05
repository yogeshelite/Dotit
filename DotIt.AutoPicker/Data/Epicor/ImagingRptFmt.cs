using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImagingRptFmt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string FmtCode { get; set; }
        public string Description { get; set; }
        public bool DefaultFmt { get; set; }
        public string Company { get; set; }
        public int AgeDays2 { get; set; }
        public int AgeDays4 { get; set; }
        public int AgeDays5 { get; set; }
        public int AgeDays3 { get; set; }
        public int AgeDays1 { get; set; }
        public string AgeLabels2 { get; set; }
        public string AgeLabels3 { get; set; }
        public string AgeLabels4 { get; set; }
        public string AgeLabels6 { get; set; }
        public string AgeLabels5 { get; set; }
        public string AgeLabels1 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
