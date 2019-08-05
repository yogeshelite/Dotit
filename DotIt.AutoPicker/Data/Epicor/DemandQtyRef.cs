﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DemandQtyRef
    {
        public string Company { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public int DemandDtlSeq { get; set; }
        public int DemandScheduleSeq { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public int Seq { get; set; }
        public decimal Quantity { get; set; }
        public string CustReference { get; set; }
        public string RoutingCode { get; set; }
        public string PartNum { get; set; }
        public string LotNum { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
