using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imbmsyst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public bool UnapproveRevOnCheckout { get; set; }
        public bool VerifyPassword { get; set; }
        public bool WorkflowRequired { get; set; }
        public decimal NextEconumber { get; set; }
        public int EcoseqLength { get; set; }
        public bool SingleUser { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
