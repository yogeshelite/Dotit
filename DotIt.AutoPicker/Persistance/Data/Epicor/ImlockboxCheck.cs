using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImlockboxCheck
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string LockboxId { get; set; }
        public int LbcheckId { get; set; }
        public string BatchNum { get; set; }
        public DateTime? BatchDate { get; set; }
        public int BatchStubCount { get; set; }
        public decimal BatchTotalAmt { get; set; }
        public string CheckRef { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal CheckTotalAmt { get; set; }
        public bool CheckWoinvoices { get; set; }
        public string CustId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
