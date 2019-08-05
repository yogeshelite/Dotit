using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AgelectronicInvcError
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int ErrorSeq { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
