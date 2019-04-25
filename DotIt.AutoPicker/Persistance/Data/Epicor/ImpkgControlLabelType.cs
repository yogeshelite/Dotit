using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpkgControlLabelType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public string LabelType { get; set; }
        public string PartNum { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string PkgCode { get; set; }
        public string PkgControlIdcode { get; set; }
        public bool IsPartDefault { get; set; }
        public int NumLabelsToPrint { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ReportId { get; set; }
        public int StyleNum { get; set; }
        public bool PromptForReportStyle { get; set; }
        public int MaxPartQtyPerLabel { get; set; }
    }
}
