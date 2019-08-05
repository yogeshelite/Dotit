﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrebateDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RebateId { get; set; }
        public int LineNum { get; set; }
        public string PartNum { get; set; }
        public string ProdCode { get; set; }
        public bool Void { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal AccruedAmount { get; set; }
        public string BreakType { get; set; }
        public string Uomcode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
