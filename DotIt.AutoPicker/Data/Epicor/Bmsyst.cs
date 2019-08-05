using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Bmsyst
    {
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
