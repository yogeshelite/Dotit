using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MxpaymentTaxRcptError
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public int HeadNum { get; set; }
        public int ErrorSeq { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
