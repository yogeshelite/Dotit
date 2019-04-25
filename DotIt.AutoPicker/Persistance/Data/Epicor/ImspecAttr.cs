using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImspecAttr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string SpecType { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public string AttributeId { get; set; }
        public string Description { get; set; }
        public string ScreenLabel { get; set; }
        public decimal MinDec { get; set; }
        public decimal MaxDec { get; set; }
        public decimal IncrPrec { get; set; }
        public DateTime? MinDate { get; set; }
        public DateTime? MaxDate { get; set; }
        public string InitVal { get; set; }
        public string ToolTip { get; set; }
        public string ListValues { get; set; }
        public bool GlobalSpecAttr { get; set; }
        public bool GlobalLock { get; set; }
        public string CmbPassValues { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
